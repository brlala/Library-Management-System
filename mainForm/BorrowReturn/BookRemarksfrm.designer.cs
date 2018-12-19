namespace mainForm
{
    partial class bookRemarksfrm
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
            this.remarkstxt = new System.Windows.Forms.TextBox();
            this.memberIDlbl = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.bookIDlbl = new System.Windows.Forms.Label();
            this.startDatelbl = new System.Windows.Forms.Label();
            this.endDatelbl = new System.Windows.Forms.Label();
            this.memberIDtxt = new System.Windows.Forms.TextBox();
            this.bookIDtxt = new System.Windows.Forms.TextBox();
            this.startDatetxt = new System.Windows.Forms.TextBox();
            this.endDatetxt = new System.Windows.Forms.TextBox();
            this.transIDtxt = new System.Windows.Forms.TextBox();
            this.transIDlbl = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // remarkstxt
            // 
            this.remarkstxt.Location = new System.Drawing.Point(212, 263);
            this.remarkstxt.Multiline = true;
            this.remarkstxt.Name = "remarkstxt";
            this.remarkstxt.Size = new System.Drawing.Size(497, 191);
            this.remarkstxt.TabIndex = 0;
            this.toolTip1.SetToolTip(this.remarkstxt, "Enter remarks (things to take note, book condition etc.)");
            // 
            // memberIDlbl
            // 
            this.memberIDlbl.AutoSize = true;
            this.memberIDlbl.Location = new System.Drawing.Point(242, 86);
            this.memberIDlbl.Name = "memberIDlbl";
            this.memberIDlbl.Size = new System.Drawing.Size(128, 21);
            this.memberIDlbl.TabIndex = 1;
            this.memberIDlbl.Text = "Member Name";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(510, 481);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(93, 37);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // bookIDlbl
            // 
            this.bookIDlbl.AutoSize = true;
            this.bookIDlbl.Location = new System.Drawing.Point(242, 123);
            this.bookIDlbl.Name = "bookIDlbl";
            this.bookIDlbl.Size = new System.Drawing.Size(99, 21);
            this.bookIDlbl.TabIndex = 3;
            this.bookIDlbl.Text = "Book Name";
            // 
            // startDatelbl
            // 
            this.startDatelbl.AutoSize = true;
            this.startDatelbl.Location = new System.Drawing.Point(243, 157);
            this.startDatelbl.Name = "startDatelbl";
            this.startDatelbl.Size = new System.Drawing.Size(57, 21);
            this.startDatelbl.TabIndex = 4;
            this.startDatelbl.Text = "label3";
            // 
            // endDatelbl
            // 
            this.endDatelbl.AutoSize = true;
            this.endDatelbl.Location = new System.Drawing.Point(242, 194);
            this.endDatelbl.Name = "endDatelbl";
            this.endDatelbl.Size = new System.Drawing.Size(57, 21);
            this.endDatelbl.TabIndex = 5;
            this.endDatelbl.Text = "label4";
            // 
            // memberIDtxt
            // 
            this.memberIDtxt.Location = new System.Drawing.Point(387, 86);
            this.memberIDtxt.Name = "memberIDtxt";
            this.memberIDtxt.ReadOnly = true;
            this.memberIDtxt.Size = new System.Drawing.Size(124, 27);
            this.memberIDtxt.TabIndex = 6;
            this.toolTip1.SetToolTip(this.memberIDtxt, "Member Name");
            // 
            // bookIDtxt
            // 
            this.bookIDtxt.Location = new System.Drawing.Point(387, 123);
            this.bookIDtxt.Name = "bookIDtxt";
            this.bookIDtxt.ReadOnly = true;
            this.bookIDtxt.Size = new System.Drawing.Size(124, 27);
            this.bookIDtxt.TabIndex = 7;
            this.toolTip1.SetToolTip(this.bookIDtxt, "Book Name");
            // 
            // startDatetxt
            // 
            this.startDatetxt.Location = new System.Drawing.Point(387, 162);
            this.startDatetxt.Name = "startDatetxt";
            this.startDatetxt.ReadOnly = true;
            this.startDatetxt.Size = new System.Drawing.Size(124, 27);
            this.startDatetxt.TabIndex = 8;
            this.toolTip1.SetToolTip(this.startDatetxt, "Start Date");
            // 
            // endDatetxt
            // 
            this.endDatetxt.Location = new System.Drawing.Point(387, 199);
            this.endDatetxt.Name = "endDatetxt";
            this.endDatetxt.ReadOnly = true;
            this.endDatetxt.Size = new System.Drawing.Size(124, 27);
            this.endDatetxt.TabIndex = 9;
            this.toolTip1.SetToolTip(this.endDatetxt, "End Date");
            // 
            // transIDtxt
            // 
            this.transIDtxt.Location = new System.Drawing.Point(387, 45);
            this.transIDtxt.Name = "transIDtxt";
            this.transIDtxt.ReadOnly = true;
            this.transIDtxt.Size = new System.Drawing.Size(124, 27);
            this.transIDtxt.TabIndex = 11;
            this.toolTip1.SetToolTip(this.transIDtxt, "ID");
            // 
            // transIDlbl
            // 
            this.transIDlbl.AutoSize = true;
            this.transIDlbl.Location = new System.Drawing.Point(242, 45);
            this.transIDlbl.Name = "transIDlbl";
            this.transIDlbl.Size = new System.Drawing.Size(122, 21);
            this.transIDlbl.TabIndex = 10;
            this.transIDlbl.Text = "Transaction ID";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(618, 481);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(93, 37);
            this.cancelbtn.TabIndex = 12;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // bookRemarksfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 591);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.transIDtxt);
            this.Controls.Add(this.transIDlbl);
            this.Controls.Add(this.endDatetxt);
            this.Controls.Add(this.startDatetxt);
            this.Controls.Add(this.bookIDtxt);
            this.Controls.Add(this.memberIDtxt);
            this.Controls.Add(this.endDatelbl);
            this.Controls.Add(this.startDatelbl);
            this.Controls.Add(this.bookIDlbl);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.memberIDlbl);
            this.Controls.Add(this.remarkstxt);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "bookRemarksfrm";
            this.Text = "Book Remarks";
            this.Load += new System.EventHandler(this.bookRemarksfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox remarkstxt;
        private System.Windows.Forms.Label memberIDlbl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label bookIDlbl;
        private System.Windows.Forms.Label startDatelbl;
        private System.Windows.Forms.Label endDatelbl;
        private System.Windows.Forms.TextBox memberIDtxt;
        private System.Windows.Forms.TextBox bookIDtxt;
        private System.Windows.Forms.TextBox startDatetxt;
        private System.Windows.Forms.TextBox endDatetxt;
        private System.Windows.Forms.TextBox transIDtxt;
        private System.Windows.Forms.Label transIDlbl;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}