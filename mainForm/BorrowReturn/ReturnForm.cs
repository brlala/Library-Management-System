using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainForm
{
    public partial class ReturnForm : Form
    {
        LibraryManagementSystemEntities context;
        bool iTFound;
        MainForm main;
        IssueTran iT;
        /// <summary>
        /// Initialize
        /// </summary>

        public ReturnForm()
        {
            InitializeComponent();
        }
 
        private void ReturnForm_Load(object sender, EventArgs e)
        {
            main = (MainForm)MdiParent;
            context = new LibraryManagementSystemEntities();
            IssueTran iT = new IssueTran();
        }

        /// <summary>
        /// Features
        /// </summary>
        
        //Browse transaction database 
        private void searchbtn_Click(object sender, EventArgs e)
        {
            using (var searchForm = new SearchQueryForm(this))
            {
                searchForm.ShowDialog();
                transactionIDtxt.Text = searchForm.Result;
            }
            RetrieveData();
        }

        //Search for valid transaction
        private void transactionIDtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchTransaction();
            }
        }

        private void transactionIDtxt_Leave(object sender, EventArgs e)
        {
            SearchTransaction();
        }

        //Process book return
        private void returnBookbtn_Click(object sender, EventArgs e)
        {
            iTFound = context.IssueTrans.Any(x => x.TransactionID == transactionIDtxt.Text && x.LoanStatus == "Out");
            if (iTFound)
            {
                dateReturnedtxt.Text = DateTime.Today.Date.ToString("dd-MMM-yyyy");
                
                iT = context.IssueTrans.Where(x => x.TransactionID == transactionIDtxt.Text).First();
                iT.Book.QtyLoaned -= 1;
                iT.DateReturned = DateTime.Today.Date;
                iT.Remarks = "Returned";
                iT.LoanStatus = "In";

                Member m = context.Members.Where(x => x.MemberID == memberIDtxt.Text).First();
                if (iT.DateDue < DateTime.Today.Date)
                {
                    m.BooksOverdue = (Int16)(m.BooksOverdue - 1);
                }
                else
                {
                    m.BooksRented = (Int16)(m.BooksRented - 1);
                }

                RetrieveData();
                context.SaveChanges();
                main.StatusValue = "Book returned";
                MessageBox.Show("Successful");
            }

            else
            {
                main.StatusValue = "Please enter a valid transaction.";
            }
        }

        //Extend book loan
        private void extendLoanbtn_Click(object sender, EventArgs e)
        {
            iTFound = context.IssueTrans.Any(x => x.TransactionID == transactionIDtxt.Text && x.LoanStatus == "Out");
            if (iTFound)
            {
                //Check if book can be extended
                iT = context.IssueTrans.Where(x => x.TransactionID == transactionIDtxt.Text).First();
                bool iRFound = context.Reservations.Any(x => x.ReservationStatus == "Open" && x.MemberID == iT.MemberID);

                if (iRFound)
                {
                    main.StatusValue = "This member already reserved a book";
                    MessageBox.Show("Extension declined");
                }
                else if (iT.ExtensionStatus=="Extended")
                {
                    main.StatusValue = "This book has already been extended";
                    MessageBox.Show("Extension declined");
                }

                else
                {
                    int rentalPeriod = context.Types.Where(x => x.BookType == iT.Book.BookType).Select(days => days.RentalPeriod).First();
                    iT.DateDue = iT.DateDue.AddDays(rentalPeriod);
                    iT.Remarks += " (Extension granted)";
                    iT.ExtensionStatus = "Extended";
                    RetrieveData();

                    //If loan is extended, the book collection date for people reserving the book will be extended by 1 week as well
                    foreach (Reservation R in context.Reservations.Where(x => x.BookID == iT.BookID && x.ReservationStatus == "Open"))
                    {
                        R.ReservedUntil = R.ReservedUntil.AddDays(7);
                    }
                    main.StatusValue = "Loan successfully extended";
                    MessageBox.Show("Successful");
                    context.SaveChanges();
                }
            }
            else
            {
                main.StatusValue = "Please enter a valid transaction";
                //label1.Text = "Please enter a valid transaction.";
            }
        }

        /// <summary>
        /// Methods
        /// </summary>

        private void ClearAllTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        //Search
        private void SearchTransaction()
        {
            iTFound = context.IssueTrans.Any(x => x.TransactionID == transactionIDtxt.Text && x.LoanStatus == "Out");
            if (iTFound)
            {
                RetrieveData();
            }
            else
            {
                main.StatusValue = "Please enter a valid transaction";
            }
        }

        //Display data of transaction in form
        private void RetrieveData()
        {
            iTFound = context.IssueTrans.Any(x => x.TransactionID == transactionIDtxt.Text && x.LoanStatus == "Out");
            if (iTFound)
            {
                iT = context.IssueTrans.Where(x => x.TransactionID == transactionIDtxt.Text).First();
                memberIDtxt.Text = iT.MemberID;
                bookIDtxt.Text = iT.BookID.ToString();
                loanStatustxt.Text = iT.LoanStatus;
                extensionStatustxt.Text = iT.ExtensionStatus;
                dateIssuetxt.Text = iT.DateIssue.ToString("dd-MMM-yyyy");
                dateDuetxt.Text = iT.DateDue.ToString("dd-MMM-yyyy");
                remarkstxt.Text = iT.Remarks.ToString().Trim();
                memberFirstNametxt.Text = iT.Member.FirstName;
                memberLastNametxt.Text = iT.Member.LastName;
                bookTitletxt.Text = iT.Book.Title;
                main.StatusValue = "Transaction retrieved";
            }
            else
            {
                main.StatusValue = "Transaction ID not found";
                ClearAllTextBoxes();
            }
        }
    }
}
