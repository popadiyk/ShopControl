namespace ShopControlClient
{
    partial class FormTreeGroup
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
            this.treeViewFormSelected = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeViewFormSelected
            // 
            this.treeViewFormSelected.BackColor = System.Drawing.Color.Azure;
            this.treeViewFormSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFormSelected.Location = new System.Drawing.Point(0, 0);
            this.treeViewFormSelected.Name = "treeViewFormSelected";
            this.treeViewFormSelected.Size = new System.Drawing.Size(284, 262);
            this.treeViewFormSelected.TabIndex = 0;
            this.treeViewFormSelected.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeViewFormSelected_MouseDoubleClick);
            // 
            // FormTreeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.treeViewFormSelected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTreeGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор группы товаров";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormTreeGroup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewFormSelected;
    }
}