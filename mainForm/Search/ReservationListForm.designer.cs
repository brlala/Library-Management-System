namespace mainForm
{
    partial class ReservationListForm
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
            this.fieldcmb = new System.Windows.Forms.ComboBox();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.reservationListdgv = new System.Windows.Forms.DataGridView();
            this.reservationListFormtolt = new System.Windows.Forms.ToolTip(this.components);
            this.searchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reservationListdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldcmb
            // 
            this.fieldcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldcmb.FormattingEnabled = true;
            this.fieldcmb.Items.AddRange(new object[] {
            "Books",
            "Members"});
            this.fieldcmb.Location = new System.Drawing.Point(102, 104);
            this.fieldcmb.Margin = new System.Windows.Forms.Padding(5);
            this.fieldcmb.Name = "fieldcmb";
            this.fieldcmb.Size = new System.Drawing.Size(111, 29);
            this.fieldcmb.TabIndex = 0;
            this.reservationListFormtolt.SetToolTip(this.fieldcmb, "Select search criteria");
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(299, 104);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(5);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(526, 27);
            this.searchtxt.TabIndex = 1;
            this.reservationListFormtolt.SetToolTip(this.searchtxt, "Enter search text");
            this.searchtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchtxt_KeyDown);
            // 
            // reservationListdgv
            // 
            this.reservationListdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservationListdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationListdgv.Location = new System.Drawing.Point(102, 207);
            this.reservationListdgv.Margin = new System.Windows.Forms.Padding(5);
            this.reservationListdgv.Name = "reservationListdgv";
            this.reservationListdgv.Size = new System.Drawing.Size(858, 407);
            this.reservationListdgv.TabIndex = 3;
            // 
            // searchbtn
            // 
            this.searchbtn.Image = global::mainForm.Properties.Resources.search_flat;
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtn.Location = new System.Drawing.Point(846, 94);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(114, 46);
            this.searchbtn.TabIndex = 4;
            this.searchbtn.Text = "Search";
            this.searchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // ReservationListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.reservationListdgv);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.fieldcmb);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ReservationListForm";
            this.Text = "Reservation List";
            this.Load += new System.EventHandler(this.ReservationListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationListdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fieldcmb;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.DataGridView reservationListdgv;
        private System.Windows.Forms.ToolTip reservationListFormtolt;
        private System.Windows.Forms.Button searchbtn;
    }
}