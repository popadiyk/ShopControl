using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopControlClient.ServiceReference1;

namespace ShopControlClient
{
    public partial class ucMenuCashier : UserControl
    {
        private readonly ServiceClient loClient = new ServiceClient();
        private static ucMenuCashier _instance;
        public static ucMenuCashier Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucMenuCashier();
                return _instance;

            }
        }
        public ucMenuCashier()
        {
            InitializeComponent();
            ReloadTree();
        }

        public void ReloadTree()
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.AddRange(ucProductGroup.Instance.DrawTree(loClient.ProductGroupList().ToList()));
        }


    }
}
