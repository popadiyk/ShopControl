namespace ShopControlClient
{
    partial class ucClientCatalog
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
            this.listViewClientCatalog = new System.Windows.Forms.ListView();
            this.NameClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiscountClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalSumClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberCardClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumberClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateCreateClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewClientCatalog
            // 
            this.listViewClientCatalog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdClient,
            this.NameClient,
            this.DiscountClient,
            this.TotalSumClient,
            this.NumberCardClient,
            this.PhoneNumberClient,
            this.DateCreateClient,
            this.DescriptionClient});
            this.listViewClientCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewClientCatalog.FullRowSelect = true;
            this.listViewClientCatalog.GridLines = true;
            this.listViewClientCatalog.Location = new System.Drawing.Point(0, 0);
            this.listViewClientCatalog.Name = "listViewClientCatalog";
            this.listViewClientCatalog.Size = new System.Drawing.Size(964, 471);
            this.listViewClientCatalog.TabIndex = 0;
            this.listViewClientCatalog.UseCompatibleStateImageBehavior = false;
            this.listViewClientCatalog.View = System.Windows.Forms.View.Details;
            this.listViewClientCatalog.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewClientCatalog_ColumnWidthChanging);
            // 
            // NameClient
            // 
            this.NameClient.DisplayIndex = 1;
            this.NameClient.Text = "Имя";
            this.NameClient.Width = 304;
            // 
            // DiscountClient
            // 
            this.DiscountClient.DisplayIndex = 2;
            this.DiscountClient.Text = "Скидка";
            this.DiscountClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DiscountClient.Width = 52;
            // 
            // TotalSumClient
            // 
            this.TotalSumClient.DisplayIndex = 3;
            this.TotalSumClient.Text = "Сумма покупок";
            this.TotalSumClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalSumClient.Width = 95;
            // 
            // NumberCardClient
            // 
            this.NumberCardClient.DisplayIndex = 4;
            this.NumberCardClient.Text = "Номер карточки";
            this.NumberCardClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberCardClient.Width = 100;
            // 
            // PhoneNumberClient
            // 
            this.PhoneNumberClient.DisplayIndex = 5;
            this.PhoneNumberClient.Text = "Телефон";
            this.PhoneNumberClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneNumberClient.Width = 120;
            // 
            // DescriptionClient
            // 
            this.DescriptionClient.Text = "Описание";
            this.DescriptionClient.Width = 250;
            // 
            // IdClient
            // 
            this.IdClient.Text = "ID";
            this.IdClient.Width = 0;
            // 
            // DateCreateClient
            // 
            this.DateCreateClient.Text = "Дата рег.";
            this.DateCreateClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateCreateClient.Width = 75;
            // 
            // ucClientCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewClientCatalog);
            this.Name = "ucClientCatalog";
            this.Size = new System.Drawing.Size(964, 471);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewClientCatalog;
        private System.Windows.Forms.ColumnHeader NameClient;
        private System.Windows.Forms.ColumnHeader DiscountClient;
        private System.Windows.Forms.ColumnHeader TotalSumClient;
        private System.Windows.Forms.ColumnHeader NumberCardClient;
        private System.Windows.Forms.ColumnHeader PhoneNumberClient;
        private System.Windows.Forms.ColumnHeader DescriptionClient;
        private System.Windows.Forms.ColumnHeader IdClient;
        private System.Windows.Forms.ColumnHeader DateCreateClient;
    }
}
