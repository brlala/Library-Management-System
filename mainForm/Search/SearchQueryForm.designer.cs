namespace mainForm
{
    partial class SearchQueryForm
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
            this.queryResultdg = new System.Windows.Forms.DataGridView();
            this.querytoolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.queryResultdg)).BeginInit();
            this.SuspendLayout();
            // 
            // queryResultdg
            // 
            this.queryResultdg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.queryResultdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryResultdg.Location = new System.Drawing.Point(127, 102);
            this.queryResultdg.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.queryResultdg.MultiSelect = false;
            this.queryResultdg.Name = "queryResultdg";
            this.queryResultdg.ReadOnly = true;
            this.queryResultdg.RowTemplate.Height = 28;
            this.queryResultdg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.queryResultdg.Size = new System.Drawing.Size(799, 491);
            this.queryResultdg.TabIndex = 1;
            this.querytoolTip.SetToolTip(this.queryResultdg, "Double click to select");
            this.queryResultdg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.queryResultdg_CellDoubleClick);
            // 
            // SearchQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.queryResultdg);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "SearchQueryForm";
            this.Text = "Search Query";
            ((System.ComponentModel.ISupportInitialize)(this.queryResultdg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView queryResultdg;
        private System.Windows.Forms.ToolTip querytoolTip;
    }
}