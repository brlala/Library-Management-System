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
    public partial class StockAdjForm : Form
    {
        LibraryManagementSystemEntities context;
        Book book;
        bool sAFound;
        MainForm main;
        decimal numericMin;

        /// <summary>
        /// Initialize
        /// </summary>
        
        public StockAdjForm()
        {
            InitializeComponent();
        }

        private void StockAdjForm_Load(object sender, EventArgs e)
        {
            main = (MainForm)MdiParent;
            context = new LibraryManagementSystemEntities();
            Book book = new Book();
            sAFound = false;
            GenAdjID();
        }

        /// <summary>
        /// Features
        /// </summary>

        //Search
        //Browse button search
        private void searchbtn_Click(object sender, EventArgs e)
        {
            using (var searchForm = new SearchQueryForm(this))
            {
                searchForm.ShowDialog();
                bookIDtxt.Text = searchForm.Result;
                RetrieveData();
                main.StatusValue = "Book selected";
            }
        }

        private void bookIDtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RetrieveData();
            }
        }

        private void bookIDtxt_Leave(object sender, EventArgs e)
        {
            RetrieveData();
        }

        //Update Changes
        private void updatebtn_Click(object sender, EventArgs e)
        {
            RetrieveData();
            if (sAFound)
            {
                UpdateQuantity();
                //MessageBox.Show("Successful");
            }

        }

        private void remarkstxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateQuantity();
            }
        }

        /// <summary>
        /// Methods
        /// </summary>

        //Search and retrieve book data
        private void RetrieveData()
        {
            sAFound = context.Books.Any(x => x.BookID.ToString() == bookIDtxt.Text);
            if (sAFound)
            {
                book = context.Books.Where(x => x.BookID.ToString() == bookIDtxt.Text).First();
                bookTitletxt.Text = book.Title;
                currentQtytxt.Text = book.TotalStock.ToString();
                reservedtxt.Text = book.QtyReserved.ToString();
                onLoantxt.Text = book.QtyLoaned.ToString();

                //Limit quantity of adjustment (never less than stock and loan)
                numericMin = 0 - (book.TotalStock - book.QtyLoaned);
                adjQtynud.Minimum = numericMin;
                main.StatusValue = "Book information displayed";
            }
            else
            {
                main.StatusValue = "Please enter a valid Book ID";
                ClearAll();
            }
        }

        //Update quantity
        private void UpdateQuantity()
        {
            if (adjQtynud.Value==0)
            {
                MessageBox.Show("Stock not changed");
                main.StatusValue = "Please indicate adjustment value.";
            }
            else if (remarkstxt.Text == "")
            {
                MessageBox.Show("Please fill in the remarks field.");
                main.StatusValue = "Please indicate the reason for quantity change";
            }
            else
            {
                StockAdjustment sA = new StockAdjustment
                {
                    AdjID = adjIDtxt.Text,
                    BookID = int.Parse(bookIDtxt.Text),
                    AdjQty = (Int16) adjQtynud.Value,
                    DateAdjusted = DateTime.Today.Date,
                    Remarks = remarkstxt.Text,
                    EmployeeID = main.EmployeeId
                };

                context.StockAdjustments.Add(sA);
                int bookid = Convert.ToInt32(bookIDtxt.Text);
                book = context.Books.Where(x => x.BookID == bookid).First();
                book.TotalStock = (Int16)(book.TotalStock + adjQtynud.Value);
                context.SaveChanges();
                ClearAll();
                main.StatusValue = "Quantity of book adjusted";
                MessageBox.Show("Successful");
                GenAdjID();
            }
        }
        //Generate AdjustmentID
        private void GenAdjID()
        {
            string aID = context.StockAdjustments.OrderByDescending(x => x.AdjID).Select(x => x.AdjID).First().ToString();
            int nID = int.Parse(aID.Substring(1)) + 1;
            adjIDtxt.Text = "A" + nID.ToString().PadLeft(7, '0');
        }

        //Clear all boxes
        private void ClearAll()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox txtbox && c!=adjIDtxt)
                {
                    txtbox.Clear();
                }
            }
            adjQtynud.Value = 0;
        }

        private void adjQtynud_ValueChanged(object sender, EventArgs e)
        {
            if (adjQtynud.Value == numericMin)
                main.StatusValue = "Minimum limit of books reached";
        }
    }
}
