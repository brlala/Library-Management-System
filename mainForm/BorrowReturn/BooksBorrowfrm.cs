using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace mainForm
{
    public partial class BooksBorrowfrm : Form
    {
        LibraryManagementSystemEntities context;
        List<Book> listBookList;
        List<Book> confirmBookList;
        Member mbr;
        Book book;
        Reservation rsrv;
        IssueTran issuetran;
        DateTime defaultdate;
        int selectedRow;
        bool memberFound;
        bool reservationFound;
        MainForm main;

        /// <summary>
        /// Initialize
        /// </summary>
        public BooksBorrowfrm()
        {
            InitializeComponent();
        }

        private void booksBorrowfrm_Load(object sender, EventArgs e)
        {
            context = new LibraryManagementSystemEntities();

            //Display first screenbook list
            DisplaySimpleTable(listBooksdtg, context.Books.OrderBy(x => x.BookID).ToList());
            listBookList = context.Books.ToList();

            //initialize second table
            confirmBookList = new List<Book>();
            DisplaySimpleTable(confirmBookdtg, confirmBookList);

            mbr = context.Members.First();
            memberFound = false;
            reservationFound = false;
            selectedRow = 0;
            defaultdate = new DateTime(1970, 1, 1);

            //grey out the form when member not valid
            listBooksdtg.ForeColor = Color.Gray;
            listBooksdtg.GridColor = Color.Gray;

            main = (MainForm)MdiParent;
        }

        /// <summary>
        /// Features
        /// </summary>
        
        //Datagrid selection
        private void listBooksdtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            confirmBookdtg.ClearSelection();
        }
        private void confirmBookdtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            listBooksdtg.ClearSelection();
        }

        //Booking feature
        //Add book to book cart
        private void addBooksbtn_Click(object sender, EventArgs e)
        {
            if (memberFound)
            {
                if (listBookList.Count >= 1)
                {
                    //allow members to rent within their memberCategory quota limit, 3 books for new users, 5 books for old user
                    if (booksQuotatxt.Text == "0")
                    {
                        MessageBox.Show("You are out of books quota to rent.");
                    }

                    else
                    {
                        selectedRow = listBooksdtg.CurrentRow.Index;
                        book = listBookList[selectedRow];
                        confirmBookList.Add(book);
                        DisplaySimpleTable(confirmBookdtg, confirmBookList);
                        selectedRow = 0;
                        searchtxt.Clear();
                        booksQuotatxt.Text = Convert.ToString(Convert.ToInt16(booksQuotatxt.Text) - 1);
                        main.StatusValue = "Book added";
                    }
                }

                else
                {
                    main.StatusValue="No books to add";
                }
            }

            else
            {
                MessageBox.Show("Please select a member.");
            }
        }

        //Remove book from book cart
        private void removeBooksbtn_Click(object sender, EventArgs e)
        {
            if (confirmBookList.Count>=1)
            {
                selectedRow = confirmBookdtg.CurrentRow.Index;
                book = confirmBookList[selectedRow];
                confirmBookList.Remove(book);
                booksQuotatxt.Text = Convert.ToString(Convert.ToInt16(booksQuotatxt.Text) + 1);
                main.StatusValue = "Book removed";
            }
            else
            {
                main.StatusValue = "No books to remove";
            }
            DisplaySimpleTable(confirmBookdtg, confirmBookList);
        }

        private void confirmBookdtg_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            confirmBookdtg.ClearSelection();
        }

        //Clear book cart
        private void clearAllbtn_Click(object sender, EventArgs e)
        {
            confirmBookList.Clear();
            booksQuotatxt.Text = (mbr.MemberCategory.NoOfBooks - mbr.BooksRented).ToString();
            DisplaySimpleTable(confirmBookdtg, confirmBookList);
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Search book feature
        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                listBookList = context.Books.ToList();
                DisplaySimpleTable(listBooksdtg, listBookList);
                main.StatusValue = listBookList.Count.ToString() + " results";
            }
            else
            {
                listBookList = context.Books.Where(name => DbFunctions.Like(name.Title, "%" + searchtxt.Text + "%")).ToList();
                DisplaySimpleTable(listBooksdtg, listBookList);
                main.StatusValue = listBookList.Count.ToString() + " results";
            }
        }

        //Search member feature
        //Use Enter key to search
        private void memberIDtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckMember();
            }
        }

        private void memberIDtxt_Leave(object sender, EventArgs e)
        {
            CheckMember();
            confirmBookList.Clear();
            DisplaySimpleTable(confirmBookdtg, confirmBookList);
        }

        private void memberIDtxt_TextChanged(object sender, EventArgs e)
        {
            clearAllbtn.PerformClick();
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            using (var searchForm = new SearchQueryForm(this))
            {
                searchForm.ShowDialog();
                memberIDtxt.Text = searchForm.Result;
                CheckMember();
                main.StatusValue = "Member selected";
            }
        }

        //Check if member is retrieving reserved book, loaning, or reserving
        private void confirmbtn_Click(object sender, EventArgs e)
        {
            if (memberFound)
            {
                foreach (Book c in confirmBookList)
                {
                    //Retrieving reserved book, close reserve status
                    reservationFound = context.Reservations.Any(x => x.BookID == c.BookID && x.MemberID == memberIDtxt.Text);
                    if (reservationFound && c.QtyLoaned<c.TotalStock)
                    {
                        main.StatusValue = "Retrieving reserved book.";
                        rsrv = context.Reservations.Where(x => x.BookID == c.BookID && x.MemberID == memberIDtxt.Text).First();
                        rsrv.ReservationStatus = "Close";
                        c.QtyReserved -= 1;
                        LoanIssueTrans(c);
                    }

                    //Loan book
                    else if (c.TotalStock > c.QtyLoaned + c.QtyReserved)
                    {
                        main.StatusValue = "Booking...";
                        c.QtyLoaned += 1;
                        LoanIssueTrans(c);
                    }

                    //Reserving book
                    else if ((c.QtyLoaned + c.QtyReserved) >= c.TotalStock)
                    {
                        main.StatusValue = "Reserving...";
                        //Find list of bookID rented out
                        List<IssueTran> bookOut = new List<IssueTran>();
                        DateTime earliestDate;

                        //Find earliest duedate
                        bool findbook = false;
                        findbook = context.IssueTrans.Any(x => x.LoanStatus == "Out" && x.BookID == c.BookID);
                        if (findbook)
                        {
                            bookOut = context.IssueTrans.Where(x => x.LoanStatus == "Out" && x.BookID == c.BookID).ToList();
                            earliestDate = bookOut.Min(date => date.DateDue);
                        }

                        else
                        {
                            earliestDate = DateTime.Now;
                        }

                        //Find max days of loan period based on book type, book 14 days, magazine 7 days
                        int rentalPeriod = context.Types.Where(x => x.BookType == c.BookType).Select(days => days.RentalPeriod).First();

                        //Reservation feature
                        rsrv = new Reservation();

                        //generateRsrvID
                        string generateRsrvID_str = context.Reservations.OrderByDescending(pID => pID.ReservationID).Select(x => x.ReservationID).First().ToString();
                        int generateRsrvID_int = int.Parse(generateRsrvID_str.Substring(1)) + 1;
                        generateRsrvID_str = "R" + Convert.ToString(generateRsrvID_int).PadLeft(9, '0');
                        rsrv.ReservationID = generateRsrvID_str;

                        rsrv.MemberID = memberIDtxt.Text;
                        rsrv.BookID = c.BookID;
                        rsrv.ReservedOn = DateTime.Today;
                        rsrv.ReservedUntil = earliestDate.Date.AddDays(rentalPeriod);
                        rsrv.ReservationStatus = "Open";
                        using (bookRemarksfrm remarksfrm = new bookRemarksfrm(rsrv.ReservationID, mbr.LastName + " " + mbr.FirstName, book.Title, rsrv.ReservedOn, rsrv.ReservedUntil))
                        {
                            DialogResult dr = new DialogResult();
                            dr = remarksfrm.ShowDialog();
                            rsrv.Remarks = remarksfrm.Remarks.Trim();

                            //Check if user confirm reservation or cancel
                            if (dr == DialogResult.OK)
                            {
                                context.Reservations.Add(rsrv);
                                c.QtyReserved += 1;
                                MessageBox.Show("Successful");
                                main.StatusValue = "Book reservation complete";
                            }
                            else
                            {
                                MessageBox.Show("Reservation for current book cancelled");
                            }
                        }
                    }
                    context.SaveChanges();
                }
                clearAllbtn.PerformClick();
                CheckMember();
                DisplaySimpleTable(listBooksdtg, context.Books.OrderBy(x => x.BookID).ToList());
            }
            else
            {
                MessageBox.Show("Member not found!");
                main.StatusValue = "Member not found";
            }
        }

        /// <summary>
        /// Methods
        /// </summary>
        
        //Check if member exist
        public void CheckMember()
        {
            memberFound = context.Members.Any(x => x.MemberID == memberIDtxt.Text);
            if (memberFound)
            {
                mbr = context.Members.Where(ID => ID.MemberID == memberIDtxt.Text).First();
                memberNametxt.Text = mbr.LastName + " " + mbr.FirstName;
                booksLoantxt.Text = mbr.BooksRented.ToString();
                booksReservetxt.Text = context.Reservations.Where(x=>x.MemberID==memberIDtxt.Text).Count().ToString();
                booksQuotatxt.Text = (mbr.MemberCategory.NoOfBooks-mbr.BooksRented).ToString();
                listBooksdtg.ForeColor = Color.Black;
                confirmBookdtg.ForeColor = Color.Black;

            }
            else
            {
                memberNametxt.Text = "Member not found!";
                listBooksdtg.ForeColor = Color.Gray;
                confirmBookdtg.ForeColor = Color.Gray;
            }
        }
        //Book Loan process
        public void LoanIssueTrans(Book c)
        {
            issuetran = new IssueTran();

            //generateIssueID
            string generateIssueID_str = context.IssueTrans.OrderByDescending(pID=>pID.TransactionID).Select(x => x.TransactionID).First().ToString();
            int generateIssueID_int = int.Parse(generateIssueID_str.Substring(1)) + 1;
            generateIssueID_str = "T" + Convert.ToString(generateIssueID_int).PadLeft(9, '0');
            issuetran.TransactionID = generateIssueID_str;

            issuetran.MemberID = memberIDtxt.Text;
            issuetran.BookID = c.BookID;
            issuetran.DateIssue = DateTime.Today;
            issuetran.DateDue = DateTime.Today.AddDays(7);
            issuetran.DateReturned = defaultdate.Date;
            issuetran.LoanStatus = "Out";
            issuetran.ExtensionStatus = "Nil";
            using (bookRemarksfrm remarksfrm = new bookRemarksfrm(issuetran.TransactionID, mbr.LastName + " " + mbr.FirstName, book.Title, issuetran.DateIssue,issuetran.DateDue))
            {
                DialogResult dr = new DialogResult();
                dr = remarksfrm.ShowDialog();
                issuetran.Remarks = remarksfrm.Remarks.Trim();

                //Check if user confirm booking or cancel
                if (dr == DialogResult.OK)
                {
                    context.IssueTrans.Add(issuetran);
                    mbr.BooksRented += 1;
                    MessageBox.Show("Successful");
                    main.StatusValue = "Book loan complete";
                }
                else
                {
                    MessageBox.Show("Booking for current book cancelled");
                }
            }
        }

        //Display in gridview simplified table
        public void DisplaySimpleTable(DataGridView dtg,List<Book> list)
        {
            dtg.DataSource = list.Select(x => new
            {
                ID = x.BookID,
                x.Title,
                x.Genre,
                x.Language,
                x.ISBN,
                x.PublishDate,
                Quantity = x.TotalStock,
                OnLoan = x.QtyLoaned,
                OnReserve = x.QtyReserved
            }).ToList();
        }
    }
}
