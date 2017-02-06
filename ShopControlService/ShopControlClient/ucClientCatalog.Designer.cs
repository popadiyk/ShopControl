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
            this.SuspendLayout();
            // 
            // listViewClientCatalog
            // 
            this.listViewClientCatalog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameClient,
            this.DiscountClient,
            this.TotalSumClient,
            this.NumberCardClient});
            this.listViewClientCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewClientCatalog.FullRowSelect = true;
            this.listViewClientCatalog.GridLines = true;
            this.listViewClientCatalog.Location = new System.Drawing.Point(0, 0);
            this.listViewClientCatalog.Name = "listViewClientCatalog";
            this.listViewClientCatalog.Size = new System.Drawing.Size(672, 471);
            this.listViewClientCatalog.TabIndex = 0;
            this.listViewClientCatalog.UseCompatibleStateImageBehavior = false;
            this.listViewClientCatalog.View = System.Windows.Forms.View.Details;
            // 
            // NameClient
            // 
            this.NameClient.Text = "Имя";
            this.NameClient.Width = 375;
            // 
            // DiscountClient
            // 
            this.DiscountClient.Text = "Скидка";
            this.DiscountClient.Width = 52;
            // 
            // TotalSumClient
            // 
            this.TotalSumClient.Text = "Сумма покупок";
            this.TotalSumClient.Width = 95;
            // 
            // NumberCardClient
            // 
            this.NumberCardClient.Text = "Номер карточки клиента";
            this.NumberCardClient.Width = 140;
            // 
            // ucClientCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewClientCatalog);
            this.Name = "ucClientCatalog";
            this.Size = new System.Drawing.Size(672, 471);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewClientCatalog;
        private System.Windows.Forms.ColumnHeader NameClient;
        private System.Windows.Forms.ColumnHeader DiscountClient;
        private System.Windows.Forms.ColumnHeader TotalSumClient;
        private System.Windows.Forms.ColumnHeader NumberCardClient;
    }
}
