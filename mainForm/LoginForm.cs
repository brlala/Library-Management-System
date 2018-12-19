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
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Initialize
        /// </summary>
        LibraryManagementSystemEntities context;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            context = new LibraryManagementSystemEntities();
        }

        /// <summary>
        /// Property
        /// </summary>
        public string EmployeeId
        {
            get
            {
                return userIdtxt.Text.Trim();
            }
        }

        /// <summary>
        /// Features
        /// </summary>
        //Login
        private void loginbtn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach(UserMaster usermaster in context.UserMasters)
            {
                if (userIdtxt.Text.Trim() == usermaster.EmployeeID && passwordtxt.Text == usermaster.Password)
                {
                    //check if user is employed or terminated
                    if (usermaster.Employee.Status == "Employed")
                    {
                        DialogResult = DialogResult.OK;
                        flag = true;
                    }

                    else
                    {
                        MessageBox.Show("Your account has been disabled!");
                    }

                }
            }
            if (!flag)
            {
                MessageBox.Show("Invalid User ID or Password!");
                userIdtxt.Clear();
                passwordtxt.Clear();
                userIdtxt.Focus();
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void passwordtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginbtn_Click(null, null);
            }
        }
    }
}
