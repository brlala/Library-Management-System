namespace mainForm
{
    partial class StockAdjForm
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
            this.updatebtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.adjIDtxt = new System.Windows.Forms.TextBox();
            this.bookIDtxt = new System.Windows.Forms.TextBox();
            this.adjQtynud = new System.Windows.Forms.NumericUpDown();
            this.remarkstxt = new System.Windows.Forms.TextBox();
            this.remarkslbl = new System.Windows.Forms.Label();
            this.adjQtylbl = new System.Windows.Forms.Label();
            this.bookTitletxt = new System.Windows.Forms.TextBox();
            this.bookTitlelbl = new System.Windows.Forms.Label();
            this.bookIDlbl = new System.Windows.Forms.Label();
            this.adjIDlbl = new System.Windows.Forms.Label();
            this.currentQtytxt = new System.Windows.Forms.TextBox();
            this.currentQtylbl = new System.Windows.Forms.Label();
            this.reservedtxt = new System.Windows.Forms.TextBox();
            this.currentReservedtxt = new System.Windows.Forms.Label();
            this.onLoantxt = new System.Windows.Forms.TextBox();
            this.qtyLoanedtxt = new System.Windows.Forms.Label();
            this.stockAdjtoolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adjQtynud)).BeginInit();
            this.SuspendLayout();
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(878, 502);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(198, 61);
            this.updatebtn.TabIndex = 55;
            this.updatebtn.Text = "Update";
            this.stockAdjtoolTip.SetToolTip(this.updatebtn, "Update Stock");
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(546, 140);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(48, 40);
            this.searchbtn.TabIndex = 54;
            this.searchbtn.Text = "...";
            this.stockAdjtoolTip.SetToolTip(this.searchbtn, "Click to search for book");
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // adjIDtxt
            // 
            this.adjIDtxt.Enabled = false;
            this.adjIDtxt.Location = new System.Drawing.Point(340, 68);
            this.adjIDtxt.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.adjIDtxt.Name = "adjIDtxt";
            this.adjIDtxt.ReadOnly = true;
            this.adjIDtxt.Size = new System.Drawing.Size(196, 27);
            this.adjIDtxt.TabIndex = 53;
            // 
            // bookIDtxt
            // 
            this.bookIDtxt.Location = new System.Drawing.Point(340, 147);
            this.bookIDtxt.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bookIDtxt.Name = "bookIDtxt";
            this.bookIDtxt.Size = new System.Drawing.Size(196, 27);
            this.bookIDtxt.TabIndex = 52;
            this.bookIDtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bookIDtxt_KeyDown);
            this.bookIDtxt.Leave += new System.EventHandler(this.bookIDtxt_Leave);
            // 
            // adjQtynud
            // 
            this.adjQtynud.Location = new System.Drawing.Point(340, 281);
            this.adjQtynud.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.adjQtynud.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.adjQtynud.Name = "adjQtynud";
            this.adjQtynud.Size = new System.Drawing.Size(200, 27);
            this.adjQtynud.TabIndex = 51;
            this.stockAdjtoolTip.SetToolTip(this.adjQtynud, "Increase or decrease quantity");
            this.adjQtynud.ValueChanged += new System.EventHandler(this.adjQtynud_ValueChanged);
            // 
            // remarkstxt
            // 
            this.remarkstxt.Location = new System.Drawing.Point(340, 367);
            this.remarkstxt.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.remarkstxt.Multiline = true;
            this.remarkstxt.Name = "remarkstxt";
            this.remarkstxt.Size = new System.Drawing.Size(736, 95);
            this.remarkstxt.TabIndex = 50;
            this.stockAdjtoolTip.SetToolTip(this.remarkstxt, "Enter reason for stock adjustment");
            this.remarkstxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.remarkstxt_KeyDown);
            // 
            // remarkslbl
            // 
            this.remarkslbl.AutoSize = true;
            this.remarkslbl.Location = new System.Drawing.Point(50, 373);
            this.remarkslbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.remarkslbl.Name = "remarkslbl";
            this.remarkslbl.Size = new System.Drawing.Size(79, 21);
            this.remarkslbl.TabIndex = 49;
            this.remarkslbl.Text = "Remarks:";
            // 
            // adjQtylbl
            // 
            this.adjQtylbl.AutoSize = true;
            this.adjQtylbl.Location = new System.Drawing.Point(50, 284);
            this.adjQtylbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.adjQtylbl.Name = "adjQtylbl";
            this.adjQtylbl.Size = new System.Drawing.Size(180, 21);
            this.adjQtylbl.TabIndex = 48;
            this.adjQtylbl.Text = "Adjustment Quantity:";
            // 
            // bookTitletxt
            // 
            this.bookTitletxt.Enabled = false;
            this.bookTitletxt.Location = new System.Drawing.Point(813, 147);
            this.bookTitletxt.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bookTitletxt.Name = "bookTitletxt";
            this.bookTitletxt.Size = new System.Drawing.Size(263, 27);
            this.bookTitletxt.TabIndex = 47;
            // 
            // bookTitlelbl
            // 
            this.bookTitlelbl.AutoSize = true;
            this.bookTitlelbl.Location = new System.Drawing.Point(647, 152);
            this.bookTitlelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bookTitlelbl.Name = "bookTitlelbl";
            this.bookTitlelbl.Size = new System.Drawing.Size(86, 21);
            this.bookTitlelbl.TabIndex = 46;
            this.bookTitlelbl.Text = "Book Title:";
            // 
            // bookIDlbl
            // 
            this.bookIDlbl.AutoSize = true;
            this.bookIDlbl.Location = new System.Drawing.Point(50, 152);
            this.bookIDlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bookIDlbl.Name = "bookIDlbl";
            this.bookIDlbl.Size = new System.Drawing.Size(72, 21);
            this.bookIDlbl.TabIndex = 45;
            this.bookIDlbl.Text = "Book ID:";
            // 
            // adjIDlbl
            // 
            this.adjIDlbl.AutoSize = true;
            this.adjIDlbl.Location = new System.Drawing.Point(50, 73);
            this.adjIDlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.adjIDlbl.Name = "adjIDlbl";
            this.adjIDlbl.Size = new System.Drawing.Size(127, 21);
            this.adjIDlbl.TabIndex = 44;
            this.adjIDlbl.Text = "Adjustment ID:";
            // 
            // currentQtytxt
            // 
            this.currentQtytxt.Enabled = false;
            this.currentQtytxt.Location = new System.Drawing.Point(340, 212);
            this.currentQtytxt.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.currentQtytxt.Name = "currentQtytxt";
            this.currentQtytxt.Size = new System.Drawing.Size(196, 27);
            this.currentQtytxt.TabIndex = 58;
            // 
            // currentQtylbl
            // 
            this.currentQtylbl.AutoSize = true;
            this.currentQtylbl.Location = new System.Drawing.Point(50, 216);
            this.currentQtylbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.currentQtylbl.Name = "currentQtylbl";
            this.currentQtylbl.Size = new System.Drawing.Size(107, 21);
            this.currentQtylbl.TabIndex = 57;
            this.currentQtylbl.Text = "Current Qty:";
            // 
            // reservedtxt
            // 
            this.reservedtxt.Enabled = false;
            this.reservedtxt.Location = new System.Drawing.Point(813, 282);
            this.reservedtxt.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.reservedtxt.Name = "reservedtxt";
            this.reservedtxt.Size = new System.Drawing.Size(131, 27);
            this.reservedtxt.TabIndex = 60;
            // 
            // currentReservedtxt
            // 
            this.currentReservedtxt.AutoSize = true;
            this.currentReservedtxt.Location = new System.Drawing.Point(648, 285);
            this.currentReservedtxt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.currentReservedtxt.Name = "currentReservedtxt";
            this.currentReservedtxt.Size = new System.Drawing.Size(133, 21);
            this.currentReservedtxt.TabIndex = 59;
            this.currentReservedtxt.Text = "Reserved Stock:";
            // 
            // onLoantxt
            // 
            this.onLoantxt.Enabled = false;
            this.onLoantxt.Location = new System.Drawing.Point(813, 212);
            this.onLoantxt.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.onLoantxt.Name = "onLoantxt";
            this.onLoantxt.Size = new System.Drawing.Size(131, 27);
            this.onLoantxt.TabIndex = 62;
            // 
            // qtyLoanedtxt
            // 
            this.qtyLoanedtxt.AutoSize = true;
            this.qtyLoanedtxt.Location = new System.Drawing.Point(648, 218);
            this.qtyLoanedtxt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.qtyLoanedtxt.Name = "qtyLoanedtxt";
            this.qtyLoanedtxt.Size = new System.Drawing.Size(80, 21);
            this.qtyLoanedtxt.TabIndex = 61;
            this.qtyLoanedtxt.Text = "On Loan:";
            // 
            // StockAdjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 614);
            this.Controls.Add(this.onLoantxt);
            this.Controls.Add(this.qtyLoanedtxt);
            this.Controls.Add(this.reservedtxt);
            this.Controls.Add(this.currentReservedtxt);
            this.Controls.Add(this.currentQtytxt);
            this.Controls.Add(this.currentQtylbl);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.adjIDtxt);
            this.Controls.Add(this.bookIDtxt);
            this.Controls.Add(this.adjQtynud);
            this.Controls.Add(this.remarkstxt);
            this.Controls.Add(this.remarkslbl);
            this.Controls.Add(this.adjQtylbl);
            this.Controls.Add(this.bookTitletxt);
            this.Controls.Add(this.bookTitlelbl);
            this.Controls.Add(this.bookIDlbl);
            this.Controls.Add(this.adjIDlbl);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "StockAdjForm";
            this.Text = "Stock Adjustment";
            this.Load += new System.EventHandler(this.StockAdjForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adjQtynud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox adjIDtxt;
        private System.Windows.Forms.TextBox bookIDtxt;
        private System.Windows.Forms.NumericUpDown adjQtynud;
        private System.Windows.Forms.TextBox remarkstxt;
        private System.Windows.Forms.Label remarkslbl;
        private System.Windows.Forms.Label adjQtylbl;
        private System.Windows.Forms.TextBox bookTitletxt;
        private System.Windows.Forms.Label bookTitlelbl;
        private System.Windows.Forms.Label bookIDlbl;
        private System.Windows.Forms.Label adjIDlbl;
        private System.Windows.Forms.TextBox currentQtytxt;
        private System.Windows.Forms.Label currentQtylbl;
        private System.Windows.Forms.TextBox reservedtxt;
        private System.Windows.Forms.Label currentReservedtxt;
        private System.Windows.Forms.TextBox onLoantxt;
        private System.Windows.Forms.Label qtyLoanedtxt;
        private System.Windows.Forms.ToolTip stockAdjtoolTip;
    }
}