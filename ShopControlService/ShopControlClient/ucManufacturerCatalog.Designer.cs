namespace ShopControlClient
{
    partial class ucManufacturerCatalog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewManufacturerCatalog = new System.Windows.Forms.ListView();
            this.IdClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumberClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SumDebt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewManufacturerCatalog
            // 
            this.listViewManufacturerCatalog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdClient,
            this.NameClient,
            this.PhoneNumberClient,
            this.SumDebt});
            this.listViewManufacturerCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewManufacturerCatalog.FullRowSelect = true;
            this.listViewManufacturerCatalog.GridLines = true;
            this.listViewManufacturerCatalog.Location = new System.Drawing.Point(0, 0);
            this.listViewManufacturerCatalog.Name = "listViewManufacturerCatalog";
            this.listViewManufacturerCatalog.Size = new System.Drawing.Size(647, 449);
            this.listViewManufacturerCatalog.TabIndex = 1;
            this.listViewManufacturerCatalog.UseCompatibleStateImageBehavior = false;
            this.listViewManufacturerCatalog.View = System.Windows.Forms.View.Details;
            this.listViewManufacturerCatalog.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewManufacturerCatalog_ColumnWidthChanging);
            // 
            // IdClient
            // 
            this.IdClient.Text = "ID";
            this.IdClient.Width = 0;
            // 
            // NameClient
            // 
            this.NameClient.Text = "Имя";
            this.NameClient.Width = 304;
            // 
            // PhoneNumberClient
            // 
            this.PhoneNumberClient.Text = "Телефон";
            this.PhoneNumberClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneNumberClient.Width = 120;
            // 
            // SumDebt
            // 
            this.SumDebt.Text = "Сумма дебета";
            this.SumDebt.Width = 120;
            // 
            // ucManufacturerCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewManufacturerCatalog);
            this.Name = "ucManufacturerCatalog";
            this.Size = new System.Drawing.Size(647, 449);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewManufacturerCatalog;
        private System.Windows.Forms.ColumnHeader IdClient;
        private System.Windows.Forms.ColumnHeader NameClient;
        private System.Windows.Forms.ColumnHeader PhoneNumberClient;
        private System.Windows.Forms.ColumnHeader SumDebt;
    }
}
