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
    public partial class FormTreeGroup : Form
    {
        private ServiceClient loClient = new ServiceClient();
        public FormTreeGroup()
        {
            InitializeComponent();
        }

        public void ReloadTree()
        {
            treeViewFormSelected.Nodes.Clear();
            treeViewFormSelected.Nodes.AddRange(ucProductGroup.Instance.DrawTree(loClient.ProductGroupList().ToList()));
        }

        private void treeViewFormSelected_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Tag = treeViewFormSelected.SelectedNode.Text;
            Close(); 
        }

        private void FormTreeGroup_Load(object sender, EventArgs e)
        {
            ReloadTree();
        }
    }
}
