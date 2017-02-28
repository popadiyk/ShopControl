namespace ShopControlClient
{
    partial class FormListClient
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
            this.listClient = new System.Windows.Forms.ListView();
            this.CardNumbClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBoxSearchCard = new System.Windows.Forms.TextBox();
            this.txtBoxSearchName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listClient
            // 
            this.listClient.BackColor = System.Drawing.Color.Azure;
            this.listClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CardNumbClient,
            this.NameClient});
            this.listClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.listClient.FullRowSelect = true;
            this.listClient.GridLines = true;
            this.listClient.Location = new System.Drawing.Point(0, 0);
            this.listClient.Name = "listClient";
            this.listClient.Size = new System.Drawing.Size(284, 234);
            this.listClient.TabIndex = 1;
            this.listClient.UseCompatibleStateImageBehavior = false;
            this.listClient.View = System.Windows.Forms.View.Details;
            // 
            // CardNumbClient
            // 
            this.CardNumbClient.Text = "Карта";
            // 
            // NameClient
            // 
            this.NameClient.Text = "Клиент";
            this.NameClient.Width = 220;
            // 
            // txtBoxSearchCard
            // 
            this.txtBoxSearchCard.Location = new System.Drawing.Point(0, 240);
            this.txtBoxSearchCard.Name = "txtBoxSearchCard";
            this.txtBoxSearchCard.Size = new System.Drawing.Size(63, 20);
            this.txtBoxSearchCard.TabIndex = 2;
            // 
            // txtBoxSearchName
            // 
            this.txtBoxSearchName.Location = new System.Drawing.Point(69, 240);
            this.txtBoxSearchName.Name = "txtBoxSearchName";
            this.txtBoxSearchName.Size = new System.Drawing.Size(214, 20);
            this.txtBoxSearchName.TabIndex = 3;
            // 
            // FormListClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtBoxSearchName);
            this.Controls.Add(this.txtBoxSearchCard);
            this.Controls.Add(this.listClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор клиента";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListClient_FormClosing);
            this.Load += new System.EventHandler(this.FormListClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listClient;
        private System.Windows.Forms.ColumnHeader CardNumbClient;
        private System.Windows.Forms.ColumnHeader NameClient;
        private System.Windows.Forms.TextBox txtBoxSearchCard;
        private System.Windows.Forms.TextBox txtBoxSearchName;
    }
}