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
    public partial class bookAvailablefrm : Form
    {
        LibraryManagementSystemEntities context;
        List<IssueTran> issueList;
        List<IssueTran> findList;
        MainForm main;

        /// <summary>
        /// Initialize
        /// </summary>
        
        public bookAvailablefrm()
        {
            InitializeComponent();
        }

        private void bookAvailablefrm_Load(object sender, EventArgs e)
        {
            context = new LibraryManagementSystemEntities();
            issueList = new List<IssueTran>();
            findList = new List<IssueTran>();
            main = (MainForm)MdiParent;

            //Find availability date of books
            issueList = context.IssueTrans.Where(x => x.LoanStatus == "Out" && x.DateDue>DateTime.Today).ToList();
            DisplayGrid(issueList);
        }

        /// <summary>
        /// Features
        /// </summary>

        //Search feature
        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (bookrdo.Checked == true)
            {
                if (searchtxt.Text == "")
                {
                    bookAvailableListdgv.DataSource = issueList;
                    main.StatusValue = issueList.Count.ToString() + " results";
                }

                else
                {
                    findList = context.IssueTrans.Where(x => DbFunctions.Like(x.Book.Title, "%" + searchtxt.Text.Trim() + "%") && x.LoanStatus == "Out").ToList();
                    DisplayGrid(findList);
                }
            }

            else if (memberrdo.Checked == true)
            {
                if (searchtxt.Text == "")
                {
                    bookAvailableListdgv.DataSource = issueList;
                    main.StatusValue = issueList.Count.ToString() + " results";
                }

                else
                {
                    findList = context.IssueTrans.Where(x => DbFunctions.Like(x.Member.LastName + x.Member.FirstName, "%" + searchtxt.Text.Trim() + "%")).ToList();
                    DisplayGrid(findList);
                }
            }
        }

        private void searchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchbtn.PerformClick();
            }
        }

        /// <summary>
        /// Methods
        /// </summary>

        //Show simplified grid
        public void DisplayGrid(List<IssueTran> issuelist)
        {
            bookAvailableListdgv.DataSource = issuelist.Select(x => new
            {
                x.TransactionID,
                Name = x.Member.LastName + " " + x.Member.FirstName,
                BookName = x.Book.Title,
                AvailabilityDate = x.DateDue
            }).ToList();

            main.StatusValue = findList.Count.ToString() + " results";
        }

        //Clear all search results
        private void clearbtn_Click(object sender, EventArgs e)
        {
            DisplayGrid(issueList);
            main.StatusValue = "Results cleared";
            searchtxt.Clear();
        }
    }
}
