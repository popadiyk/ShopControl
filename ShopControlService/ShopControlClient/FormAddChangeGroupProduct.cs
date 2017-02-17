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
        private ProductGroup SelectedGroup = new ProductGroup();
        public FormAddChangeGroupProduct()
        {
            InitializeComponent();
        }
        int GetGroup()
        { 
                foreach (var i in loClient.ProductGroupList())
                {
                    if (i.Name == treeView1.SelectedNode.Text)
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
                SelectedGroup = new ProductGroup();
                ClearForm();
                Close();
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
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            GetGroup();
        }
    }
}
