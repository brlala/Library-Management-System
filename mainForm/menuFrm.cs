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
    public partial class MainForm : Form
    {
        LibraryManagementSystemEntities context = new LibraryManagementSystemEntities();
        Employee emp;
        /// <summary>
        /// Initialize
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Property
        /// </summary>
        public object BorrowingReport
        {
            get
            {
                return borrReportbtn;
            }
        }

        public object BookInfo
        {
            get
            {
                return bookInfobtn;
            }
        }

        public object OutstandingBook
        {
            get
            {
                return outstandingBooksbtn;
            }
        }

        public object GenreReport
        {
            get
            {
                return brrGenreReportbtn;
            }
        }

        public object OverdueReport
        {
            get
            {
                return overdueReportbtn;
            }
        }

        /// <summary>
        /// Main Form
        /// </summary>
        //Prompt for login screen
        private void menuForm_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            if (login.DialogResult != DialogResult.OK)
            {
                Close();
            }

            emp = context.Employees.Where(x => x.EmployeeID == login.EmployeeId).First();

            //Show reports menu only for superuser
            employeeIdlbl.Text = "Dear " + login.EmployeeId;
            //employeeIdlbl.Text += login.EmployeeId;
            login.Close();
            IsMdiContainer = true;
            try
            {
                if (emp.EmployeeCategory.JobTitle == "Manager")
                {
                    navReportsbtn.Visible = true;
                }
                else
                {
                    navReportsbtn.Visible = false;
                }
            }
            catch (NullReferenceException)
            {
                navReportsbtn.Visible = false;
            }

            
        }

        /// <summary>
        /// Property
        /// </summary>
        public string StatusValue
        {
            get
            {
                return mdiChildStatusLabel.Text;
            }
            set
            {
                mdiChildStatusLabel.Text = value;
            }
        }

        public string EmployeeId
        {
            get
            {
                return emp.EmployeeID;
                //return employeeIdlbl.Text.Substring(5);
            }
        }


        private void navBasicbtn_Click(object sender, EventArgs e)
        {
            if (subMenupnl.Left == 0)
            {
                timer1.Start();
            }
            else
            {
                timer2.Start();
            }
            MenuDataReturn();
            MenuSearchpnlLeft();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (subMenupnl.Left == 0)
            {
                subMenupnl.Left += 380;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            MenuReturntoLeft();

        }

        private void bookBorrowingbtn_Click(object sender, EventArgs e)
        {
            MenuReturntoLeft();
            InitialMdiChildWindow();
            BooksBorrowfrm borrowForm = new BooksBorrowfrm();
            StartFormMax(borrowForm);
            borrowForm.SetDesktopLocation(480,130);
        }

        private void bookReturningbtn_Click(object sender, EventArgs e)
        {
            MenuReturntoLeft();
            InitialMdiChildWindow();
            ReturnForm returnForm = new ReturnForm();
            StartFormMax(returnForm);
            returnForm.SetDesktopLocation(410,130);
        }

        public void MenuReturntoLeft()
        {
            if (subMenupnl.Left == 380)
            {
                subMenupnl.Left -= 380;
            }
            else
            {
                timer2.Stop();
            }
        }

        private void naviDatabtn_Click(object sender, EventArgs e)
        {
            if (subMenuDatapnl.Left == 0)
            {
                timer3.Start();
            }
            else
            {
                timer4.Start();
            }
            MenuReturntoLeft();
            MenuSearchpnlLeft();
            MenuReportspnlLeft();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (subMenuDatapnl.Left == 0)
            {
                subMenuDatapnl.Left += 380;
            }
            else
            {
                timer3.Stop();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            MenuDataReturn();
        }

        public void MenuDataReturn()
        {
            if (subMenuDatapnl.Left == 380)
            {
                subMenuDatapnl.Left -= 380;
            }
            else
            {
                timer4.Stop();
            }
        }
        private void maintainMemberbtn_Click(object sender, EventArgs e)
        {
            MenuDataReturn();
            InitialMdiChildWindow();
            CreateUpdateMember memberForm = new CreateUpdateMember();
            StartFormMax(memberForm);
            memberForm.SetDesktopLocation(430, 100);
        }

        private void maintainCreateBooksbtn_Click(object sender, EventArgs e)
        {
            MenuDataReturn();
            InitialMdiChildWindow();
            CreateUpdateBooks bookForm = new CreateUpdateBooks();
            StartFormMax(bookForm);
            bookForm.SetDesktopLocation(480, 130);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MenuDataReturn();
            InitialMdiChildWindow();
            CreateUpdateEmployee employeeForm = new CreateUpdateEmployee();
            StartFormMax(employeeForm);
            employeeForm.SetDesktopLocation(400, 180);
        }


        private void stockUpdatebtn_Click(object sender, EventArgs e)
        {
            MenuDataReturn();
            InitialMdiChildWindow();
            StockAdjForm stockForm = new StockAdjForm();
            StartFormMax(stockForm);
            stockForm.SetDesktopLocation(420, 130);
        }

        private void navSearchbtn_Click(object sender, EventArgs e)
        {
            if (menuSearchpnl.Left == 0)
            {
                timer5.Start();
            }
            else
            {
                timer6.Start();
            }
            MenuReturntoLeft();
            MenuDataReturn();
            MenuReportspnlLeft();
        }
      
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (menuSearchpnl.Left == 0)
            {
                menuSearchpnl.Left += 380;
            }
            else
            {
                timer5.Stop();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            MenuSearchpnlLeft();
        }

        public void MenuSearchpnlLeft()
        {
            if (menuSearchpnl.Left == 380)
            {
                menuSearchpnl.Left -= 380;
            }
            else
            {
                timer6.Stop();
            }
        }
        private void searchReListbtn_Click(object sender, EventArgs e)
        {
            MenuSearchpnlLeft();
            InitialMdiChildWindow();
            ReservationListForm reservationForm = new ReservationListForm();
            StartFormMax(reservationForm);
            reservationForm.SetDesktopLocation(420, 130);
        }

        private void bookSearchbtn_Click(object sender, EventArgs e)
        {
            MenuSearchpnlLeft();
            InitialMdiChildWindow();
            SearchForm searchForm = new SearchForm();
            StartFormMax(searchForm);
            searchForm.SetDesktopLocation(420, 130);
        }

        private void bookAvailbtn_Click(object sender, EventArgs e)
        {
            MenuSearchpnlLeft();
            InitialMdiChildWindow();
            bookAvailablefrm bookAvailablefrm = new bookAvailablefrm();
            StartFormMax(bookAvailablefrm);
            bookAvailablefrm.SetDesktopLocation(420, 120);
        }

        private void navReportsbtn_Click(object sender, EventArgs e)
        {
            if (menuReportspnl.Left == 0)
            {
                timer7.Start();
            }
            else
            {
                timer8.Start();
            }
            MenuReturntoLeft();
            MenuDataReturn();
            MenuSearchpnlLeft();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (menuReportspnl.Left == 0)
            {
                menuReportspnl.Left += 380;
            }
            else
            {
                timer7.Stop();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            MenuReportspnlLeft();
        }

        public void MenuReportspnlLeft()
        {
            if (menuReportspnl.Left == 380)
            {
                menuReportspnl.Left -= 380;
            }
            else
            {
                timer8.Stop();
            }
        }

        private void borrReportbtn_Click(object sender, EventArgs e)
        {
            MenuReportspnlLeft();
            ReportViewForm borrowingReport = new ReportViewForm(sender);
            StartFormMax(borrowingReport);
            borrowingReport.SetDesktopLocation(480, 80);
        }

        private void bookInfobtn_Click(object sender, EventArgs e)
        {
            MenuReportspnlLeft();
            ReportViewForm listBooksReport = new ReportViewForm(sender);
            StartFormMax(listBooksReport);
            listBooksReport.SetDesktopLocation(480, 80);
        }

        private void outstandingBooksbtn_Click(object sender, EventArgs e)
        {
            MenuReportspnlLeft();
            ReportViewForm outstandingReport = new ReportViewForm(sender);
            StartFormMax(outstandingReport);
            outstandingReport.SetDesktopLocation(480, 80);
        }

        private void brrGenreReportbtn_Click(object sender, EventArgs e)
        {
            MenuReportspnlLeft();
            ReportViewForm genreReport = new ReportViewForm(sender);
            StartFormMax(genreReport);
            genreReport.SetDesktopLocation(480, 80);
        }

        private void overdueReportbtn_Click(object sender, EventArgs e)
        {
            MenuReportspnlLeft();
            ReportViewForm overdueReport = new ReportViewForm(sender);
            StartFormMax(overdueReport);
            overdueReport.SetDesktopLocation(480, 80);
        }

        private void logoutpb_Click(object sender, EventArgs e)
        {
            InitialMdiChildWindow();
            //employeeIdlbl.Text = "Dear ";
            Hide();
            menuForm_Load(null, null);
            Show();
        }

        /// <summary>
        /// Methods
        /// </summary>

        //Start form maximized to size of MDIParent
        private void StartFormMax(Form varForm)
        {
            varForm.MdiParent = this;
            //varForm.WindowState = FormWindowState.Maximized;
            varForm.Show();
        }

        //Only allow one form to be start at the sametime
        private void InitialMdiChildWindow()
        {
            mdiChildStatusLabel.Text = "";
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                StatusValue = "";
            }
        }

        
    }
}
