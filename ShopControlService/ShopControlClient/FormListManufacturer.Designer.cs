namespace ShopControlClient
{
    partial class FormListManufacturer
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
            this.listManufacturer = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameMan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listManufacturer
            // 
            this.listManufacturer.BackColor = System.Drawing.Color.Azure;
            this.listManufacturer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NameMan});
            this.listManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listManufacturer.FullRowSelect = true;
            this.listManufacturer.GridLines = true;
            this.listManufacturer.Location = new System.Drawing.Point(0, 0);
            this.listManufacturer.Name = "listManufacturer";
            this.listManufacturer.Size = new System.Drawing.Size(284, 262);
            this.listManufacturer.TabIndex = 0;
            this.listManufacturer.UseCompatibleStateImageBehavior = false;
            this.listManufacturer.View = System.Windows.Forms.View.Details;
            this.listManufacturer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listManufacturer_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "Код";
            // 
            // NameMan
            // 
            this.NameMan.Text = "Поставщик";
            this.NameMan.Width = 220;
            // 
            // FormListManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listManufacturer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListManufacturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор поставщика";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormListManufacturer_FormClosed);
            this.Load += new System.EventHandler(this.FormListManufacturer_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FormListManufacturer_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listManufacturer;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NameMan;
    }
}