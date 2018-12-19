namespace mainForm
{
    partial class CreateUpdateEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.employeeIdlbl = new System.Windows.Forms.Label();
            this.employeeIdtxt = new System.Windows.Forms.TextBox();
            this.contactTitlelbl = new System.Windows.Forms.Label();
            this.dateOfBirthdtp = new System.Windows.Forms.DateTimePicker();
            this.lastNametxt = new System.Windows.Forms.TextBox();
            this.firstNametxt = new System.Windows.Forms.TextBox();
            this.dateOfBirthlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNamelbl = new System.Windows.Forms.Label();
            this.employeeCategorycbb = new System.Windows.Forms.ComboBox();
            this.emStatuscbb = new System.Windows.Forms.ComboBox();
            this.emStatuslbl = new System.Windows.Forms.Label();
            this.employeeCatelogylbl = new System.Windows.Forms.Label();
            this.contactNumlbl = new System.Windows.Forms.Label();
            this.contactNumtxt = new System.Windows.Forms.TextBox();
            this.dateOfHirelbl = new System.Windows.Forms.Label();
            this.dateOfHiredtp = new System.Windows.Forms.DateTimePicker();
            this.saveEmployeebtn = new System.Windows.Forms.Button();
            this.updateEmployeerdo = new System.Windows.Forms.RadioButton();
            this.createEmployeerdo = new System.Windows.Forms.RadioButton();
            this.contactTitlecbb = new System.Windows.Forms.ComboBox();
            this.browsebtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // employeeIdlbl
            // 
            this.employeeIdlbl.AutoSize = true;
            this.employeeIdlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdlbl.Location = new System.Drawing.Point(27, 30);
            this.employeeIdlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeIdlbl.Name = "employeeIdlbl";
            this.employeeIdlbl.Size = new System.Drawing.Size(107, 21);
            this.employeeIdlbl.TabIndex = 1;
            this.employeeIdlbl.Text = "Employee ID";
            // 
            // employeeIdtxt
            // 
            this.employeeIdtxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdtxt.ForeColor = System.Drawing.Color.Black;
            this.employeeIdtxt.Location = new System.Drawing.Point(148, 30);
            this.employeeIdtxt.Margin = new System.Windows.Forms.Padding(2);
            this.employeeIdtxt.Name = "employeeIdtxt";
            this.employeeIdtxt.Size = new System.Drawing.Size(160, 27);
            this.employeeIdtxt.TabIndex = 1;
            this.toolTip1.SetToolTip(this.employeeIdtxt, "Enter Employee ID (E#####)");
            this.employeeIdtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.employeeIdtxt_KeyDown);
            this.employeeIdtxt.Leave += new System.EventHandler(this.employeeIdtxt_Leave);
            // 
            // contactTitlelbl
            // 
            this.contactTitlelbl.AutoSize = true;
            this.contactTitlelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTitlelbl.Location = new System.Drawing.Point(320, 155);
            this.contactTitlelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactTitlelbl.Name = "contactTitlelbl";
            this.contactTitlelbl.Size = new System.Drawing.Size(113, 21);
            this.contactTitlelbl.TabIndex = 3;
            this.contactTitlelbl.Text = "Contact Title";
            // 
            // dateOfBirthdtp
            // 
            this.dateOfBirthdtp.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthdtp.CustomFormat = "dd-MMM-yyyy";
            this.dateOfBirthdtp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthdtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthdtp.Location = new System.Drawing.Point(148, 202);
            this.dateOfBirthdtp.Margin = new System.Windows.Forms.Padding(2);
            this.dateOfBirthdtp.MaxDate = new System.DateTime(2018, 9, 26, 18, 9, 41, 0);
            this.dateOfBirthdtp.Name = "dateOfBirthdtp";
            this.dateOfBirthdtp.Size = new System.Drawing.Size(151, 27);
            this.dateOfBirthdtp.TabIndex = 5;
            this.toolTip1.SetToolTip(this.dateOfBirthdtp, "Please select date of birth");
            this.dateOfBirthdtp.Value = new System.DateTime(2018, 8, 31, 0, 0, 0, 0);
            // 
            // lastNametxt
            // 
            this.lastNametxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNametxt.Location = new System.Drawing.Point(148, 112);
            this.lastNametxt.Margin = new System.Windows.Forms.Padding(2);
            this.lastNametxt.Name = "lastNametxt";
            this.lastNametxt.Size = new System.Drawing.Size(160, 27);
            this.lastNametxt.TabIndex = 3;
            this.toolTip1.SetToolTip(this.lastNametxt, "Enter Last Name (Letters only)");
            // 
            // firstNametxt
            // 
            this.firstNametxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNametxt.Location = new System.Drawing.Point(148, 69);
            this.firstNametxt.Margin = new System.Windows.Forms.Padding(2);
            this.firstNametxt.Name = "firstNametxt";
            this.firstNametxt.Size = new System.Drawing.Size(160, 27);
            this.firstNametxt.TabIndex = 2;
            this.toolTip1.SetToolTip(this.firstNametxt, "Enter First Name (Letters only)");
            // 
            // dateOfBirthlbl
            // 
            this.dateOfBirthlbl.AutoSize = true;
            this.dateOfBirthlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthlbl.Location = new System.Drawing.Point(27, 205);
            this.dateOfBirthlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateOfBirthlbl.Name = "dateOfBirthlbl";
            this.dateOfBirthlbl.Size = new System.Drawing.Size(107, 21);
            this.dateOfBirthlbl.TabIndex = 7;
            this.dateOfBirthlbl.Text = "Date of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last Name";
            // 
            // firstNamelbl
            // 
            this.firstNamelbl.AutoSize = true;
            this.firstNamelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNamelbl.Location = new System.Drawing.Point(27, 71);
            this.firstNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNamelbl.Name = "firstNamelbl";
            this.firstNamelbl.Size = new System.Drawing.Size(91, 21);
            this.firstNamelbl.TabIndex = 9;
            this.firstNamelbl.Text = "First Name";
            // 
            // employeeCategorycbb
            // 
            this.employeeCategorycbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeCategorycbb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeCategorycbb.FormattingEnabled = true;
            this.employeeCategorycbb.Location = new System.Drawing.Point(498, 71);
            this.employeeCategorycbb.Margin = new System.Windows.Forms.Padding(2);
            this.employeeCategorycbb.Name = "employeeCategorycbb";
            this.employeeCategorycbb.Size = new System.Drawing.Size(160, 29);
            this.employeeCategorycbb.TabIndex = 6;
            this.toolTip1.SetToolTip(this.employeeCategorycbb, "Select Employee Category");
            // 
            // emStatuscbb
            // 
            this.emStatuscbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emStatuscbb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emStatuscbb.FormattingEnabled = true;
            this.emStatuscbb.Location = new System.Drawing.Point(498, 196);
            this.emStatuscbb.Margin = new System.Windows.Forms.Padding(2);
            this.emStatuscbb.Name = "emStatuscbb";
            this.emStatuscbb.Size = new System.Drawing.Size(160, 29);
            this.emStatuscbb.TabIndex = 9;
            this.toolTip1.SetToolTip(this.emStatuscbb, "Select Employment Status");
            // 
            // emStatuslbl
            // 
            this.emStatuslbl.AutoSize = true;
            this.emStatuslbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emStatuslbl.Location = new System.Drawing.Point(320, 196);
            this.emStatuslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emStatuslbl.Name = "emStatuslbl";
            this.emStatuslbl.Size = new System.Drawing.Size(59, 21);
            this.emStatuslbl.TabIndex = 13;
            this.emStatuslbl.Text = "Status";
            // 
            // employeeCatelogylbl
            // 
            this.employeeCatelogylbl.AutoSize = true;
            this.employeeCatelogylbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeCatelogylbl.Location = new System.Drawing.Point(320, 74);
            this.employeeCatelogylbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeCatelogylbl.Name = "employeeCatelogylbl";
            this.employeeCatelogylbl.Size = new System.Drawing.Size(165, 21);
            this.employeeCatelogylbl.TabIndex = 14;
            this.employeeCatelogylbl.Text = "Employee Category";
            // 
            // contactNumlbl
            // 
            this.contactNumlbl.AutoSize = true;
            this.contactNumlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumlbl.Location = new System.Drawing.Point(27, 160);
            this.contactNumlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactNumlbl.Name = "contactNumlbl";
            this.contactNumlbl.Size = new System.Drawing.Size(78, 21);
            this.contactNumlbl.TabIndex = 17;
            this.contactNumlbl.Text = "Contact";
            // 
            // contactNumtxt
            // 
            this.contactNumtxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumtxt.Location = new System.Drawing.Point(148, 157);
            this.contactNumtxt.Margin = new System.Windows.Forms.Padding(2);
            this.contactNumtxt.Name = "contactNumtxt";
            this.contactNumtxt.Size = new System.Drawing.Size(160, 27);
            this.contactNumtxt.TabIndex = 4;
            this.toolTip1.SetToolTip(this.contactNumtxt, "Enter Contact Number (Numbers only)");
            // 
            // dateOfHirelbl
            // 
            this.dateOfHirelbl.AutoSize = true;
            this.dateOfHirelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfHirelbl.Location = new System.Drawing.Point(320, 115);
            this.dateOfHirelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateOfHirelbl.Name = "dateOfHirelbl";
            this.dateOfHirelbl.Size = new System.Drawing.Size(102, 21);
            this.dateOfHirelbl.TabIndex = 14;
            this.dateOfHirelbl.Text = "Date of Hire";
            // 
            // dateOfHiredtp
            // 
            this.dateOfHiredtp.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfHiredtp.CustomFormat = "dd-MMM-yyyy";
            this.dateOfHiredtp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfHiredtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfHiredtp.Location = new System.Drawing.Point(498, 113);
            this.dateOfHiredtp.Margin = new System.Windows.Forms.Padding(2);
            this.dateOfHiredtp.MaxDate = new System.DateTime(2018, 9, 26, 18, 9, 41, 0);
            this.dateOfHiredtp.Name = "dateOfHiredtp";
            this.dateOfHiredtp.Size = new System.Drawing.Size(160, 27);
            this.dateOfHiredtp.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dateOfHiredtp, "Select Date of Hire");
            this.dateOfHiredtp.Value = new System.DateTime(2018, 8, 31, 0, 0, 0, 0);
            // 
            // saveEmployeebtn
            // 
            this.saveEmployeebtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEmployeebtn.Location = new System.Drawing.Point(512, 249);
            this.saveEmployeebtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveEmployeebtn.Name = "saveEmployeebtn";
            this.saveEmployeebtn.Size = new System.Drawing.Size(146, 48);
            this.saveEmployeebtn.TabIndex = 10;
            this.saveEmployeebtn.Text = "Update";
            this.toolTip1.SetToolTip(this.saveEmployeebtn, "Save Employee");
            this.saveEmployeebtn.UseVisualStyleBackColor = true;
            this.saveEmployeebtn.Click += new System.EventHandler(this.saveEmployeebtn_Click);
            // 
            // updateEmployeerdo
            // 
            this.updateEmployeerdo.AutoSize = true;
            this.updateEmployeerdo.BackColor = System.Drawing.SystemColors.Control;
            this.updateEmployeerdo.Checked = true;
            this.updateEmployeerdo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmployeerdo.Location = new System.Drawing.Point(576, 2);
            this.updateEmployeerdo.Margin = new System.Windows.Forms.Padding(2);
            this.updateEmployeerdo.Name = "updateEmployeerdo";
            this.updateEmployeerdo.Size = new System.Drawing.Size(98, 26);
            this.updateEmployeerdo.TabIndex = 19;
            this.updateEmployeerdo.TabStop = true;
            this.updateEmployeerdo.Text = "Update";
            this.toolTip1.SetToolTip(this.updateEmployeerdo, "Click to Update Employee");
            this.updateEmployeerdo.UseVisualStyleBackColor = false;
            // 
            // createEmployeerdo
            // 
            this.createEmployeerdo.AutoSize = true;
            this.createEmployeerdo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEmployeerdo.Location = new System.Drawing.Point(576, 44);
            this.createEmployeerdo.Margin = new System.Windows.Forms.Padding(2);
            this.createEmployeerdo.Name = "createEmployeerdo";
            this.createEmployeerdo.Size = new System.Drawing.Size(93, 26);
            this.createEmployeerdo.TabIndex = 20;
            this.createEmployeerdo.Text = "Create";
            this.toolTip1.SetToolTip(this.createEmployeerdo, "Click to Create Employee");
            this.createEmployeerdo.UseVisualStyleBackColor = true;
            this.createEmployeerdo.CheckedChanged += new System.EventHandler(this.createEmployeerdo_CheckedChanged);
            // 
            // contactTitlecbb
            // 
            this.contactTitlecbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactTitlecbb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTitlecbb.FormattingEnabled = true;
            this.contactTitlecbb.Location = new System.Drawing.Point(498, 154);
            this.contactTitlecbb.Margin = new System.Windows.Forms.Padding(2);
            this.contactTitlecbb.Name = "contactTitlecbb";
            this.contactTitlecbb.Size = new System.Drawing.Size(160, 29);
            this.contactTitlecbb.TabIndex = 8;
            this.toolTip1.SetToolTip(this.contactTitlecbb, "Select Contact Title");
            // 
            // browsebtn
            // 
            this.browsebtn.Location = new System.Drawing.Point(324, 28);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(25, 23);
            this.browsebtn.TabIndex = 23;
            this.browsebtn.Text = "...";
            this.browsebtn.UseVisualStyleBackColor = true;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // CreateUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 351);
            this.Controls.Add(this.browsebtn);
            this.Controls.Add(this.contactTitlecbb);
            this.Controls.Add(this.updateEmployeerdo);
            this.Controls.Add(this.createEmployeerdo);
            this.Controls.Add(this.saveEmployeebtn);
            this.Controls.Add(this.contactNumlbl);
            this.Controls.Add(this.employeeCategorycbb);
            this.Controls.Add(this.emStatuscbb);
            this.Controls.Add(this.emStatuslbl);
            this.Controls.Add(this.dateOfHirelbl);
            this.Controls.Add(this.employeeCatelogylbl);
            this.Controls.Add(this.dateOfHiredtp);
            this.Controls.Add(this.dateOfBirthdtp);
            this.Controls.Add(this.contactNumtxt);
            this.Controls.Add(this.lastNametxt);
            this.Controls.Add(this.firstNametxt);
            this.Controls.Add(this.dateOfBirthlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNamelbl);
            this.Controls.Add(this.contactTitlelbl);
            this.Controls.Add(this.employeeIdtxt);
            this.Controls.Add(this.employeeIdlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateUpdateEmployee";
            this.Text = "Employee Info";
            this.Load += new System.EventHandler(this.CreateUpdateEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeIdlbl;
        private System.Windows.Forms.TextBox employeeIdtxt;
        private System.Windows.Forms.Label contactTitlelbl;
        private System.Windows.Forms.DateTimePicker dateOfBirthdtp;
        private System.Windows.Forms.TextBox lastNametxt;
        private System.Windows.Forms.TextBox firstNametxt;
        private System.Windows.Forms.Label dateOfBirthlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstNamelbl;
        private System.Windows.Forms.ComboBox employeeCategorycbb;
        private System.Windows.Forms.ComboBox emStatuscbb;
        private System.Windows.Forms.Label emStatuslbl;
        private System.Windows.Forms.Label employeeCatelogylbl;
        private System.Windows.Forms.Label contactNumlbl;
        private System.Windows.Forms.TextBox contactNumtxt;
        private System.Windows.Forms.Label dateOfHirelbl;
        private System.Windows.Forms.DateTimePicker dateOfHiredtp;
        private System.Windows.Forms.Button saveEmployeebtn;
        private System.Windows.Forms.RadioButton updateEmployeerdo;
        private System.Windows.Forms.RadioButton createEmployeerdo;
        private System.Windows.Forms.ComboBox contactTitlecbb;
        private System.Windows.Forms.Button browsebtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}