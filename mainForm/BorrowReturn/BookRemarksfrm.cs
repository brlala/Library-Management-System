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
    public partial class bookRemarksfrm : Form
    {
        /// <summary>
        /// Initialize
        /// </summary>
        
        public bookRemarksfrm(string transID, string memberID, string bookID, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            transIDtxt.Text = transID;
            memberIDtxt.Text = memberID;
            bookIDtxt.Text = bookID.ToString();
            startDatetxt.Text = startDate.ToString("dd-MMM-yyyy");
            endDatetxt.Text = endDate.ToString("dd-MMM-yyyy");
            confirmBtn.DialogResult = DialogResult.OK;
        }

        private void bookRemarksfrm_Load(object sender, EventArgs e)
        {
            if (transIDtxt.Text.Substring(0, 1) == "T")
            {
                transIDlbl.Text = "Transaction ID";
                startDatelbl.Text = "Issue Date";
                endDatelbl.Text = "Due Date";
                remarkstxt.Text = "(Book Loan) ";
            }

            else
            {
                transIDlbl.Text = "Reservation ID";
                startDatelbl.Text = "Reserve Date";
                endDatelbl.Text = "Reserve Due";
                remarkstxt.Text = "(Book Reserve) ";
            }
        }
        /// <summary>
        /// Property
        /// </summary>

        public string Remarks
        { get; set; }

        /// <summary>
        /// Features
        /// </summary>
        /// <param name="sender"></param>

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Remarks = remarkstxt.Text;
            this.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
