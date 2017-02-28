using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopControlClient.ServiceReference1;

namespace ShopControlClient
{
    public partial class FormAddChangeGroupProduct : Form
    {
        private ServiceClient loClient = new ServiceClient();
        public ProductGroup SelectedGroup = new ProductGroup();
        public FormAddChangeGroupProduct()
        {
            InitializeComponent();
        }
        int GetGroup()
        { 
                foreach (var i in loClient.ProductGroupList())
                {
                    if (i.Name == treeView1.SelectedNode?.Text)
                    {                
                        SelectedGroup = i;
                        txtBoxParentGroup.Text = SelectedGroup.Name;
                        return SelectedGroup.ID;
                    }
                }

            return 0;         
        }

        private void ClearForm()
        {
            txtBoxName.Text = "";
            txtBoxParentGroup.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                loClient.AddNewGroup(
                    txtBoxName.Text,
                    SelectedGroup.ID
                );
                SelectedGroup = null;
                ClearForm();
                this.Close();
                ucProductGroup.Instance.LoadTree();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void FormAddChangeGroupProduct_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.AddRange(ucProductGroup.Instance.DrawTree(loClient.ProductGroupList().ToList()));
            if (GetGroup() == 0)
            {
                try
                {
                    SelectedGroup.ID = 0;
                }
                catch
                {
                    SelectedGroup = null;
                }
            }
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GetGroup();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
        try
            {
                GetGroup();
                loClient.UpdateGroup(
                    Convert.ToInt32(Tag.ToString()),
                    txtBoxName.Text,
                    SelectedGroup.ID
                );
                SelectedGroup = null;
                ClearForm();
                Close();
                ucProductGroup.Instance.LoadTree();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SelectedGroup = null;
            ClearForm();
            Close();
        }

        private void FormAddChangeGroupProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelectedGroup = null;
            ClearForm();
            Close();
        }

        private void GroupNull_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedGroup.ID = 0;
            }
            catch
            {
                SelectedGroup = null;
            }
            txtBoxParentGroup.Text = "";
        }
    }
}
