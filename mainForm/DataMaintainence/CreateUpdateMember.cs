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
using System.Text.RegularExpressions;

namespace mainForm
{
    interface ICheckField
    {
        bool CheckFieldIsNumberLetter(List<TextBox> listControlNum);
        bool CheckFieldIsLetter(List<TextBox> listControlLetter);
        bool CheckFieldIsNumber(List<TextBox> listControlNum);
        bool CheckFieldIsComplete(List<TextBox> lControlNull);
    }
    public partial class CreateUpdateMember : Form, ICheckField
    {
        LibraryManagementSystemEntities context;
        MainForm main;
        Member m;
        List<TextBox> lControlnumberword;
        List<TextBox> lControlnumber;
        List<TextBox> lControlword;
        List<TextBox> lControlnull;
        bool memberFound;

        /// <summary>
        /// Initialize
        /// </summary>
        
        public CreateUpdateMember()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new LibraryManagementSystemEntities();
            string[] countryNames = context.Countries.Select(x => x.CountryName).Distinct().ToArray();
            countryNamecbb.Items.AddRange(countryNames);

            string[] contactTitles = context.Members.Select(x => x.ContactTitle).Distinct().ToArray();
            contactTitlescbb.Items.AddRange(contactTitles);

            string[] memberCategory = context.MemberCategories.Select(x => x.MemberCat).Distinct().ToArray();
            memberCategorycbb.Items.AddRange(memberCategory);

            memberFound = false;

            //Adding textbox for inheritance CheckField() methods
            lControlnumberword = new List<TextBox>();
            lControlnumber = new List<TextBox>();
            lControlword = new List<TextBox>();
            lControlnull = new List<TextBox>();
            foreach (Control c in Controls)
            {
                if (c is TextBox txtbox)
                {
                    lControlnull.Add(txtbox);
                }
            }
            lControlnumberword.Add(nRictxt);
            lControlword.Add(firstNametxt);
            lControlword.Add(lastNametxt);
            lControlword.Add(citytxt);
            lControlnumber.Add(contactNumtxt);
            lControlnumber.Add(postalCodetxt);

            //Set range for max and min date
            dateOfBirthdtp.MaxDate = DateTime.Today;
            dateOfBirthdtp.MinDate = DateTime.Today.AddYears(-100);

            //Display first member
            m = context.Members.First();
            memberIdtxt.Text = m.MemberID;
            RetrieveData();

            RetrieveData();
            main = (MainForm)MdiParent;
        }

        /// <summary>
        /// Features
        /// </summary>
        //Browser member
        private void browsebtn_Click(object sender, EventArgs e)
        {
            using (var searchForm = new SearchQueryForm(this))
            {
                searchForm.ShowDialog();
                memberIdtxt.Text = searchForm.Result;
                CheckMember();
            }
        }
        //Create or update employee
        private void saveMemberbtn_Click(object sender, EventArgs e)
        {
            if (updateMemberrdo.Checked == true)
            {
                if (memberFound)
                {
                    //Check validity of field inputs
                    bool infoCheck1 = false;
                    bool infoCheck2 = false;
                    infoCheck1 = CheckFieldIsNumber(lControlnumber) && CheckFieldIsLetter(lControlword) ? true : false;
                    infoCheck2 = CheckFieldIsComplete(lControlnull) && CheckFieldIsNumberLetter(lControlnumberword) ? true : false;
                    if (infoCheck1 && infoCheck2)
                    { 
                        WriteData_noID();
                        main.StatusValue = "Member saved";
                        MessageBox.Show("Successful");
                    }
                    else
                    {
                        MessageBox.Show("The input is incorrect/incomplete. Kindly check your input.");
                    }
                }
                else
                {
                    main.StatusValue = "Member not found";
                }
            }

            else if (createMemberrdo.Checked == true)
            {
                //Check validity of field inputs
                bool infoCheck1 = false;
                bool infoCheck2 = false;
                infoCheck1 = CheckFieldIsNumber(lControlnumber) && CheckFieldIsLetter(lControlword) ? true : false;
                infoCheck2 = CheckFieldIsComplete(lControlnull) && CheckFieldIsNumberLetter(lControlnumberword) ? true : false;
                if (infoCheck1 && infoCheck2)
                { 
                    m = new Member
                    {
                        MemberID = memberIdtxt.Text.Trim(),
                        BooksRented = 0,
                        BooksOverdue = 0
                    };
                    WriteData_noID();
                    context.Members.Add(m);
                    main.StatusValue = "Member successfully added";
                    MessageBox.Show("Successful");
                }
                else
                {
                    MessageBox.Show("The input is incorrect/incomplete. Kindly check your input.");
                }
            }
            context.SaveChanges();
        }

        private void createMemberrdo_CheckedChanged(object sender, EventArgs e)
        {
            ClearAll();

            if (createMemberrdo.Checked)
            {
                contactTitlescbb.SelectedIndex = 0;
                memberCategorycbb.SelectedIndex = 0;
                countryNamecbb.SelectedIndex = 0;
                saveMemberbtn.Text = "Create";
                browsebtn.Visible = false;
                memberIdtxt.ReadOnly = true;
                memberIdtxt.Text = "M" + (context.Members.Count() + 1).ToString().PadLeft(9, '0');
                remarkstxt.Text = string.Format("Created on {0}", DateTime.Today.ToShortDateString());
                main.StatusValue = "Create member selected";
            }
            else if (updateMemberrdo.Checked)
            {
                saveMemberbtn.Text = "Update";
                m = context.Members.First();
                memberIdtxt.Text = m.MemberID;
                RetrieveData();
                browsebtn.Visible = true;
                memberIdtxt.ReadOnly = false;
                main.StatusValue = "Update member selected";
            }
        }

        //Search employeeID
        private void memberIdtxt_Leave(object sender, EventArgs e)
        {
            CheckMember();
        }


        private void memberIdtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                CheckMember();
            }
            
        }

        /// <summary>
        /// Methods
        /// </summary>
        //Retrieve and display data of member entities
        private void RetrieveData()
        {
            m = context.Members.Where(x => x.MemberID == memberIdtxt.Text).First();
            firstNametxt.Text = m.FirstName;
            lastNametxt.Text = m.LastName;
            nRictxt.Text = m.NRIC_FIN;
            memberCategorycbb.Text = m.MemberCat;
            dateOfBirthdtp.Value = m.DOB;
            addresstxt.Text = m.Address;
            citytxt.Text = m.City;
            postalCodetxt.Text = m.PostalCode;
            contactNumtxt.Text = m.PhoneNumber;
            countryNamecbb.Text = m.Country.CountryName;
            contactTitlescbb.Text = m.ContactTitle;
            emailAddresstxt.Text = m.EmailAdd;
            remarkstxt.Text = m.Remarks;
        }

        private void WriteData_noID()
        {
            m.FirstName = firstNametxt.Text.Trim();
            m.LastName = lastNametxt.Text.Trim();
            m.NRIC_FIN = nRictxt.Text.Trim();
            m.MemberCat = memberCategorycbb.Text.Trim();
            m.DOB = dateOfBirthdtp.Value;
            m.Address = addresstxt.Text.Trim();
            m.City = citytxt.Text.Trim();
            m.PostalCode = postalCodetxt.Text.Trim();
            m.PhoneNumber = contactNumtxt.Text.Trim();
            m.CountryCode = context.Countries.Where(x=>x.CountryName==countryNamecbb.Text).Select(x=>x.CountryCode).First().ToString();
            m.ContactTitle = contactTitlescbb.Text.Trim();
            m.EmailAdd = emailAddresstxt.Text.Trim();
            m.Remarks = remarkstxt.Text.Trim();
        }

        //Check if memberID valid
        public void CheckMember()
        {
            memberFound = context.Members.Any(x => x.MemberID == memberIdtxt.Text.Trim());
            if (memberFound)
            {
                m = context.Members.Where(x => x.MemberID == memberIdtxt.Text).First();
                RetrieveData();
                main.StatusValue = "Member information displayed";
            }
            else
            {
                main.StatusValue = "Member not found";
                ClearAll();
            }
        }

        public void ClearAll()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox txtbox && c.Name != memberIdtxt.Name)
                {
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
