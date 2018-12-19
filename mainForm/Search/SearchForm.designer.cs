namespace mainForm
{
    partial class SearchForm
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
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.detailgb = new System.Windows.Forms.GroupBox();
            this.finishAgemtxt = new System.Windows.Forms.MaskedTextBox();
            this.startAgemtxt = new System.Windows.Forms.MaskedTextBox();
            this.midtxt = new System.Windows.Forms.Label();
            this.recommendAgetxt = new System.Windows.Forms.Label();
            this.typecomb = new System.Windows.Forms.ComboBox();
            this.typelbl = new System.Windows.Forms.Label();
            this.languagecomb = new System.Windows.Forms.ComboBox();
            this.languagelbl = new System.Windows.Forms.Label();
            this.finishTimedtp = new System.Windows.Forms.DateTimePicker();
            this.tolbl = new System.Windows.Forms.Label();
            this.startTimedtp = new System.Windows.Forms.DateTimePicker();
            this.publishDatelbl = new System.Windows.Forms.Label();
            this.genrelbl = new System.Windows.Forms.Label();
            this.genrecomb = new System.Windows.Forms.ComboBox();
            this.filtergb = new System.Windows.Forms.GroupBox();
            this.publisherrdo = new System.Windows.Forms.RadioButton();
            this.authorrdo = new System.Windows.Forms.RadioButton();
            this.titlerdo = new System.Windows.Forms.RadioButton();
            this.bookIdrdo = new System.Windows.Forms.RadioButton();
            this.bookInfodgv = new System.Windows.Forms.DataGridView();
            this.searchmtxt = new System.Windows.Forms.MaskedTextBox();
            this.searchFormtolt = new System.Windows.Forms.ToolTip(this.components);
            this.searchbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.detailgb.SuspendLayout();
            this.filtergb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookInfodgv)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(480, 67);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(5);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(357, 27);
            this.searchtxt.TabIndex = 0;
            this.searchFormtolt.SetToolTip(this.searchtxt, "Enter the search content");
            this.searchtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchtxt_KeyDown);
            // 
            // detailgb
            // 
            this.detailgb.Controls.Add(this.finishAgemtxt);
            this.detailgb.Controls.Add(this.startAgemtxt);
            this.detailgb.Controls.Add(this.midtxt);
            this.detailgb.Controls.Add(this.recommendAgetxt);
            this.detailgb.Controls.Add(this.typecomb);
            this.detailgb.Controls.Add(this.typelbl);
            this.detailgb.Controls.Add(this.languagecomb);
            this.detailgb.Controls.Add(this.languagelbl);
            this.detailgb.Controls.Add(this.finishTimedtp);
            this.detailgb.Controls.Add(this.tolbl);
            this.detailgb.Controls.Add(this.startTimedtp);
            this.detailgb.Controls.Add(this.publishDatelbl);
            this.detailgb.Controls.Add(this.genrelbl);
            this.detailgb.Controls.Add(this.genrecomb);
            this.detailgb.Location = new System.Drawing.Point(68, 24);
            this.detailgb.Margin = new System.Windows.Forms.Padding(5);
            this.detailgb.Name = "detailgb";
            this.detailgb.Padding = new System.Windows.Forms.Padding(5);
            this.detailgb.Size = new System.Drawing.Size(380, 291);
            this.detailgb.TabIndex = 2;
            this.detailgb.TabStop = false;
            this.detailgb.Text = "Details";
            // 
            // finishAgemtxt
            // 
            this.finishAgemtxt.Location = new System.Drawing.Point(298, 250);
            this.finishAgemtxt.Margin = new System.Windows.Forms.Padding(5);
            this.finishAgemtxt.Mask = "00";
            this.finishAgemtxt.Name = "finishAgemtxt";
            this.finishAgemtxt.Size = new System.Drawing.Size(32, 27);
            this.finishAgemtxt.TabIndex = 15;
            this.finishAgemtxt.Text = "99";
            // 
            // startAgemtxt
            // 
            this.startAgemtxt.Location = new System.Drawing.Point(224, 248);
            this.startAgemtxt.Margin = new System.Windows.Forms.Padding(5);
            this.startAgemtxt.Mask = "00";
            this.startAgemtxt.Name = "startAgemtxt";
            this.startAgemtxt.Size = new System.Drawing.Size(34, 27);
            this.startAgemtxt.TabIndex = 14;
            this.startAgemtxt.Text = "00";
            // 
            // midtxt
            // 
            this.midtxt.AutoSize = true;
            this.midtxt.Location = new System.Drawing.Point(268, 251);
            this.midtxt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.midtxt.Name = "midtxt";
            this.midtxt.Size = new System.Drawing.Size(20, 21);
            this.midtxt.TabIndex = 13;
            this.midtxt.Text = "~";
            // 
            // recommendAgetxt
            // 
            this.recommendAgetxt.AutoSize = true;
            this.recommendAgetxt.Location = new System.Drawing.Point(50, 251);
            this.recommendAgetxt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.recommendAgetxt.Name = "recommendAgetxt";
            this.recommendAgetxt.Size = new System.Drawing.Size(170, 21);
            this.recommendAgetxt.TabIndex = 10;
            this.recommendAgetxt.Text = "Recommended Age";
            // 
            // typecomb
            // 
            this.typecomb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typecomb.FormattingEnabled = true;
            this.typecomb.Location = new System.Drawing.Point(173, 111);
            this.typecomb.Margin = new System.Windows.Forms.Padding(5);
            this.typecomb.Name = "typecomb";
            this.typecomb.Size = new System.Drawing.Size(179, 29);
            this.typecomb.TabIndex = 9;
            // 
            // typelbl
            // 
            this.typelbl.AutoSize = true;
            this.typelbl.Location = new System.Drawing.Point(52, 114);
            this.typelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.typelbl.Name = "typelbl";
            this.typelbl.Size = new System.Drawing.Size(47, 21);
            this.typelbl.TabIndex = 8;
            this.typelbl.Text = "Type";
            // 
            // languagecomb
            // 
            this.languagecomb.AutoCompleteCustomSource.AddRange(new string[] {
            "English",
            "Chinese"});
            this.languagecomb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languagecomb.FormattingEnabled = true;
            this.languagecomb.Location = new System.Drawing.Point(173, 72);
            this.languagecomb.Margin = new System.Windows.Forms.Padding(5);
            this.languagecomb.Name = "languagecomb";
            this.languagecomb.Size = new System.Drawing.Size(179, 29);
            this.languagecomb.TabIndex = 7;
            // 
            // languagelbl
            // 
            this.languagelbl.AutoSize = true;
            this.languagelbl.Location = new System.Drawing.Point(29, 77);
            this.languagelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.languagelbl.Name = "languagelbl";
            this.languagelbl.Size = new System.Drawing.Size(91, 21);
            this.languagelbl.TabIndex = 6;
            this.languagelbl.Text = "Language";
            // 
            // finishTimedtp
            // 
            this.finishTimedtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.finishTimedtp.Location = new System.Drawing.Point(173, 192);
            this.finishTimedtp.Margin = new System.Windows.Forms.Padding(5);
            this.finishTimedtp.Name = "finishTimedtp";
            this.finishTimedtp.Size = new System.Drawing.Size(179, 27);
            this.finishTimedtp.TabIndex = 5;
            this.finishTimedtp.ValueChanged += new System.EventHandler(this.finishTimedtp_ValueChanged);
            // 
            // tolbl
            // 
            this.tolbl.AutoSize = true;
            this.tolbl.Location = new System.Drawing.Point(114, 192);
            this.tolbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tolbl.Name = "tolbl";
            this.tolbl.Size = new System.Drawing.Size(27, 21);
            this.tolbl.TabIndex = 4;
            this.tolbl.Text = "to";
            // 
            // startTimedtp
            // 
            this.startTimedtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startTimedtp.Location = new System.Drawing.Point(173, 151);
            this.startTimedtp.Margin = new System.Windows.Forms.Padding(5);
            this.startTimedtp.Name = "startTimedtp";
            this.startTimedtp.Size = new System.Drawing.Size(179, 27);
            this.startTimedtp.TabIndex = 3;
            this.startTimedtp.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.startTimedtp.ValueChanged += new System.EventHandler(this.startTimedtp_ValueChanged);
            // 
            // publishDatelbl
            // 
            this.publishDatelbl.AutoSize = true;
            this.publishDatelbl.Location = new System.Drawing.Point(29, 161);
            this.publishDatelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.publishDatelbl.Name = "publishDatelbl";
            this.publishDatelbl.Size = new System.Drawing.Size(106, 21);
            this.publishDatelbl.TabIndex = 2;
            this.publishDatelbl.Text = "Publish Date";
            // 
            // genrelbl
            // 
            this.genrelbl.AutoSize = true;
            this.genrelbl.Location = new System.Drawing.Point(50, 38);
            this.genrelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.genrelbl.Name = "genrelbl";
            this.genrelbl.Size = new System.Drawing.Size(59, 21);
            this.genrelbl.TabIndex = 1;
            this.genrelbl.Text = "Genre";
            // 
            // genrecomb
            // 
            this.genrecomb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genrecomb.FormattingEnabled = true;
            this.genrecomb.Location = new System.Drawing.Point(172, 33);
            this.genrecomb.Margin = new System.Windows.Forms.Padding(5);
            this.genrecomb.Name = "genrecomb";
            this.genrecomb.Size = new System.Drawing.Size(179, 29);
            this.genrecomb.TabIndex = 0;
            // 
            // filtergb
            // 
            this.filtergb.Controls.Add(this.publisherrdo);
            this.filtergb.Controls.Add(this.authorrdo);
            this.filtergb.Controls.Add(this.titlerdo);
            this.filtergb.Controls.Add(this.bookIdrdo);
            this.filtergb.Location = new System.Drawing.Point(480, 135);
            this.filtergb.Margin = new System.Windows.Forms.Padding(5);
            this.filtergb.Name = "filtergb";
            this.filtergb.Padding = new System.Windows.Forms.Padding(5);
            this.filtergb.Size = new System.Drawing.Size(232, 108);
            this.filtergb.TabIndex = 3;
            this.filtergb.TabStop = false;
            this.filtergb.Text = "Search by filter";
            // 
            // publisherrdo
            // 
            this.publisherrdo.AutoSize = true;
            this.publisherrdo.Location = new System.Drawing.Point(9, 75);
            this.publisherrdo.Margin = new System.Windows.Forms.Padding(5);
            this.publisherrdo.Name = "publisherrdo";
            this.publisherrdo.Size = new System.Drawing.Size(147, 25);
            this.publisherrdo.TabIndex = 4;
            this.publisherrdo.Text = "Publisher Name";
            this.publisherrdo.UseVisualStyleBackColor = true;
            // 
            // authorrdo
            // 
            this.authorrdo.AutoSize = true;
            this.authorrdo.Location = new System.Drawing.Point(10, 52);
            this.authorrdo.Margin = new System.Windows.Forms.Padding(5);
            this.authorrdo.Name = "authorrdo";
            this.authorrdo.Size = new System.Drawing.Size(135, 25);
            this.authorrdo.TabIndex = 3;
            this.authorrdo.Text = "Author Name";
            this.authorrdo.UseVisualStyleBackColor = true;
            // 
            // titlerdo
            // 
            this.titlerdo.AutoSize = true;
            this.titlerdo.Checked = true;
            this.titlerdo.Location = new System.Drawing.Point(9, 30);
            this.titlerdo.Margin = new System.Windows.Forms.Padding(5);
            this.titlerdo.Name = "titlerdo";
            this.titlerdo.Size = new System.Drawing.Size(100, 25);
            this.titlerdo.TabIndex = 2;
            this.titlerdo.TabStop = true;
            this.titlerdo.Text = "Book Title";
            this.titlerdo.UseVisualStyleBackColor = true;
            // 
            // bookIdrdo
            // 
            this.bookIdrdo.AutoSize = true;
            this.bookIdrdo.Location = new System.Drawing.Point(119, 30);
            this.bookIdrdo.Margin = new System.Windows.Forms.Padding(5);
            this.bookIdrdo.Name = "bookIdrdo";
            this.bookIdrdo.Size = new System.Drawing.Size(86, 25);
            this.bookIdrdo.TabIndex = 1;
            this.bookIdrdo.Text = "Book ID";
            this.bookIdrdo.UseVisualStyleBackColor = true;
            this.bookIdrdo.CheckedChanged += new System.EventHandler(this.bookIdrdo_CheckedChanged);
            // 
            // bookInfodgv
            // 
            this.bookInfodgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.bookInfodgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookInfodgv.Location = new System.Drawing.Point(68, 325);
            this.bookInfodgv.Margin = new System.Windows.Forms.Padding(5);
            this.bookInfodgv.Name = "bookInfodgv";
            this.bookInfodgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookInfodgv.Size = new System.Drawing.Size(942, 302);
            this.bookInfodgv.TabIndex = 4;
            // 
            // searchmtxt
            // 
            this.searchmtxt.Location = new System.Drawing.Point(505, 67);
            this.searchmtxt.Margin = new System.Windows.Forms.Padding(5);
            this.searchmtxt.Mask = "000";
            this.searchmtxt.Name = "searchmtxt";
            this.searchmtxt.Size = new System.Drawing.Size(39, 27);
            this.searchmtxt.TabIndex = 5;
            this.searchFormtolt.SetToolTip(this.searchmtxt, "Enter the book ID");
            this.searchmtxt.Visible = false;
            // 
            // searchbtn
            // 
            this.searchbtn.Image = global::mainForm.Properties.Resources.search_flat;
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtn.Location = new System.Drawing.Point(896, 62);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(114, 46);
            this.searchbtn.TabIndex = 6;
            this.searchbtn.Text = "Search";
            this.searchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(896, 275);
            this.clearbtn.Margin = new System.Windows.Forms.Padding(5);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(114, 34);
            this.clearbtn.TabIndex = 12;
            this.clearbtn.Text = "Clear results";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchmtxt);
            this.Controls.Add(this.bookInfodgv);
            this.Controls.Add(this.filtergb);
            this.Controls.Add(this.detailgb);
            this.Controls.Add(this.searchtxt);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SearchForm";
            this.Text = "Book Search";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.detailgb.ResumeLayout(false);
            this.detailgb.PerformLayout();
            this.filtergb.ResumeLayout(false);
            this.filtergb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookInfodgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.GroupBox detailgb;
        private System.Windows.Forms.Label publishDatelbl;
        private System.Windows.Forms.Label genrelbl;
        private System.Windows.Forms.ComboBox genrecomb;
        private System.Windows.Forms.Label midtxt;
        private System.Windows.Forms.Label recommendAgetxt;
        private System.Windows.Forms.ComboBox typecomb;
        private System.Windows.Forms.Label typelbl;
        private System.Windows.Forms.ComboBox languagecomb;
        private System.Windows.Forms.Label languagelbl;
        private System.Windows.Forms.DateTimePicker finishTimedtp;
        private System.Windows.Forms.Label tolbl;
        private System.Windows.Forms.DateTimePicker startTimedtp;
        private System.Windows.Forms.GroupBox filtergb;
        private System.Windows.Forms.RadioButton publisherrdo;
        private System.Windows.Forms.RadioButton authorrdo;
        private System.Windows.Forms.RadioButton titlerdo;
        private System.Windows.Forms.RadioButton bookIdrdo;
        private System.Windows.Forms.DataGridView bookInfodgv;
        private System.Windows.Forms.MaskedTextBox startAgemtxt;
        private System.Windows.Forms.MaskedTextBox finishAgemtxt;
        private System.Windows.Forms.MaskedTextBox searchmtxt;
        private System.Windows.Forms.ToolTip searchFormtolt;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button clearbtn;
    }
}