namespace ShopControlClient
{
    partial class ucProductsCatalog
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
            this.listViewProductsCatalog = new System.Windows.Forms.ListView();
            this.MarkProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ManufProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewProductsCatalog
            // 
            this.listViewProductsCatalog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MarkProd,
            this.NameProd,
            this.QuantProd,
            this.PriceProd,
            this.GroupProd,
            this.ManufProd});
            this.listViewProductsCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProductsCatalog.FullRowSelect = true;
            this.listViewProductsCatalog.GridLines = true;
            this.listViewProductsCatalog.Location = new System.Drawing.Point(0, 0);
            this.listViewProductsCatalog.Name = "listViewProductsCatalog";
            this.listViewProductsCatalog.Size = new System.Drawing.Size(800, 400);
            this.listViewProductsCatalog.TabIndex = 0;
            this.listViewProductsCatalog.UseCompatibleStateImageBehavior = false;
            this.listViewProductsCatalog.View = System.Windows.Forms.View.Details;
            this.listViewProductsCatalog.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewProductsCatalog_ItemSelectionChanged);
            this.listViewProductsCatalog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewProductsCatalog_MouseClick);
            // 
            // MarkProd
            // 
            this.MarkProd.Text = "Артикул";
            // 
            // NameProd
            // 
            this.NameProd.Text = "Наименование";
            this.NameProd.Width = 360;
            // 
            // QuantProd
            // 
            this.QuantProd.Text = "Остаток";
            // 
            // PriceProd
            // 
            this.PriceProd.Text = "Цена розн.";
            this.PriceProd.Width = 77;
            // 
            // GroupProd
            // 
            this.GroupProd.Text = "Группа товара";
            this.GroupProd.Width = 150;
            // 
            // ManufProd
            // 
            this.ManufProd.Text = "Производитель";
            this.ManufProd.Width = 150;
            // 
            // ucProductsCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewProductsCatalog);
            this.Name = "ucProductsCatalog";
            this.Size = new System.Drawing.Size(800, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProductsCatalog;
        private System.Windows.Forms.ColumnHeader MarkProd;
        private System.Windows.Forms.ColumnHeader NameProd;
        private System.Windows.Forms.ColumnHeader PriceProd;
        private System.Windows.Forms.ColumnHeader QuantProd;
        private System.Windows.Forms.ColumnHeader GroupProd;
        private System.Windows.Forms.ColumnHeader ManufProd;
    }
}
