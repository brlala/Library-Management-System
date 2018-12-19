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
    public partial class ReportViewForm : Form
    {
        /// <summary>
        /// Initialize
        /// </summary>
        public ReportViewForm()
        {
            InitializeComponent();
        }
        
        public ReportViewForm(Object sender)
        {
            InitializeComponent();
            MainForm mainForm = new MainForm();
            LibraryManagementSystemEntities context = new LibraryManagementSystemEntities();
            if (sender.ToString() == mainForm.BorrowingReport.ToString())
            {
                BorrowingReport bR = new BorrowingReport();
                bR.Database.Tables[0].SetDataSource(context.IssueTrans);
                bR.Database.Tables[1].SetDataSource(context.Books);
                reportViewer.ReportSource = bR;
            }
            else if (sender.ToString() == mainForm.BookInfo.ToString())
            {
                ListBooksReport lB = new ListBooksReport();
                lB.SetDataSource(context.Books);
                reportViewer.ReportSource = lB;
            }
            else if(sender.ToString() == mainForm.OutstandingBook.ToString())
            {
                ListOutstandingBooks oB = new ListOutstandingBooks();
                oB.Database.Tables[1].SetDataSource(context.Members);
                oB.Database.Tables[0].SetDataSource(context.IssueTrans);
                reportViewer.ReportSource = oB;
            }
            else if(sender.ToString() == mainForm.GenreReport.ToString())
            {
                AllBorrowingsbyGenre aBBG = new AllBorrowingsbyGenre();
                aBBG.Database.Tables[0].SetDataSource(context.Books);
                aBBG.Database.Tables[1].SetDataSource(context.IssueTrans);
                reportViewer.ReportSource = aBBG;
            }
            else if(sender.ToString() == mainForm.OverdueReport.ToString())
            {
                OverdueReport oR = new OverdueReport();
                oR.Database.Tables[0].SetDataSource(context.IssueTrans);
                oR.Database.Tables[1].SetDataSource(context.Members);
                reportViewer.ReportSource = oR;
            }
        }
    }
}
