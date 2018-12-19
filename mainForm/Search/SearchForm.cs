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
    public partial class SearchForm : Form
    {
        LibraryManagementSystemEntities context;
        MainForm main;
        List<Book> listAllBook;

        /// <summary>
        /// Initialize
        /// </summary>
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            context = new LibraryManagementSystemEntities();
            listAllBook = new List<Book>();
            listAllBook = context.Books.ToList();
            DisplayList(listAllBook);

            //Set max and min date
            startTimedtp.MaxDate = finishTimedtp.Value.Date;
            finishTimedtp.MinDate = startTimedtp.Value.Date;
            finishTimedtp.MaxDate = DateTime.Today.Date;
            
            //Initializing combolist selection
            genrecomb.Items.AddRange(context.Books.GroupBy(x=>x.Genre).Select(y=>y.Key).ToArray());
            languagecomb.Items.AddRange(context.Books.GroupBy(x => x.Language).Select(y => y.Key).ToArray());
            typecomb.Items.AddRange(context.Books.GroupBy(x => x.Type.BookType).Select(y => y.Key).ToArray());
             main = (MainForm)MdiParent;
        }

        /// <summary>
        /// Features
        /// </summary>
        
        //Data validation controlling range of date
        private void startTimedtp_ValueChanged(object sender, EventArgs e)
        {
            finishTimedtp.MinDate = startTimedtp.Value.Date;
        }

        private void finishTimedtp_ValueChanged(object sender, EventArgs e)
        {
            startTimedtp.MaxDate = finishTimedtp.Value.Date;
        }

        //Change different search
        private void bookIdrdo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                searchtxt.Visible = false;
                searchmtxt.Visible = true;
            }
            else
            {
                searchtxt.Visible = true;
                searchmtxt.Visible = false;
            }
        }

        //Main Search
        private void searchbtn_Click(object sender, EventArgs e)
        {
            IQueryable<Book> bookData = context.Books;
            bool showBookData = true;

            //Search Genre filter
            if (genrecomb.SelectedItem != null)
            {
                bookData = bookData.Where(x => x.Genre == genrecomb.SelectedItem.ToString());
            }

            //Search Language filter
            if (languagecomb.SelectedItem != null)
            {
                bookData = bookData.Where(x => x.Language == languagecomb.SelectedItem.ToString());
            }

            //Search Type filter
            if (typecomb.SelectedItem != null)
            {
                bookData = bookData.Where(x => x.Type.BookType == typecomb.SelectedItem.ToString());
            }

            //Search Publish Date filter
            bookData = bookData.Where(x => DateTime.Compare(x.PublishDate, startTimedtp.Value) >= 0 
                                      && DateTime.Compare(x.PublishDate, finishTimedtp.Value) <= 0);

            //Search Recommended Age filter
            int startAge = Convert.ToInt32(startAgemtxt.Text);
            int finishAge = Convert.ToInt32(finishAgemtxt.Text);
            bookData = bookData.Where(x => x.RecommendedAge >= startAge && x.RecommendedAge <= finishAge);

            //Search BookID filter 
            if (bookIdrdo.Checked == true)
            {
                if (searchmtxt.Text != "")
                {
                    int bookId = Convert.ToInt32(searchmtxt.Text);
                    bookData = bookData.Where(x => x.BookID.ToString() == bookId.ToString());
                }
            }

            //Search BookTitle filter
            if (titlerdo.Checked)
            {
                if (searchtxt.Text != "")
                {
                    List<Book> books = new List<Book>();
                    foreach (Book book in bookData)
                    {
                        if (VagueSearch(searchtxt.Text, book.Title))
                        {
                            books.Add(book);
                        }
                    }
                    showBookData = false;
                    if (books.Count > 0)
                    {
                        main.StatusValue = "Search Complete!";
                    }
                    else
                    {
                        main.StatusValue = "No Data Found!";
                    }
                    DisplayList(books);
                }
            }

            //Search Author Name filter
            if (authorrdo.Checked)
            {
                if (searchtxt.Text != "")
                {
                    List<Book> books = new List<Book>();
                    foreach (Book book in bookData)
                    {
                        foreach (Author author in book.Authors)
                        {
                            if (VagueSearch(searchtxt.Text, author.FirstName) || VagueSearch(searchtxt.Text, author.LastName))
                            {
                                books.Add(book);
                            }
                        }
                    }
                    showBookData = false;
                    if (books.Count > 0)
                    {
                        main.StatusValue = "Search Complete!";
                    }
                    else
                    {
                        main.StatusValue = "No Data Found!";
                    }
                    DisplayList(books);
                }
            }
            
            //Search Publisher Name filter
            if (publisherrdo.Checked)
            {
                if (searchtxt.Text != "")
                {
                    List<Book> books = new List<Book>();
                    foreach (Book book in bookData)
                    {
                        if (VagueSearch(searchtxt.Text, book.Publisher.PublisherName))
                        {
                            books.Add(book);
                        }
                    }
                    showBookData = false;
                    if (books.Count > 0)
                    {
                        main.StatusValue = "Search Complete!";
                    }
                    else
                    {
                        main.StatusValue = "No Data Found!";
                    }
                    DisplayList(books);
                }
            }

            if (showBookData)
            {
                if (bookData.ToList().Count > 0)
                {
                    main.StatusValue = "Search Complete!";
                }
                else
                {
                    main.StatusValue = "No Data Found!";
                }
                bookInfodgv.DataSource = bookData.
                    Select(x => new { x.BookID, x.Title, x.Genre, x.Publisher.PublisherName, x.PublishDate,
                        x.Language, x.BookType, x.Location, x.TotalStock, x.QtyLoaned, x.RecommendedAge, x.ISBN }).ToList();
            }
        }

        private void searchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchbtn.PerformClick();
            }
        }

        //Clear results
        private void clearbtn_Click(object sender, EventArgs e)
        {
            DisplayList(listAllBook);
        }

        /// <summary>
        /// Methods
        /// </summary>

        //Search word similar LIKE %%search%%
        private bool VagueSearch(string s1, string s2)
        {
            if (s1.Length > s2.Length)
            {
                return false;
            }
            else
            {
                for(int i =0; i <= (s2.Length - s1.Length); i++)
                {
                    if(s2.Substring(i,s1.Length).ToLower() == s1.ToLower())
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        //Display data with only selected column
        private void DisplayList(List<Book> listbook)
        {
            bookInfodgv.DataSource = listbook.
                Select(x => new { ID = x.BookID, x.Title, x.Genre, x.Publisher.PublisherName, x.PublishDate,
                    x.Language, x.BookType, x.Location, x.TotalStock, x.QtyLoaned, x.RecommendedAge, x.ISBN }).ToList();
        }
    }
}
