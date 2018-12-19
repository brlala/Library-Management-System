namespace mainForm
{
    partial class bookAvailablefrm
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
            this.bookAvailableListdgv = new System.Windows.Forms.DataGridView();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.memberrdo = new System.Windows.Forms.RadioButton();
            this.bookrdo = new System.Windows.Forms.RadioButton();
            this.clearbtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.searchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookAvailableListdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bookAvailableListdgv
            // 
            this.bookAvailableListdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookAvailableListdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookAvailableListdgv.Location = new System.Drawing.Point(113, 225);
            this.bookAvailableListdgv.Margin = new System.Windows.Forms.Padding(5);
            this.bookAvailableListdgv.Name = "bookAvailableListdgv";
            this.bookAvailableListdgv.Size = new System.Drawing.Size(880, 391);
            this.bookAvailableListdgv.TabIndex = 7;
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(323, 102);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(5);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(527, 27);
            this.searchtxt.TabIndex = 5;
            this.toolTip1.SetToolTip(this.searchtxt, "Enter keyword to search");
            this.searchtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchtxt_KeyDown);
            // 
            // memberrdo
            // 
            this.memberrdo.AutoSize = true;
            this.memberrdo.Location = new System.Drawing.Point(203, 102);
            this.memberrdo.Margin = new System.Windows.Forms.Padding(5);
            this.memberrdo.Name = "memberrdo";
            this.memberrdo.Size = new System.Drawing.Size(94, 25);
            this.memberrdo.TabIndex = 9;
            this.memberrdo.Text = "Member";
            this.toolTip1.SetToolTip(this.memberrdo, "Select to search by member");
            this.memberrdo.UseVisualStyleBackColor = true;
            // 
            // bookrdo
            // 
            this.bookrdo.AutoSize = true;
            this.bookrdo.Checked = true;
            this.bookrdo.Location = new System.Drawing.Point(113, 102);
            this.bookrdo.Margin = new System.Windows.Forms.Padding(5);
            this.bookrdo.Name = "bookrdo";
            this.bookrdo.Size = new System.Drawing.Size(65, 25);
            this.bookrdo.TabIndex = 10;
            this.bookrdo.TabStop = true;
            this.bookrdo.Text = "Book";
            this.toolTip1.SetToolTip(this.bookrdo, "Select to search by book");
            this.bookrdo.UseVisualStyleBackColor = true;
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(879, 181);
            this.clearbtn.Margin = new System.Windows.Forms.Padding(5);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(114, 34);
            this.clearbtn.TabIndex = 11;
            this.clearbtn.Text = "Clear results";
            this.toolTip1.SetToolTip(this.clearbtn, "Clear results");
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Image = global::mainForm.Properties.Resources.search_flat;
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtn.Location = new System.Drawing.Point(879, 92);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(114, 46);
            this.searchbtn.TabIndex = 13;
            this.searchbtn.Text = "Search";
            this.searchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // bookAvailablefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.bookrdo);
            this.Controls.Add(this.memberrdo);
            this.Controls.Add(this.bookAvailableListdgv);
            this.Controls.Add(this.searchtxt);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "bookAvailablefrm";
            this.Text = "Book Availabality Query";
            this.Load += new System.EventHandler(this.bookAvailablefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookAvailableListdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookAvailableListdgv;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.RadioButton memberrdo;
        private System.Windows.Forms.RadioButton bookrdo;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button searchbtn;
    }
}