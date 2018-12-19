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
    public partial class CreateUpdateEmployee : Form, ICheckField
    {
        LibraryManagementSystemEntities context;
        MainForm main;
        Employee em;
        List<TextBox> lControlword;
        List<TextBox> lControlnumber;
        List<TextBox> lControlnull;
        bool employeeFound;

        /// <summary>
        /// Initialize
        /// </summary>
        
        public CreateUpdateEmployee()
        {
            InitializeComponent();
        }

        private void CreateUpdateEmployee_Load(object sender, EventArgs e)
        {
            context = new LibraryManagementSystemEntities();
            string[] employeeCategory = context.Employees.Select(x => x.EmployeeCat).Distinct().ToArray();
            employeeCategorycbb.Items.AddRange(employeeCategory);

            string[] contactTitles = context.Employees.Select(x => x.ContactTitle).Distinct().ToArray();
            contactTitlecbb.Items.AddRange(contactTitles);

            string[] employStatus = context.Employees.Select(x => x.Status).Distinct().ToArray();
            emStatuscbb.Items.AddRange(employStatus);

            employeeFound = false;

            //Adding textbox for inheritance CheckField() methods
            lControlword = new List<TextBox>();
            lControlnumber = new List<TextBox>();
            lControlnull = new List<TextBox>();
            lControlword.Add(firstNametxt);
            lControlword.Add(lastNametxt);
            lControlnumber.Add(contactNumtxt);
            foreach (Control c in Controls)
            {
                if (c is TextBox txtbox)
                {
                    lControlnull.Add(txtbox);
                }
            }

            //Set range for max and min date
            dateOfBirthdtp.MaxDate = DateTime.Today;
            dateOfHiredtp.MaxDate = DateTime.Today;
            dateOfBirthdtp.MinDate = DateTime.Today.AddYears(-100);
            dateOfHiredtp.MinDate = DateTime.Today.AddYears(-100);
            
            //Display first employee
            em = context.Employees.First();
            employeeIdtxt.Text = em.EmployeeID;
            RetrieveData();

            main = (MainForm)MdiParent;
        }

        /// <summary>
        /// Features
        /// </summary>
        //Browse member
        private void browsebtn_Click(object sender, EventArgs e)
        {
            using (var searchForm = new SearchQueryForm(this))
            {
                searchForm.ShowDialog();
                employeeIdtxt.Text = searchForm.Result;
                CheckEmployee();
            }
        }

        //Create or update employee
        private void saveEmployeebtn_Click(object sender, EventArgs e)
        {
            if (updateEmployeerdo.Checked == true)
            {
                if (employeeFound)
                {
                    //Check validity of field inputs
                    bool infoCheck1 = false;
                    bool infoCheck2 = false;
                    infoCheck1 = CheckFieldIsNumber(lControlnumber) && CheckFieldIsLetter(lControlword) ? true : false;
                    infoCheck2 = CheckFieldIsComplete(lControlnull) && infoCheck1 ? true : false;
                    if (infoCheck1 && infoCheck2)
                    {
                        WriteData_noID();
                        main.StatusValue = "Employee saved";
                        MessageBox.Show("Successful");
                    }
                    else
                    {
                        MessageBox.Show("The input is incorrect. Kindly check your input.");
                    }
                }
                else
                {
                    main.StatusValue = "Employee not found";
                }
            }

            else if (createEmployeerdo.Checked == true)
            {
                //Check validity of field inputs
                bool infoCheck1 = false;
                bool infoCheck2 = false;
                infoCheck1 = CheckFieldIsNumber(lControlnumber) && CheckFieldIsLetter(lControlword) ? true : false;
                infoCheck2 = CheckFieldIsComplete(lControlnull) && infoCheck1 ? true : false;
                if (infoCheck1 && infoCheck2)
                {
                    em = new Employee
                    {
                        EmployeeID = employeeIdtxt.Text.Trim()
                    };
                    WriteData_noID();
                    context.Employees.Add(em);

                    //Add login for user with default password
                    UserMaster userpass = new UserMaster
                    {
                        EmployeeID = em.EmployeeID,
                        Password = "default"
                    };
                    context.UserMasters.Add(userpass);
                    main.StatusValue = "Employee successfully added";
                    MessageBox.Show("Successful");
                }
                else
                {
                    MessageBox.Show("The input is incorrect. Kindly check your input.");
                }
            }
            context.SaveChanges();
        }

        private void createEmployeerdo_CheckedChanged(object sender, EventArgs e)
        {
            ClearAll();

            if (createEmployeerdo.Checked)
            {
                employeeCategorycbb.SelectedIndex = 0;
                contactTitlecbb.SelectedIndex = 0;
                emStatuscbb.SelectedIndex = 0;
                saveEmployeebtn.Text = "Create";
                browsebtn.Visible = false;
                employeeIdtxt.ReadOnly = true;
                employeeIdtxt.Text = "E" + (context.Employees.Count() + 1).ToString().PadLeft(4, '0');
                
                main.StatusValue = "Create employee selected";
            }
            else if (updateEmployeerdo.Checked)
            {
                saveEmployeebtn.Text = "Update";
                em = context.Employees.First();
                employeeIdtxt.Text = em.EmployeeID;
                RetrieveData();
                browsebtn.Visible = true;
                employeeIdtxt.ReadOnly = false;
                main.StatusValue = "Update employee selected";
            }
        }

        //Search employeeID
        private void employeeIdtxt_Leave(object sender, EventArgs e)
        {
            CheckEmployee();
        }

        private void employeeIdtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                CheckEmployee();
            }
        }

        /// <summary>
        /// Methods
        /// </summary>
        //Retrieve and display data of employee entities
        private void RetrieveData()
        {
            firstNametxt.Text = em.FirstName;
            lastNametxt.Text = em.LastName;
            employeeCategorycbb.Text = em.EmployeeCat;
            dateOfBirthdtp.Value = em.DOB;
            dateOfHiredtp.Value = em.DateHired;
            emStatuscbb.Text = em.Status;
            contactTitlecbb.Text = em.ContactTitle;
            contactNumtxt.Text = em.ContactNumber;
        }

        //Write data into Employee entity w/o ID
        private void WriteData_noID()
        {
            em.FirstName = firstNametxt.Text.Trim();
            em.LastName = lastNametxt.Text.Trim();
            em.EmployeeCat = employeeCategorycbb.Text.Trim();
            em.DOB = dateOfBirthdtp.Value;
            em.DateHired = dateOfHiredtp.Value;
            em.Status = emStatuscbb.Text.Trim();
            em.ContactTitle = contactTitlecbb.Text.Trim();
            em.ContactNumber = contactNumtxt.Text.Trim();
        }

        //Check if employeeID valid
        public void CheckEmployee()
        {            
            employeeFound = context.Employees.Any(y => y.EmployeeID == employeeIdtxt.Text.Trim());
            if (employeeFound)
            {
                em = context.Employees.Where(x => x.EmployeeID == employeeIdtxt.Text).First();
                RetrieveData();
                main.StatusValue = "Employee information displayed";
            }
            else
            {
                main.StatusValue = "Employee not found";
                ClearAll();
            }
        }

        public void ClearAll()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox && c.Name != employeeIdtxt.Name)
                {
                    TextBox txtbox = (TextBox)c;
                    txtbox.Clear();
                }
                if (c is DateTimePicker dtp)
                {
                    dtp.Value = DateTime.Now.Date;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
                }
            }
        }

        //Check encapsulation for fields
        //Check number and letter only fields
        public bool CheckFieldIsNumberLetter(List<TextBox> listControlNum)
        {
            bool check = true;
            for (int i = 0; check == true && i < listControlNum.Count; i++)
            {
                check = listControlNum[i].Text.Trim().All(c => char.IsLetterOrDigit(c));
            }
            return check;
        }
        //Check letter only fields
        public bool CheckFieldIsLetter(List<TextBox> listControlLetter)
        {
            bool check = true;
            for (int i = 0; check == true && i < listControlLetter.Count; i++)
            {
                check = listControlLetter[i].Text.Trim().All(c => char.IsLetter(c));
            }
            return check;
        }

        //Check number only fields
        public bool CheckFieldIsNumber(List<TextBox> listControlNum)
        {
            bool check = true;
            for (int i = 0; check == true && i < listControlNum.Count; i++)
            {
                check = listControlNum[i].Text.Trim().All(c => char.IsDigit(c));
            }
            return check;
        }
        //Check field is complete
        public bool CheckFieldIsComplete(List<TextBox> lControlNull)
        {
            bool check = true;
            for (int i = 0; check == true && i < lControlNull.Count; i++)
            {
                check = !string.IsNullOrEmpty(lControlNull[i].Text) &&
                    !string.IsNullOrWhiteSpace(lControlNull[i].Text) ? true : false;
            }
            return check;
        }
    }
}
