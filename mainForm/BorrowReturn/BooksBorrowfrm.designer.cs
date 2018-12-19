namespace mainForm
{
    partial class BooksBorrowfrm
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
            this.listBooksdtg = new System.Windows.Forms.DataGridView();
            this.confirmBookdtg = new System.Windows.Forms.DataGridView();
            this.addBooksbtn = new System.Windows.Forms.Button();
            this.removeBooksbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.searchlbl = new System.Windows.Forms.Label();
            this.listBookslbl = new System.Windows.Forms.Label();
            this.confirmBooklvl = new System.Windows.Forms.Label();
            this.memberIDlbl = new System.Windows.Forms.Label();
            this.memberIDtxt = new System.Windows.Forms.TextBox();
            this.memberNametxt = new System.Windows.Forms.TextBox();
            this.browsebtn = new System.Windows.Forms.Button();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.clearAllbtn = new System.Windows.Forms.Button();
            this.booksLoanlbl = new System.Windows.Forms.Label();
            this.booksReservelbl = new System.Windows.Forms.Label();
            this.booksQuotalbl = new System.Windows.Forms.Label();
            this.statusGroup = new System.Windows.Forms.GroupBox();
            this.booksQuotatxt = new System.Windows.Forms.TextBox();
            this.booksReservetxt = new System.Windows.Forms.TextBox();
            this.booksLoantxt = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.borrowGroup = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listBooksdtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmBookdtg)).BeginInit();
            this.statusGroup.SuspendLayout();
            this.borrowGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBooksdtg
            // 
            this.listBooksdtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listBooksdtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBooksdtg.Location = new System.Drawing.Point(38, 53);
            this.listBooksdtg.Margin = new System.Windows.Forms.Padding(5);
            this.listBooksdtg.MultiSelect = false;
            this.listBooksdtg.Name = "listBooksdtg";
            this.listBooksdtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listBooksdtg.Size = new System.Drawing.Size(790, 142);
            this.listBooksdtg.TabIndex = 0;
            this.listBooksdtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listBooksdtg_CellClick);
            // 
            // confirmBookdtg
            // 
            this.confirmBookdtg.AllowUserToAddRows = false;
            this.confirmBookdtg.AllowUserToDeleteRows = false;
            this.confirmBookdtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.confirmBookdtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.confirmBookdtg.Location = new System.Drawing.Point(99, 425);
            this.confirmBookdtg.Margin = new System.Windows.Forms.Padding(5);
            this.confirmBookdtg.MultiSelect = false;
            this.confirmBookdtg.Name = "confirmBookdtg";
            this.confirmBookdtg.ReadOnly = true;
            this.confirmBookdtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.confirmBookdtg.Size = new System.Drawing.Size(791, 168);
            this.confirmBookdtg.TabIndex = 1;
            this.confirmBookdtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.confirmBookdtg_CellClick);
            // 
            // addBooksbtn
            // 
            this.addBooksbtn.Location = new System.Drawing.Point(376, 379);
            this.addBooksbtn.Margin = new System.Windows.Forms.Padding(5);
            this.addBooksbtn.Name = "addBooksbtn";
            this.addBooksbtn.Size = new System.Drawing.Size(72, 34);
            this.addBooksbtn.TabIndex = 2;
            this.addBooksbtn.Text = "\\/";
            this.toolTip1.SetToolTip(this.addBooksbtn, "Add to book/reservation list");
            this.addBooksbtn.UseVisualStyleBackColor = true;
            this.addBooksbtn.Click += new System.EventHandler(this.addBooksbtn_Click);
            // 
            // removeBooksbtn
            // 
            this.removeBooksbtn.Location = new System.Drawing.Point(458, 378);
            this.removeBooksbtn.Margin = new System.Windows.Forms.Padding(5);
            this.removeBooksbtn.Name = "removeBooksbtn";
            this.removeBooksbtn.Size = new System.Drawing.Size(68, 37);
            this.removeBooksbtn.TabIndex = 3;
            this.removeBooksbtn.Text = "/\\";
            this.toolTip1.SetToolTip(this.removeBooksbtn, "Remove from book/reservation list");
            this.removeBooksbtn.UseVisualStyleBackColor = true;
            this.removeBooksbtn.Click += new System.EventHandler(this.removeBooksbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(220, 108);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(5);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(277, 27);
            this.searchtxt.TabIndex = 4;
            this.toolTip1.SetToolTip(this.searchtxt, "Enter name of book");
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // searchlbl
            // 
            this.searchlbl.AutoSize = true;
            this.searchlbl.Location = new System.Drawing.Point(95, 113);
            this.searchlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.searchlbl.Name = "searchlbl";
            this.searchlbl.Size = new System.Drawing.Size(105, 21);
            this.searchlbl.TabIndex = 5;
            this.searchlbl.Text = "Search Book";
            // 
            // listBookslbl
            // 
            this.listBookslbl.AutoSize = true;
            this.listBookslbl.Location = new System.Drawing.Point(35, 21);
            this.listBookslbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.listBookslbl.Name = "listBookslbl";
            this.listBookslbl.Size = new System.Drawing.Size(240, 21);
            this.listBookslbl.TabIndex = 6;
            this.listBookslbl.Text = "List of books available for loan";
            // 
            // confirmBooklvl
            // 
            this.confirmBooklvl.AutoSize = true;
            this.confirmBooklvl.Location = new System.Drawing.Point(81, 378);
            this.confirmBooklvl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.confirmBooklvl.Name = "confirmBooklvl";
            this.confirmBooklvl.Size = new System.Drawing.Size(200, 21);
            this.confirmBooklvl.TabIndex = 7;
            this.confirmBooklvl.Text = "Books to be loan/reserve";
            // 
            // memberIDlbl
            // 
            this.memberIDlbl.AutoSize = true;
            this.memberIDlbl.Location = new System.Drawing.Point(95, 17);
            this.memberIDlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.memberIDlbl.Name = "memberIDlbl";
            this.memberIDlbl.Size = new System.Drawing.Size(97, 21);
            this.memberIDlbl.TabIndex = 8;
            this.memberIDlbl.Text = "Member ID";
            // 
            // memberIDtxt
            // 
            this.memberIDtxt.Location = new System.Drawing.Point(220, 17);
            this.memberIDtxt.Margin = new System.Windows.Forms.Padding(5);
            this.memberIDtxt.Name = "memberIDtxt";
            this.memberIDtxt.Size = new System.Drawing.Size(202, 27);
            this.memberIDtxt.TabIndex = 9;
            this.toolTip1.SetToolTip(this.memberIDtxt, "Member ID");
            this.memberIDtxt.TextChanged += new System.EventHandler(this.memberIDtxt_TextChanged);
            this.memberIDtxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.memberIDtxt_KeyUp);
            this.memberIDtxt.Leave += new System.EventHandler(this.memberIDtxt_Leave);
            // 
            // memberNametxt
            // 
            this.memberNametxt.Location = new System.Drawing.Point(220, 61);
            this.memberNametxt.Margin = new System.Windows.Forms.Padding(5);
            this.memberNametxt.Name = "memberNametxt";
            this.memberNametxt.ReadOnly = true;
            this.memberNametxt.Size = new System.Drawing.Size(277, 27);
            this.memberNametxt.TabIndex = 10;
            this.memberNametxt.Text = "Enter MemberID";
            this.toolTip1.SetToolTip(this.memberNametxt, "Member Name");
            // 
            // browsebtn
            // 
            this.browsebtn.Location = new System.Drawing.Point(435, 14);
            this.browsebtn.Margin = new System.Windows.Forms.Padding(5);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(65, 37);
            this.browsebtn.TabIndex = 11;
            this.browsebtn.Text = "...";
            this.toolTip1.SetToolTip(this.browsebtn, "Browse member");
            this.browsebtn.UseVisualStyleBackColor = true;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // confirmbtn
            // 
            this.confirmbtn.Location = new System.Drawing.Point(712, 603);
            this.confirmbtn.Margin = new System.Windows.Forms.Padding(5);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(105, 37);
            this.confirmbtn.TabIndex = 12;
            this.confirmbtn.Text = "Confirm";
            this.toolTip1.SetToolTip(this.confirmbtn, "Confirm");
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // clearAllbtn
            // 
            this.clearAllbtn.Location = new System.Drawing.Point(728, 376);
            this.clearAllbtn.Margin = new System.Windows.Forms.Padding(5);
            this.clearAllbtn.Name = "clearAllbtn";
            this.clearAllbtn.Size = new System.Drawing.Size(125, 37);
            this.clearAllbtn.TabIndex = 13;
            this.clearAllbtn.Text = "Clear All";
            this.toolTip1.SetToolTip(this.clearAllbtn, "Clear book/reservation list");
            this.clearAllbtn.UseVisualStyleBackColor = true;
            this.clearAllbtn.Click += new System.EventHandler(this.clearAllbtn_Click);
            // 
            // booksLoanlbl
            // 
            this.booksLoanlbl.AutoSize = true;
            this.booksLoanlbl.Location = new System.Drawing.Point(10, 26);
            this.booksLoanlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.booksLoanlbl.Name = "booksLoanlbl";
            this.booksLoanlbl.Size = new System.Drawing.Size(116, 21);
            this.booksLoanlbl.TabIndex = 14;
            this.booksLoanlbl.Text = "Books Loaned";
            // 
            // booksReservelbl
            // 
            this.booksReservelbl.AutoSize = true;
            this.booksReservelbl.Location = new System.Drawing.Point(10, 58);
            this.booksReservelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.booksReservelbl.Name = "booksReservelbl";
            this.booksReservelbl.Size = new System.Drawing.Size(118, 21);
            this.booksReservelbl.TabIndex = 15;
            this.booksReservelbl.Text = "Books Reserve";
            // 
            // booksQuotalbl
            // 
            this.booksQuotalbl.AutoSize = true;
            this.booksQuotalbl.Location = new System.Drawing.Point(10, 94);
            this.booksQuotalbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.booksQuotalbl.Name = "booksQuotalbl";
            this.booksQuotalbl.Size = new System.Drawing.Size(141, 21);
            this.booksQuotalbl.TabIndex = 16;
            this.booksQuotalbl.Text = "Available Quota";
            // 
            // statusGroup
            // 
            this.statusGroup.Controls.Add(this.booksQuotatxt);
            this.statusGroup.Controls.Add(this.booksReservetxt);
            this.statusGroup.Controls.Add(this.booksLoantxt);
            this.statusGroup.Controls.Add(this.booksLoanlbl);
            this.statusGroup.Controls.Add(this.booksQuotalbl);
            this.statusGroup.Controls.Add(this.booksReservelbl);
            this.statusGroup.Location = new System.Drawing.Point(640, 14);
            this.statusGroup.Margin = new System.Windows.Forms.Padding(5);
            this.statusGroup.Name = "statusGroup";
            this.statusGroup.Padding = new System.Windows.Forms.Padding(5);
            this.statusGroup.Size = new System.Drawing.Size(250, 139);
            this.statusGroup.TabIndex = 17;
            this.statusGroup.TabStop = false;
            this.statusGroup.Text = "Status";
            // 
            // booksQuotatxt
            // 
            this.booksQuotatxt.Location = new System.Drawing.Point(147, 94);
            this.booksQuotatxt.Margin = new System.Windows.Forms.Padding(5);
            this.booksQuotatxt.Name = "booksQuotatxt";
            this.booksQuotatxt.ReadOnly = true;
            this.booksQuotatxt.Size = new System.Drawing.Size(66, 27);
            this.booksQuotatxt.TabIndex = 19;
            this.toolTip1.SetToolTip(this.booksQuotatxt, "Remaining book loan quota ");
            // 
            // booksReservetxt
            // 
            this.booksReservetxt.Location = new System.Drawing.Point(147, 57);
            this.booksReservetxt.Margin = new System.Windows.Forms.Padding(5);
            this.booksReservetxt.Name = "booksReservetxt";
            this.booksReservetxt.ReadOnly = true;
            this.booksReservetxt.Size = new System.Drawing.Size(66, 27);
            this.booksReservetxt.TabIndex = 18;
            this.toolTip1.SetToolTip(this.booksReservetxt, "Quantity of books reserved");
            // 
            // booksLoantxt
            // 
            this.booksLoantxt.Location = new System.Drawing.Point(147, 21);
            this.booksLoantxt.Margin = new System.Windows.Forms.Padding(5);
            this.booksLoantxt.Name = "booksLoantxt";
            this.booksLoantxt.ReadOnly = true;
            this.booksLoantxt.Size = new System.Drawing.Size(66, 27);
            this.booksLoantxt.TabIndex = 17;
            this.toolTip1.SetToolTip(this.booksLoantxt, "Quantity of books loan");
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(827, 603);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(5);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(105, 37);
            this.cancelbtn.TabIndex = 18;
            this.cancelbtn.Text = "Cancel";
            this.toolTip1.SetToolTip(this.cancelbtn, "Cancel");
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // borrowGroup
            // 
            this.borrowGroup.Controls.Add(this.listBookslbl);
            this.borrowGroup.Controls.Add(this.listBooksdtg);
            this.borrowGroup.Location = new System.Drawing.Point(62, 163);
            this.borrowGroup.Margin = new System.Windows.Forms.Padding(5);
            this.borrowGroup.Name = "borrowGroup";
            this.borrowGroup.Padding = new System.Windows.Forms.Padding(5);
            this.borrowGroup.Size = new System.Drawing.Size(870, 211);
            this.borrowGroup.TabIndex = 21;
            this.borrowGroup.TabStop = false;
            // 
            // BooksBorrowfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(994, 645);
            this.Controls.Add(this.borrowGroup);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.statusGroup);
            this.Controls.Add(this.clearAllbtn);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.browsebtn);
            this.Controls.Add(this.memberNametxt);
            this.Controls.Add(this.memberIDtxt);
            this.Controls.Add(this.memberIDlbl);
            this.Controls.Add(this.confirmBooklvl);
            this.Controls.Add(this.searchlbl);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.removeBooksbtn);
            this.Controls.Add(this.addBooksbtn);
            this.Controls.Add(this.confirmBookdtg);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BooksBorrowfrm";
            this.Opacity = 0D;
            this.Text = "Books Loan/Reserve";
            this.Load += new System.EventHandler(this.booksBorrowfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBooksdtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmBookdtg)).EndInit();
            this.statusGroup.ResumeLayout(false);
            this.statusGroup.PerformLayout();
            this.borrowGroup.ResumeLayout(false);
            this.borrowGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listBooksdtg;
        private System.Windows.Forms.DataGridView confirmBookdtg;
        private System.Windows.Forms.Button addBooksbtn;
        private System.Windows.Forms.Button removeBooksbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Label searchlbl;
        private System.Windows.Forms.Label listBookslbl;
        private System.Windows.Forms.Label confirmBooklvl;
        private System.Windows.Forms.Label memberIDlbl;
        private System.Windows.Forms.TextBox memberIDtxt;
        private System.Windows.Forms.TextBox memberNametxt;
        private System.Windows.Forms.Button browsebtn;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.Button clearAllbtn;
        private System.Windows.Forms.Label booksLoanlbl;
        private System.Windows.Forms.Label booksReservelbl;
        private System.Windows.Forms.Label booksQuotalbl;
        private System.Windows.Forms.GroupBox statusGroup;
        private System.Windows.Forms.TextBox booksQuotatxt;
        private System.Windows.Forms.TextBox booksReservetxt;
        private System.Windows.Forms.TextBox booksLoantxt;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.GroupBox borrowGroup;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}