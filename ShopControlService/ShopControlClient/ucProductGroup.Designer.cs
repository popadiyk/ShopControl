﻿namespace ShopControlClient
{
    partial class ucProductGroup
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
            this.treeViewProductGroup = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeViewProductGroup
            // 
            this.treeViewProductGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewProductGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeViewProductGroup.Location = new System.Drawing.Point(0, 0);
            this.treeViewProductGroup.Name = "treeViewProductGroup";
            this.treeViewProductGroup.Size = new System.Drawing.Size(589, 417);
            this.treeViewProductGroup.TabIndex = 0;
            this.treeViewProductGroup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewProductGroup_AfterSelect);
            this.treeViewProductGroup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeViewProductGroup_MouseClick);
            // 
            // ucProductGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeViewProductGroup);
            this.Name = "ucProductGroup";
            this.Size = new System.Drawing.Size(589, 417);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewProductGroup;
    }
}
