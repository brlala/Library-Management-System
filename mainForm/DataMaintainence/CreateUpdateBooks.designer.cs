namespace mainForm
{
    partial class CreateUpdateBooks
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
            this.bookIDlbl = new System.Windows.Forms.Label();
            this.bookIDtxt = new System.Windows.Forms.MaskedTextBox();
            this.titletxt = new System.Windows.Forms.MaskedTextBox();
            this.titlelbl = new System.Windows.Forms.Label();
            this.createrdo = new System.Windows.Forms.RadioButton();
            this.updaterdo = new System.Windows.Forms.RadioButton();
            this.genrelbl = new System.Windows.Forms.Label();
            this.publisherlbl = new System.Windows.Forms.Label();
            this.datePublishedlbl = new System.Windows.Forms.Label();
            this.languagelbl = new System.Windows.Forms.Label();
            this.typelbl = new System.Windows.Forms.Label();
            this.locationlbl = new System.Windows.Forms.Label();
            this.locationddl = new System.Windows.Forms.ComboBox();
            this.totalStocklbl = new System.Windows.Forms.Label();
            this.qtyLoanedlbl = new System.Windows.Forms.Label();
            this.qtyLoanedtxt = new System.Windows.Forms.MaskedTextBox();
            this.recAgelbl = new System.Windows.Forms.Label();
            this.qtyReservedlbl = new System.Windows.Forms.Label();
            this.qtyReservedtxt = new System.Windows.Forms.MaskedTextBox();
            this.isbnlbl = new System.Windows.Forms.Label();
            this.isbntxt = new System.Windows.Forms.MaskedTextBox();
            this.recAgetxt = new System.Windows.Forms.MaskedTextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.typeddl = new System.Windows.Forms.ComboBox();
            this.totalStocktxt = new System.Windows.Forms.MaskedTextBox();
            this.datePubtxt = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.publisherddl = new System.Windows.Forms.ComboBox();
            this.authorlbl = new System.Windows.Forms.Label();
            this.authorslb = new System.Windows.Forms.ListBox();
            this.genrecmb = new System.Windows.Forms.ComboBox();
            this.languagecmb = new System.Windows.Forms.ComboBox();
            this.pubDatetimepick = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // bookIDlbl
            // 
            this.bookIDlbl.AutoSize = true;
            this.bookIDlbl.Location = new System.Drawing.Point(78, 61);
            this.bookIDlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookIDlbl.Name = "bookIDlbl";
            this.bookIDlbl.Size = new System.Drawing.Size(68, 21);
            this.bookIDlbl.TabIndex = 0;
            this.bookIDlbl.Text = "Book ID";
            this.toolTip1.SetToolTip(this.bookIDlbl, "Book ID");
            // 
            // bookIDtxt
            // 
            this.bookIDtxt.Location = new System.Drawing.Point(254, 52);
            this.bookIDtxt.Margin = new System.Windows.Forms.Padding(4);
            this.bookIDtxt.Mask = "00000";
            this.bookIDtxt.Name = "bookIDtxt";
            this.bookIDtxt.Size = new System.Drawing.Size(148, 27);
            this.bookIDtxt.TabIndex = 1;
            this.bookIDtxt.ValidatingType = typeof(int);
            this.bookIDtxt.TextChanged += new System.EventHandler(this.bookIDtxt_TextChanged);
            // 
            // titletxt
            // 
            this.titletxt.Location = new System.Drawing.Point(254, 123);
            this.titletxt.Margin = new System.Windows.Forms.Padding(4);
            this.titletxt.Name = "titletxt";
            this.titletxt.ReadOnly = true;
            this.titletxt.Size = new System.Drawing.Size(148, 27);
            this.titletxt.TabIndex = 3;
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Location = new System.Drawing.Point(78, 132);
            this.titlelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(41, 21);
            this.titlelbl.TabIndex = 2;
            this.titlelbl.Text = "Title";
            this.toolTip1.SetToolTip(this.titlelbl, "Title");
            // 
            // createrdo
            // 
            this.createrdo.AutoSize = true;
            this.createrdo.Location = new System.Drawing.Point(954, 84);
            this.createrdo.Margin = new System.Windows.Forms.Padding(4);
            this.createrdo.Name = "createrdo";
            this.createrdo.Size = new System.Drawing.Size(84, 25);
            this.createrdo.TabIndex = 6;
            this.createrdo.Text = "Create";
            this.toolTip1.SetToolTip(this.createrdo, "Select to Create New Book Entry");
            this.createrdo.UseVisualStyleBackColor = true;
            this.createrdo.CheckedChanged += new System.EventHandler(this.createrdo_CheckedChanged);
            // 
            // updaterdo
            // 
            this.updaterdo.AutoSize = true;
            this.updaterdo.Checked = true;
            this.updaterdo.Location = new System.Drawing.Point(954, 123);
            this.updaterdo.Margin = new System.Windows.Forms.Padding(4);
            this.updaterdo.Name = "updaterdo";
            this.updaterdo.Size = new System.Drawing.Size(89, 25);
            this.updaterdo.TabIndex = 7;
            this.updaterdo.TabStop = true;
            this.updaterdo.Text = "Update";
            this.toolTip1.SetToolTip(this.updaterdo, "Select to Update");
            this.updaterdo.UseVisualStyleBackColor = true;
            this.updaterdo.CheckedChanged += new System.EventHandler(this.updaterdo_CheckedChanged);
            // 
            // genrelbl
            // 
            this.genrelbl.AutoSize = true;
            this.genrelbl.Location = new System.Drawing.Point(78, 206);
            this.genrelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genrelbl.Name = "genrelbl";
            this.genrelbl.Size = new System.Drawing.Size(59, 21);
            this.genrelbl.TabIndex = 8;
            this.genrelbl.Text = "Genre";
            this.toolTip1.SetToolTip(this.genrelbl, "Genre");
            // 
            // publisherlbl
            // 
            this.publisherlbl.AutoSize = true;
            this.publisherlbl.Location = new System.Drawing.Point(78, 270);
            this.publisherlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.publisherlbl.Name = "publisherlbl";
            this.publisherlbl.Size = new System.Drawing.Size(77, 21);
            this.publisherlbl.TabIndex = 10;
            this.publisherlbl.Text = "Publisher";
            this.toolTip1.SetToolTip(this.publisherlbl, "Publisher Name");
            // 
            // datePublishedlbl
            // 
            this.datePublishedlbl.AutoSize = true;
            this.datePublishedlbl.Location = new System.Drawing.Point(78, 338);
            this.datePublishedlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datePublishedlbl.Name = "datePublishedlbl";
            this.datePublishedlbl.Size = new System.Drawing.Size(127, 21);
            this.datePublishedlbl.TabIndex = 13;
            this.datePublishedlbl.Text = "Date Published";
            this.toolTip1.SetToolTip(this.datePublishedlbl, "Date Published");
            // 
            // languagelbl
            // 
            this.languagelbl.AutoSize = true;
            this.languagelbl.Location = new System.Drawing.Point(78, 398);
            this.languagelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.languagelbl.Name = "languagelbl";
            this.languagelbl.Size = new System.Drawing.Size(91, 21);
            this.languagelbl.TabIndex = 14;
            this.languagelbl.Text = "Language";
            this.toolTip1.SetToolTip(this.languagelbl, "Language");
            // 
            // typelbl
            // 
            this.typelbl.AutoSize = true;
            this.typelbl.Location = new System.Drawing.Point(78, 456);
            this.typelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typelbl.Name = "typelbl";
            this.typelbl.Size = new System.Drawing.Size(47, 21);
            this.typelbl.TabIndex = 17;
            this.typelbl.Text = "Type";
            this.toolTip1.SetToolTip(this.typelbl, "Item Type");
            // 
            // locationlbl
            // 
            this.locationlbl.AutoSize = true;
            this.locationlbl.Location = new System.Drawing.Point(463, 61);
            this.locationlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationlbl.Name = "locationlbl";
            this.locationlbl.Size = new System.Drawing.Size(78, 21);
            this.locationlbl.TabIndex = 18;
            this.locationlbl.Text = "Location";
            this.toolTip1.SetToolTip(this.locationlbl, "Location in Library");
            // 
            // locationddl
            // 
            this.locationddl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationddl.FormattingEnabled = true;
            this.locationddl.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A8",
            "A9",
            "A10",
            "B1",
            "B2",
            "B3",
            "B4",
            "B5",
            "B6",
            "B7",
            "B8",
            "B9",
            "B10",
            "C1",
            "C2",
            "C3",
            "C4",
            "C5",
            "C6",
            "C7",
            "C8",
            "C9",
            "C10",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5",
            "D6",
            "D7",
            "D8",
            "D9",
            "D10",
            "E1",
            "E2",
            "E3",
            "E4",
            "E5",
            "E6",
            "E7",
            "E8",
            "E9",
            "E10",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "G1",
            "G2",
            "G3",
            "G4",
            "G5",
            "G6",
            "G7",
            "G8",
            "G9",
            "G10",
            "H1",
            "H2",
            "H3",
            "H4",
            "H5",
            "H6",
            "H7",
            "H8",
            "H9",
            "H10",
            "I1",
            "I2",
            "I3",
            "I4",
            "I5",
            "I6",
            "I7",
            "I8",
            "I9",
            "I10",
            "J1",
            "J2",
            "J3",
            "J4",
            "J5",
            "J6",
            "J7",
            "J8",
            "J9",
            "J10"});
            this.locationddl.Location = new System.Drawing.Point(706, 53);
            this.locationddl.Margin = new System.Windows.Forms.Padding(4);
            this.locationddl.Name = "locationddl";
            this.locationddl.Size = new System.Drawing.Size(180, 29);
            this.locationddl.TabIndex = 19;
            this.toolTip1.SetToolTip(this.locationddl, "Drop Down to Select");
            // 
            // totalStocklbl
            // 
            this.totalStocklbl.AutoSize = true;
            this.totalStocklbl.Location = new System.Drawing.Point(463, 132);
            this.totalStocklbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalStocklbl.Name = "totalStocklbl";
            this.totalStocklbl.Size = new System.Drawing.Size(96, 21);
            this.totalStocklbl.TabIndex = 20;
            this.totalStocklbl.Text = "Total Stock";
            this.toolTip1.SetToolTip(this.totalStocklbl, "Total Number of Books in Library");
            // 
            // qtyLoanedlbl
            // 
            this.qtyLoanedlbl.AutoSize = true;
            this.qtyLoanedlbl.Location = new System.Drawing.Point(463, 206);
            this.qtyLoanedlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qtyLoanedlbl.Name = "qtyLoanedlbl";
            this.qtyLoanedlbl.Size = new System.Drawing.Size(143, 21);
            this.qtyLoanedlbl.TabIndex = 22;
            this.qtyLoanedlbl.Text = "Quantity Loaned";
            this.toolTip1.SetToolTip(this.qtyLoanedlbl, "Number of Books On Loan");
            // 
            // qtyLoanedtxt
            // 
            this.qtyLoanedtxt.Enabled = false;
            this.qtyLoanedtxt.Location = new System.Drawing.Point(706, 206);
            this.qtyLoanedtxt.Margin = new System.Windows.Forms.Padding(4);
            this.qtyLoanedtxt.Mask = "000";
            this.qtyLoanedtxt.Name = "qtyLoanedtxt";
            this.qtyLoanedtxt.Size = new System.Drawing.Size(148, 27);
            this.qtyLoanedtxt.TabIndex = 23;
            this.qtyLoanedtxt.ValidatingType = typeof(int);
            // 
            // recAgelbl
            // 
            this.recAgelbl.AutoSize = true;
            this.recAgelbl.Location = new System.Drawing.Point(463, 338);
            this.recAgelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recAgelbl.Name = "recAgelbl";
            this.recAgelbl.Size = new System.Drawing.Size(170, 21);
            this.recAgelbl.TabIndex = 25;
            this.recAgelbl.Text = "Recommended Age";
            this.toolTip1.SetToolTip(this.recAgelbl, "Recommended Age for Readers");
            // 
            // qtyReservedlbl
            // 
            this.qtyReservedlbl.AutoSize = true;
            this.qtyReservedlbl.Location = new System.Drawing.Point(463, 270);
            this.qtyReservedlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qtyReservedlbl.Name = "qtyReservedlbl";
            this.qtyReservedlbl.Size = new System.Drawing.Size(156, 21);
            this.qtyReservedlbl.TabIndex = 27;
            this.qtyReservedlbl.Text = "Quantity Reserved";
            this.toolTip1.SetToolTip(this.qtyReservedlbl, "Number of Reserved Books");
            // 
            // qtyReservedtxt
            // 
            this.qtyReservedtxt.Enabled = false;
            this.qtyReservedtxt.Location = new System.Drawing.Point(706, 270);
            this.qtyReservedtxt.Margin = new System.Windows.Forms.Padding(4);
            this.qtyReservedtxt.Mask = "000";
            this.qtyReservedtxt.Name = "qtyReservedtxt";
            this.qtyReservedtxt.Size = new System.Drawing.Size(148, 27);
            this.qtyReservedtxt.TabIndex = 28;
            this.qtyReservedtxt.ValidatingType = typeof(int);
            // 
            // isbnlbl
            // 
            this.isbnlbl.AutoSize = true;
            this.isbnlbl.Location = new System.Drawing.Point(463, 398);
            this.isbnlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isbnlbl.Name = "isbnlbl";
            this.isbnlbl.Size = new System.Drawing.Size(44, 21);
            this.isbnlbl.TabIndex = 29;
            this.isbnlbl.Text = "ISBN";
            this.toolTip1.SetToolTip(this.isbnlbl, "ISBN");
            // 
            // isbntxt
            // 
            this.isbntxt.Location = new System.Drawing.Point(706, 398);
            this.isbntxt.Margin = new System.Windows.Forms.Padding(4);
            this.isbntxt.Name = "isbntxt";
            this.isbntxt.ReadOnly = true;
            this.isbntxt.Size = new System.Drawing.Size(148, 27);
            this.isbntxt.TabIndex = 30;
            // 
            // recAgetxt
            // 
            this.recAgetxt.Location = new System.Drawing.Point(706, 338);
            this.recAgetxt.Margin = new System.Windows.Forms.Padding(4);
            this.recAgetxt.Mask = "00";
            this.recAgetxt.Name = "recAgetxt";
            this.recAgetxt.ReadOnly = true;
            this.recAgetxt.Size = new System.Drawing.Size(148, 27);
            this.recAgetxt.TabIndex = 31;
            this.recAgetxt.ValidatingType = typeof(int);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(926, 479);
            this.savebtn.Margin = new System.Windows.Forms.Padding(4);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(112, 33);
            this.savebtn.TabIndex = 32;
            this.savebtn.Text = "Save";
            this.toolTip1.SetToolTip(this.savebtn, "Save");
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // typeddl
            // 
            this.typeddl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeddl.FormattingEnabled = true;
            this.typeddl.Location = new System.Drawing.Point(254, 456);
            this.typeddl.Margin = new System.Windows.Forms.Padding(4);
            this.typeddl.Name = "typeddl";
            this.typeddl.Size = new System.Drawing.Size(153, 29);
            this.typeddl.TabIndex = 35;
            this.toolTip1.SetToolTip(this.typeddl, "Drop Down to Select");
            // 
            // totalStocktxt
            // 
            this.totalStocktxt.Enabled = false;
            this.totalStocktxt.Location = new System.Drawing.Point(706, 132);
            this.totalStocktxt.Margin = new System.Windows.Forms.Padding(4);
            this.totalStocktxt.Mask = "000";
            this.totalStocktxt.Name = "totalStocktxt";
            this.totalStocktxt.PromptChar = ' ';
            this.totalStocktxt.Size = new System.Drawing.Size(148, 27);
            this.totalStocktxt.TabIndex = 37;
            this.totalStocktxt.ValidatingType = typeof(int);
            // 
            // datePubtxt
            // 
            this.datePubtxt.Location = new System.Drawing.Point(254, 329);
            this.datePubtxt.Margin = new System.Windows.Forms.Padding(4);
            this.datePubtxt.Mask = "00/00/0000";
            this.datePubtxt.Name = "datePubtxt";
            this.datePubtxt.ReadOnly = true;
            this.datePubtxt.Size = new System.Drawing.Size(153, 27);
            this.datePubtxt.TabIndex = 38;
            this.datePubtxt.ValidatingType = typeof(System.DateTime);
            // 
            // publisherddl
            // 
            this.publisherddl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publisherddl.FormattingEnabled = true;
            this.publisherddl.Location = new System.Drawing.Point(254, 270);
            this.publisherddl.Name = "publisherddl";
            this.publisherddl.Size = new System.Drawing.Size(153, 29);
            this.publisherddl.TabIndex = 39;
            // 
            // authorlbl
            // 
            this.authorlbl.AutoSize = true;
            this.authorlbl.Location = new System.Drawing.Point(463, 456);
            this.authorlbl.Name = "authorlbl";
            this.authorlbl.Size = new System.Drawing.Size(71, 21);
            this.authorlbl.TabIndex = 40;
            this.authorlbl.Text = "Authors";
            this.authorlbl.Visible = false;
            // 
            // authorslb
            // 
            this.authorslb.FormattingEnabled = true;
            this.authorslb.ItemHeight = 21;
            this.authorslb.Location = new System.Drawing.Point(706, 456);
            this.authorslb.Name = "authorslb";
            this.authorslb.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.authorslb.Size = new System.Drawing.Size(180, 46);
            this.authorslb.TabIndex = 41;
            this.authorslb.Visible = false;
            this.authorslb.SelectedIndexChanged += new System.EventHandler(this.authorslb_SelectedIndexChanged);
            // 
            // genrecmb
            // 
            this.genrecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genrecmb.FormattingEnabled = true;
            this.genrecmb.Location = new System.Drawing.Point(254, 203);
            this.genrecmb.Name = "genrecmb";
            this.genrecmb.Size = new System.Drawing.Size(153, 29);
            this.genrecmb.TabIndex = 42;
            // 
            // languagecmb
            // 
            this.languagecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languagecmb.FormattingEnabled = true;
            this.languagecmb.Location = new System.Drawing.Point(254, 398);
            this.languagecmb.Name = "languagecmb";
            this.languagecmb.Size = new System.Drawing.Size(153, 29);
            this.languagecmb.TabIndex = 43;
            // 
            // pubDatetimepick
            // 
            this.pubDatetimepick.Enabled = false;
            this.pubDatetimepick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pubDatetimepick.Location = new System.Drawing.Point(254, 329);
            this.pubDatetimepick.Name = "pubDatetimepick";
            this.pubDatetimepick.Size = new System.Drawing.Size(153, 27);
            this.pubDatetimepick.TabIndex = 44;
            // 
            // CreateUpdateBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 552);
            this.Controls.Add(this.languagecmb);
            this.Controls.Add(this.genrecmb);
            this.Controls.Add(this.authorslb);
            this.Controls.Add(this.authorlbl);
            this.Controls.Add(this.publisherddl);
            this.Controls.Add(this.datePubtxt);
            this.Controls.Add(this.totalStocktxt);
            this.Controls.Add(this.typeddl);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.recAgetxt);
            this.Controls.Add(this.isbntxt);
            this.Controls.Add(this.isbnlbl);
            this.Controls.Add(this.qtyReservedtxt);
            this.Controls.Add(this.qtyReservedlbl);
            this.Controls.Add(this.recAgelbl);
            this.Controls.Add(this.qtyLoanedtxt);
            this.Controls.Add(this.qtyLoanedlbl);
            this.Controls.Add(this.totalStocklbl);
            this.Controls.Add(this.locationddl);
            this.Controls.Add(this.locationlbl);
            this.Controls.Add(this.typelbl);
            this.Controls.Add(this.languagelbl);
            this.Controls.Add(this.datePublishedlbl);
            this.Controls.Add(this.publisherlbl);
            this.Controls.Add(this.genrelbl);
            this.Controls.Add(this.updaterdo);
            this.Controls.Add(this.createrdo);
            this.Controls.Add(this.titletxt);
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.bookIDtxt);
            this.Controls.Add(this.bookIDlbl);
            this.Controls.Add(this.pubDatetimepick);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateUpdateBooks";
            this.Text = "Book Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookIDlbl;
        private System.Windows.Forms.MaskedTextBox bookIDtxt;
        private System.Windows.Forms.MaskedTextBox titletxt;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.RadioButton createrdo;
        private System.Windows.Forms.RadioButton updaterdo;
        private System.Windows.Forms.Label genrelbl;
        private System.Windows.Forms.Label publisherlbl;
        private System.Windows.Forms.Label datePublishedlbl;
        private System.Windows.Forms.Label languagelbl;
        private System.Windows.Forms.Label typelbl;
        private System.Windows.Forms.Label locationlbl;
        private System.Windows.Forms.ComboBox locationddl;
        private System.Windows.Forms.Label totalStocklbl;
        private System.Windows.Forms.Label qtyLoanedlbl;

        private System.Windows.Forms.Label recAgelbl;
        private System.Windows.Forms.Label qtyReservedlbl;
        private System.Windows.Forms.Label isbnlbl;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.ComboBox typeddl;
        private System.Windows.Forms.MaskedTextBox totalStocktxt;
        private System.Windows.Forms.MaskedTextBox datePubtxt;
        private System.Windows.Forms.MaskedTextBox qtyLoanedtxt;
        private System.Windows.Forms.MaskedTextBox qtyReservedtxt;
        private System.Windows.Forms.MaskedTextBox recAgetxt;
        private System.Windows.Forms.MaskedTextBox isbntxt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox publisherddl;
        private System.Windows.Forms.Label authorlbl;
        private System.Windows.Forms.ListBox authorslb;
        private System.Windows.Forms.ComboBox genrecmb;
        private System.Windows.Forms.ComboBox languagecmb;
        private System.Windows.Forms.DateTimePicker pubDatetimepick;
    }
}

