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
    public partial class SearchQueryForm : Form
    {
        LibraryManagementSystemEntities context;

        /// <summary>
        /// Property
        /// </summary>
        
        public string Result
        { get; set; }

        DataGridViewRow SelectedRow
        { get; set; }

        /// <summary>
        /// Forms that will call the search query
        /// </summary>
        
        public SearchQueryForm(ReturnForm returnForm)
        {
            InitializeComponent();
            context = new LibraryManagementSystemEntities();

            //********* STORED PROCEDURE
            queryResultdg.DataSource = context.LoanStatOut(); 

        }

        public SearchQueryForm(StockAdjForm SAForm)
        {
            InitializeComponent();
            context = new LibraryManagementSystemEntities();

            //********* STORED PROCEDURE
            queryResultdg.DataSource = context.FindAllBooks();

        }

        public SearchQueryForm(BooksBorrowfrm booksBrwForm)
        {
            InitializeComponent();
            context = new LibraryManagementSystemEntities();

            //********* STORED PROCEDURE
            queryResultdg.DataSource = context.FindAllMembers();

        }

        public SearchQueryForm(CreateUpdateEmployee employeeForm)
        {
            InitializeComponent();
            context = new LibraryManagementSystemEntities();

            //********* STORED PROCEDURE
            queryResultdg.DataSource = context.FindAllEmployees();

        }

        public SearchQueryForm(CreateUpdateMember memberForm)
        {
            InitializeComponent();
            context = new LibraryManagementSystemEntities();

            //********* STORED PROCEDURE
            queryResultdg.DataSource = context.FindAllMembers();
        }

        public SearchQueryForm(CreateUpdateBooks bookForm)
        {
            InitializeComponent();
            context = new LibraryManagementSystemEntities();

            //********* STORED PROCEDURE
            queryResultdg.DataSource = context.FindAllBooks_PubName();
        }

        /// <summary>
        /// Method
        /// </summary>
        
        //Return the value of selected item to the previous form
        private void queryResultdg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = queryResultdg.Rows[e.RowIndex];
            Result = Convert.ToString(SelectedRow.Cells[0].Value);
            this.Close();
        }
    }
}
