namespace mainForm
{
    partial class LoginForm
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
            this.userIdlbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.userIdtxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userIdlbl
            // 
            this.userIdlbl.AutoSize = true;
            this.userIdlbl.Location = new System.Drawing.Point(185, 118);
            this.userIdlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userIdlbl.Name = "userIdlbl";
            this.userIdlbl.Size = new System.Drawing.Size(63, 21);
            this.userIdlbl.TabIndex = 0;
            this.userIdlbl.Text = "User ID";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Location = new System.Drawing.Point(185, 208);
            this.passwordlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(82, 21);
            this.passwordlbl.TabIndex = 1;
            this.passwordlbl.Text = "Password";
            // 
            // userIdtxt
            // 
            this.userIdtxt.Location = new System.Drawing.Point(333, 107);
            this.userIdtxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userIdtxt.Name = "userIdtxt";
            this.userIdtxt.Size = new System.Drawing.Size(164, 27);
            this.userIdtxt.TabIndex = 2;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(333, 204);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(164, 27);
            this.passwordtxt.TabIndex = 3;
            this.passwordtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordtxt_KeyDown);
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(163, 289);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(125, 37);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(397, 289);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(125, 37);
            this.cancelbtn.TabIndex = 5;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 437);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.userIdtxt);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.userIdlbl);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userIdlbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.TextBox userIdtxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}