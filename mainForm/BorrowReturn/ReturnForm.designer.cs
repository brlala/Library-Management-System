namespace mainForm
{
    partial class ReturnForm
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
            this.extendLoanbtn = new System.Windows.Forms.Button();
            this.returnBookbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.remarkstxt = new System.Windows.Forms.TextBox();
            this.dateReturnedtxt = new System.Windows.Forms.TextBox();
            this.dateDuetxt = new System.Windows.Forms.TextBox();
            this.dateIssuetxt = new System.Windows.Forms.TextBox();
            this.loanStatustxt = new System.Windows.Forms.TextBox();
            this.bookTitletxt = new System.Windows.Forms.TextBox();
            this.bookIDtxt = new System.Windows.Forms.TextBox();
            this.memberLastNametxt = new System.Windows.Forms.TextBox();
            this.memberFirstNametxt = new System.Windows.Forms.TextBox();
            this.extensionStatustxt = new System.Windows.Forms.TextBox();
            this.memberIDtxt = new System.Windows.Forms.TextBox();
            this.transactionIDtxt = new System.Windows.Forms.TextBox();
            this.remarkslbl = new System.Windows.Forms.Label();
            this.extensionStatuslbl = new System.Windows.Forms.Label();
            this.loanStatuslbl = new System.Windows.Forms.Label();
            this.dateReturnedlbl = new System.Windows.Forms.Label();
            this.dueDatelbl = new System.Windows.Forms.Label();
            this.dateIssuelbl = new System.Windows.Forms.Label();
            this.bookTitlelbl = new System.Windows.Forms.Label();
            this.bookIDlbl = new System.Windows.Forms.Label();
            this.memberLastNamelbl = new System.Windows.Forms.Label();
            this.memberFirstNamelbl = new System.Windows.Forms.Label();
            this.memberIDlbl = new System.Windows.Forms.Label();
            this.transactionIDlbl = new System.Windows.Forms.Label();
            this.returnFormtoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // extendLoanbtn
            // 
            this.extendLoanbtn.Location = new System.Drawing.Point(658, 548);
            this.extendLoanbtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.extendLoanbtn.Name = "extendLoanbtn";
            this.extendLoanbtn.Size = new System.Drawing.Size(184, 58);
            this.extendLoanbtn.TabIndex = 80;
            this.extendLoanbtn.Text = "Extend Loan";
            this.returnFormtoolTip.SetToolTip(this.extendLoanbtn, "Extend Loan");
            this.extendLoanbtn.UseVisualStyleBackColor = true;
            this.extendLoanbtn.Click += new System.EventHandler(this.extendLoanbtn_Click);
            // 
            // returnBookbtn
            // 
            this.returnBookbtn.Location = new System.Drawing.Point(896, 548);
            this.returnBookbtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.returnBookbtn.Name = "returnBookbtn";
            this.returnBookbtn.Size = new System.Drawing.Size(184, 58);
            this.returnBookbtn.TabIndex = 79;
            this.returnBookbtn.Text = "Return Book";
            this.returnFormtoolTip.SetToolTip(this.returnBookbtn, "Return Book");
            this.returnBookbtn.UseVisualStyleBackColor = true;
            this.returnBookbtn.Click += new System.EventHandler(this.returnBookbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(382, 43);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(44, 38);
            this.searchbtn.TabIndex = 78;
            this.searchbtn.Text = "...";
            this.returnFormtoolTip.SetToolTip(this.searchbtn, "Browse Transaction");
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // remarkstxt
            // 
            this.remarkstxt.Location = new System.Drawing.Point(175, 392);
            this.remarkstxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.remarkstxt.Multiline = true;
            this.remarkstxt.Name = "remarkstxt";
            this.remarkstxt.Size = new System.Drawing.Size(905, 127);
            this.remarkstxt.TabIndex = 77;
            this.returnFormtoolTip.SetToolTip(this.remarkstxt, "Enter remarks (eg. condition of books, extension status)");
            // 
            // dateReturnedtxt
            // 
            this.dateReturnedtxt.Enabled = false;
            this.dateReturnedtxt.Location = new System.Drawing.Point(909, 319);
            this.dateReturnedtxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dateReturnedtxt.Name = "dateReturnedtxt";
            this.dateReturnedtxt.Size = new System.Drawing.Size(171, 26);
            this.dateReturnedtxt.TabIndex = 76;
            this.returnFormtoolTip.SetToolTip(this.dateReturnedtxt, "Date Returned");
            // 
            // dateDuetxt
            // 
            this.dateDuetxt.Enabled = false;
            this.dateDuetxt.Location = new System.Drawing.Point(596, 316);
            this.dateDuetxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dateDuetxt.Name = "dateDuetxt";
            this.dateDuetxt.Size = new System.Drawing.Size(154, 26);
            this.dateDuetxt.TabIndex = 75;
            this.returnFormtoolTip.SetToolTip(this.dateDuetxt, "Due Date");
            // 
            // dateIssuetxt
            // 
            this.dateIssuetxt.Enabled = false;
            this.dateIssuetxt.Location = new System.Drawing.Point(175, 319);
            this.dateIssuetxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dateIssuetxt.Name = "dateIssuetxt";
            this.dateIssuetxt.Size = new System.Drawing.Size(182, 26);
            this.dateIssuetxt.TabIndex = 74;
            this.returnFormtoolTip.SetToolTip(this.dateIssuetxt, "Date Issued");
            // 
            // loanStatustxt
            // 
            this.loanStatustxt.Enabled = false;
            this.loanStatustxt.Location = new System.Drawing.Point(175, 249);
            this.loanStatustxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.loanStatustxt.Name = "loanStatustxt";
            this.loanStatustxt.Size = new System.Drawing.Size(182, 26);
            this.loanStatustxt.TabIndex = 73;
            this.returnFormtoolTip.SetToolTip(this.loanStatustxt, "Loan Status");
            // 
            // bookTitletxt
            // 
            this.bookTitletxt.Enabled = false;
            this.bookTitletxt.Location = new System.Drawing.Point(596, 188);
            this.bookTitletxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bookTitletxt.Name = "bookTitletxt";
            this.bookTitletxt.Size = new System.Drawing.Size(484, 26);
            this.bookTitletxt.TabIndex = 72;
            this.returnFormtoolTip.SetToolTip(this.bookTitletxt, "Book Title");
            // 
            // bookIDtxt
            // 
            this.bookIDtxt.Enabled = false;
            this.bookIDtxt.Location = new System.Drawing.Point(175, 188);
            this.bookIDtxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bookIDtxt.Name = "bookIDtxt";
            this.bookIDtxt.Size = new System.Drawing.Size(182, 26);
            this.bookIDtxt.TabIndex = 71;
            this.returnFormtoolTip.SetToolTip(this.bookIDtxt, "Book ID");
            // 
            // memberLastNametxt
            // 
            this.memberLastNametxt.Enabled = false;
            this.memberLastNametxt.Location = new System.Drawing.Point(909, 128);
            this.memberLastNametxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.memberLastNametxt.Name = "memberLastNametxt";
            this.memberLastNametxt.Size = new System.Drawing.Size(171, 26);
            this.memberLastNametxt.TabIndex = 70;
            this.returnFormtoolTip.SetToolTip(this.memberLastNametxt, "Last Name");
            // 
            // memberFirstNametxt
            // 
            this.memberFirstNametxt.Enabled = false;
            this.memberFirstNametxt.Location = new System.Drawing.Point(596, 128);
            this.memberFirstNametxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.memberFirstNametxt.Name = "memberFirstNametxt";
            this.memberFirstNametxt.Size = new System.Drawing.Size(154, 26);
            this.memberFirstNametxt.TabIndex = 69;
            this.returnFormtoolTip.SetToolTip(this.memberFirstNametxt, "First Name");
            // 
            // extensionStatustxt
            // 
            this.extensionStatustxt.Enabled = false;
            this.extensionStatustxt.Location = new System.Drawing.Point(596, 252);
            this.extensionStatustxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.extensionStatustxt.Name = "extensionStatustxt";
            this.extensionStatustxt.Size = new System.Drawing.Size(154, 26);
            this.extensionStatustxt.TabIndex = 68;
            this.returnFormtoolTip.SetToolTip(this.extensionStatustxt, "Extension Status");
            // 
            // memberIDtxt
            // 
            this.memberIDtxt.Enabled = false;
            this.memberIDtxt.Location = new System.Drawing.Point(175, 128);
            this.memberIDtxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.memberIDtxt.Name = "memberIDtxt";
            this.memberIDtxt.Size = new System.Drawing.Size(182, 26);
            this.memberIDtxt.TabIndex = 67;
            this.returnFormtoolTip.SetToolTip(this.memberIDtxt, "Member ID");
            // 
            // transactionIDtxt
            // 
            this.transactionIDtxt.Location = new System.Drawing.Point(175, 46);
            this.transactionIDtxt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.transactionIDtxt.Name = "transactionIDtxt";
            this.transactionIDtxt.Size = new System.Drawing.Size(182, 26);
            this.transactionIDtxt.TabIndex = 66;
            this.returnFormtoolTip.SetToolTip(this.transactionIDtxt, "Enter transaction ID");
            this.transactionIDtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.transactionIDtxt_KeyDown);
            this.transactionIDtxt.Leave += new System.EventHandler(this.transactionIDtxt_Leave);
            // 
            // remarkslbl
            // 
            this.remarkslbl.AutoSize = true;
            this.remarkslbl.Location = new System.Drawing.Point(30, 395);
            this.remarkslbl.Name = "remarkslbl";
            this.remarkslbl.Size = new System.Drawing.Size(77, 20);
            this.remarkslbl.TabIndex = 65;
            this.remarkslbl.Text = "Remarks:";
            // 
            // extensionStatuslbl
            // 
            this.extensionStatuslbl.AutoSize = true;
            this.extensionStatuslbl.Location = new System.Drawing.Point(435, 252);
            this.extensionStatuslbl.Name = "extensionStatuslbl";
            this.extensionStatuslbl.Size = new System.Drawing.Size(134, 20);
            this.extensionStatuslbl.TabIndex = 64;
            this.extensionStatuslbl.Text = "Extension Status:";
            // 
            // loanStatuslbl
            // 
            this.loanStatuslbl.AutoSize = true;
            this.loanStatuslbl.Location = new System.Drawing.Point(30, 252);
            this.loanStatuslbl.Name = "loanStatuslbl";
            this.loanStatuslbl.Size = new System.Drawing.Size(100, 20);
            this.loanStatuslbl.TabIndex = 63;
            this.loanStatuslbl.Text = "Loan Status:";
            // 
            // dateReturnedlbl
            // 
            this.dateReturnedlbl.AutoSize = true;
            this.dateReturnedlbl.Location = new System.Drawing.Point(784, 322);
            this.dateReturnedlbl.Name = "dateReturnedlbl";
            this.dateReturnedlbl.Size = new System.Drawing.Size(119, 20);
            this.dateReturnedlbl.TabIndex = 62;
            this.dateReturnedlbl.Text = "Date Returned:";
            // 
            // dueDatelbl
            // 
            this.dueDatelbl.AutoSize = true;
            this.dueDatelbl.Location = new System.Drawing.Point(435, 322);
            this.dueDatelbl.Name = "dueDatelbl";
            this.dueDatelbl.Size = new System.Drawing.Size(82, 20);
            this.dueDatelbl.TabIndex = 61;
            this.dueDatelbl.Text = "Due Date:";
            // 
            // dateIssuelbl
            // 
            this.dateIssuelbl.AutoSize = true;
            this.dateIssuelbl.Location = new System.Drawing.Point(30, 322);
            this.dateIssuelbl.Name = "dateIssuelbl";
            this.dateIssuelbl.Size = new System.Drawing.Size(100, 20);
            this.dateIssuelbl.TabIndex = 60;
            this.dateIssuelbl.Text = "Date Issued:";
            // 
            // bookTitlelbl
            // 
            this.bookTitlelbl.AutoSize = true;
            this.bookTitlelbl.Location = new System.Drawing.Point(435, 194);
            this.bookTitlelbl.Name = "bookTitlelbl";
            this.bookTitlelbl.Size = new System.Drawing.Size(83, 20);
            this.bookTitlelbl.TabIndex = 59;
            this.bookTitlelbl.Text = "Book Title:";
            // 
            // bookIDlbl
            // 
            this.bookIDlbl.AutoSize = true;
            this.bookIDlbl.Location = new System.Drawing.Point(30, 194);
            this.bookIDlbl.Name = "bookIDlbl";
            this.bookIDlbl.Size = new System.Drawing.Size(71, 20);
            this.bookIDlbl.TabIndex = 58;
            this.bookIDlbl.Text = "Book ID:";
            // 
            // memberLastNamelbl
            // 
            this.memberLastNamelbl.AutoSize = true;
            this.memberLastNamelbl.Location = new System.Drawing.Point(787, 130);
            this.memberLastNamelbl.Name = "memberLastNamelbl";
            this.memberLastNamelbl.Size = new System.Drawing.Size(90, 20);
            this.memberLastNamelbl.TabIndex = 57;
            this.memberLastNamelbl.Text = "Last Name:";
            // 
            // memberFirstNamelbl
            // 
            this.memberFirstNamelbl.AutoSize = true;
            this.memberFirstNamelbl.Location = new System.Drawing.Point(435, 132);
            this.memberFirstNamelbl.Name = "memberFirstNamelbl";
            this.memberFirstNamelbl.Size = new System.Drawing.Size(90, 20);
            this.memberFirstNamelbl.TabIndex = 56;
            this.memberFirstNamelbl.Text = "First Name:";
            // 
            // memberIDlbl
            // 
            this.memberIDlbl.AutoSize = true;
            this.memberIDlbl.Location = new System.Drawing.Point(30, 132);
            this.memberIDlbl.Name = "memberIDlbl";
            this.memberIDlbl.Size = new System.Drawing.Size(92, 20);
            this.memberIDlbl.TabIndex = 55;
            this.memberIDlbl.Text = "Member ID:";
            // 
            // transactionIDlbl
            // 
            this.transactionIDlbl.AutoSize = true;
            this.transactionIDlbl.Location = new System.Drawing.Point(30, 52);
            this.transactionIDlbl.Name = "transactionIDlbl";
            this.transactionIDlbl.Size = new System.Drawing.Size(117, 20);
            this.transactionIDlbl.TabIndex = 54;
            this.transactionIDlbl.Text = "Transaction ID:";
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 648);
            this.Controls.Add(this.extendLoanbtn);
            this.Controls.Add(this.returnBookbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.remarkstxt);
            this.Controls.Add(this.dateReturnedtxt);
            this.Controls.Add(this.dateDuetxt);
            this.Controls.Add(this.dateIssuetxt);
            this.Controls.Add(this.loanStatustxt);
            this.Controls.Add(this.bookTitletxt);
            this.Controls.Add(this.bookIDtxt);
            this.Controls.Add(this.memberLastNametxt);
            this.Controls.Add(this.memberFirstNametxt);
            this.Controls.Add(this.extensionStatustxt);
            this.Controls.Add(this.memberIDtxt);
            this.Controls.Add(this.transactionIDtxt);
            this.Controls.Add(this.remarkslbl);
            this.Controls.Add(this.extensionStatuslbl);
            this.Controls.Add(this.loanStatuslbl);
            this.Controls.Add(this.dateReturnedlbl);
            this.Controls.Add(this.dueDatelbl);
            this.Controls.Add(this.dateIssuelbl);
            this.Controls.Add(this.bookTitlelbl);
            this.Controls.Add(this.bookIDlbl);
            this.Controls.Add(this.memberLastNamelbl);
            this.Controls.Add(this.memberFirstNamelbl);
            this.Controls.Add(this.memberIDlbl);
            this.Controls.Add(this.transactionIDlbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ReturnForm";
            this.Text = "Book Return/Extension";
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button extendLoanbtn;
        private System.Windows.Forms.Button returnBookbtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox remarkstxt;
        private System.Windows.Forms.TextBox dateReturnedtxt;
        private System.Windows.Forms.TextBox dateDuetxt;
        private System.Windows.Forms.TextBox dateIssuetxt;
        private System.Windows.Forms.TextBox loanStatustxt;
        private System.Windows.Forms.TextBox bookTitletxt;
        private System.Windows.Forms.TextBox bookIDtxt;
        private System.Windows.Forms.TextBox memberLastNametxt;
        private System.Windows.Forms.TextBox memberFirstNametxt;
        private System.Windows.Forms.TextBox extensionStatustxt;
        private System.Windows.Forms.TextBox memberIDtxt;
        private System.Windows.Forms.TextBox transactionIDtxt;
        private System.Windows.Forms.Label remarkslbl;
        private System.Windows.Forms.Label extensionStatuslbl;
        private System.Windows.Forms.Label loanStatuslbl;
        private System.Windows.Forms.Label dateReturnedlbl;
        private System.Windows.Forms.Label dueDatelbl;
        private System.Windows.Forms.Label dateIssuelbl;
        private System.Windows.Forms.Label bookTitlelbl;
        private System.Windows.Forms.Label bookIDlbl;
        private System.Windows.Forms.Label memberLastNamelbl;
        private System.Windows.Forms.Label memberFirstNamelbl;
        private System.Windows.Forms.Label memberIDlbl;
        private System.Windows.Forms.Label transactionIDlbl;
        private System.Windows.Forms.ToolTip returnFormtoolTip;
    }
}

