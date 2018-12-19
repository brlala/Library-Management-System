using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mainForm
{
    public partial class CreateUpdateBooks : Form
    {
        LibraryManagementSystemEntities context = new LibraryManagementSystemEntities();
        Book book;
        bool foundBook;
        MainForm main;
        public CreateUpdateBooks()
        {
            InitializeComponent();
        }

        private void createrdo_CheckedChanged(object sender, EventArgs e)
        {
            bookIDtxt.ReadOnly = true;
            bookIDtxt.Text = (context.Books.Count() + 1).ToString();
            titletxt.ReadOnly = false;
            //genretxt.ReadOnly = false;
            //publisherddl.Enabled = true;
            datePubtxt.ReadOnly = false;
            datePubtxt.Visible = false;
            pubDatetimepick.Visible = true;
            pubDatetimepick.Enabled = true;
            //languagetxt.ReadOnly = false;
            isbntxt.ReadOnly = false;
            recAgetxt.ReadOnly = false;
            authorlbl.Visible = true;
            authorslb.Visible = true;
            //typeddl.Enabled = true;
            titletxt.Clear();
            //genretxt.Clear();
            
            genrecmb.SelectedIndex = -1;
            publisherddl.SelectedIndex = -1;
            datePubtxt.Clear();
            //languagetxt.Clear();
            languagecmb.SelectedIndex = -1;
            locationddl.SelectedIndex = -1;
            isbntxt.Clear();
            recAgetxt.Clear();
            typeddl.SelectedIndex = -1;
            authorslb.ClearSelected();
            totalStocktxt.Text = "0";
            qtyLoanedtxt.Text = "0";
            qtyReservedtxt.Text = "0";
        }

        private void updaterdo_CheckedChanged(object sender, EventArgs e)
        {
            bookIDtxt.ReadOnly = false;
            titletxt.ReadOnly = true;
            //genretxt.ReadOnly = true;
            //publisherddl.Enabled = false;
            datePubtxt.ReadOnly = true;
            datePubtxt.Visible = true;
            pubDatetimepick.Visible = false;
            pubDatetimepick.Enabled = false;
            //languagetxt.ReadOnly = true;
            //typeddl.Enabled = false;
            isbntxt.ReadOnly = true;
            recAgetxt.ReadOnly = false;
            authorlbl.Visible = false;
            authorslb.Visible = false;
            bookIDtxt.Clear();
            titletxt.Clear();
            //genretxt.Clear();
            genrecmb.SelectedIndex = -1;
            publisherddl.ResetText();
            qtyLoanedtxt.Clear();
            datePubtxt.Clear();
            //languagetxt.Clear();
            languagecmb.SelectedIndex = -1;
            isbntxt.Clear();
            recAgetxt.Clear();
            typeddl.ResetText();
            totalStocktxt.Clear();
            locationddl.ResetText();
            qtyReservedtxt.Clear();
            
        }
        private void bookIDtxt_TextChanged(object sender, EventArgs e)
        {
            if (updaterdo.Checked == true && bookIDtxt.Text != "")
            {
                List<Book> bList = context.Books.ToList();
                int bookID_int = Convert.ToInt32(bookIDtxt.Text);
                foundBook = bList.Any(x => x.BookID == bookID_int);

                if (foundBook)
                {
                    book = context.Books.Where(x => x.BookID == bookID_int).First();

                    titletxt.Text = book.Title;
                    //genretxt.Text = book.Genre;
                    genrecmb.Text = book.Genre;

                    publisherddl.Text = book.Publisher.PublisherName;
                    datePubtxt.Text = book.PublishDate.ToShortDateString();
                    //languagetxt.Text = book.Language;
                    languagecmb.Text = book.Language;
                    typeddl.Text = book.BookType;
                    isbntxt.Text = book.ISBN;
                    recAgetxt.Text = book.RecommendedAge.ToString();
                    totalStocktxt.Text = book.TotalStock.ToString();
                    locationddl.Text = book.Location;
                    qtyLoanedtxt.Text = book.QtyLoaned.ToString();
                    qtyReservedtxt.Text = book.QtyReserved.ToString();

                    
                }

                else
                {
                    MessageBox.Show("Book not found.");
                }
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            

            if (updaterdo.Checked == true)
            {
                //update
                Publisher publisher = context.Publishers.Where(x => x.PublisherName == publisherddl.Text).First();
                Type type = context.Types.Where(x => x.BookType == typeddl.Text).First();
                book.Publisher = publisher;
                book.Type = type;
                book.Language = languagecmb.Text;
                book.Location = locationddl.Text;
                book.TotalStock = short.Parse(totalStocktxt.Text);
                book.QtyLoaned = short.Parse(qtyLoanedtxt.Text);
                book.QtyReserved = short.Parse(qtyReservedtxt.Text);
                book.Genre = genrecmb.SelectedItem.ToString();
                string[] authorNames = new string[3];
                authorslb.SelectedItems.CopyTo(authorNames, 0);
                //HashSet<Author> authors = new HashSet<Author>();
                foreach (string author in authorNames)
                {
                    if (author == null)
                    {
                        break;
                    }
                    string[] authorFullName = author.Split();
                    string firstName = authorFullName[0];
                    string lastName = authorFullName[1];
                    Author selectedAuthor = context.Authors.Where(x => x.FirstName == firstName && x.LastName == lastName).First();
                    book.Authors.Add(selectedAuthor);
                }
                main.StatusValue = "Changes saved!";
            }

            else if (createrdo.Checked == true)
            {
                //create
                book = new Book();
                book.BookID = int.Parse(bookIDtxt.Text);
                book.Title = titletxt.Text;
                book.Genre = genrecmb.SelectedItem.ToString();
                //book.PublisherID = publisherddl.Text;
                book.PublishDate = pubDatetimepick.Value.Date;
                //book.Language = languagetxt.Text;
                book.Language = languagecmb.Text;
                //book.BookType = typeddl.Text;
                book.Location = locationddl.Text;
                book.TotalStock = short.Parse(totalStocktxt.Text);
                book.QtyLoaned = short.Parse(qtyLoanedtxt.Text);
                book.QtyReserved = short.Parse(qtyReservedtxt.Text);
                book.RecommendedAge = short.Parse(recAgetxt.Text);
                book.ISBN = isbntxt.Text;
                Publisher publisher = context.Publishers.Where(x => x.PublisherName == publisherddl.Text).First();
                Type type = context.Types.Where(x => x.BookType == typeddl.Text).First();
                book.Publisher = publisher;
                book.Type = type;
                string[] authorNames = new string[3];
                authorslb.SelectedItems.CopyTo(authorNames, 0);
                HashSet<Author> authors = new HashSet<Author>();
                foreach(string author in authorNames)
                {
                    if(author == null)
                    {
                        break;
                    }
                    string[] authorFullName = author.Split();
                    string firstName = authorFullName[0];
                    string lastName = authorFullName[1];
                    Author selectedAuthor = context.Authors.Where(x => x.FirstName == firstName && x.LastName == lastName).First();
                    book.Authors.Add(selectedAuthor);
                }
                context.Books.Add(book);
                main.StatusValue = "New book created! Please navigate to Stock Adjustment form to add stock.";
            }
            context.SaveChanges();






        }

        private void Form1_Load(object sender, EventArgs e)
        {
            book = new Book();
            foundBook = false;
            authorslb.Items.AddRange(context.Authors.Select(x => new { AuthorName = x.FirstName + " " + x.LastName }).Select(y => y.AuthorName).ToArray());
            genrecmb.Items.AddRange(context.Books.GroupBy(x => x.Genre).Select(y => y.Key).ToArray());
            publisherddl.Items.AddRange(context.Publishers.Select(x => x.PublisherName).ToArray());
            typeddl.Items.AddRange(context.Types.Select(x => x.BookType).ToArray());
            languagecmb.Items.AddRange(context.Books.GroupBy(x => x.Language).Select(y => y.Key).ToArray());
            main = (MainForm)MdiParent;
        }

        private void authorslb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (authorslb.SelectedItems.Count > 3)
            {
                MessageBox.Show("You can select at most three authors!");
                authorslb.ClearSelected();
            }
        }
    }
}
