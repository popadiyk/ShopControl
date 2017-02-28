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
            ReloadList();
            formListClient = new FormListClient();
        }

        private FormListClient formListClient;
        public void ReloadTree()
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("<< Все товары >>");
            treeView1.Nodes.AddRange(ucProductGroup.Instance.DrawTree(loClient.ProductGroupList().ToList()));
        }

        public void ReloadList()
        {
            listViewProductsWorked.Items.Clear();
            foreach (var i in loClient.ProductCatalogList())
            {
                string[] row = {
                    i.Marking,
                    i.Name,
                    i.Quantity.ToString(),
                    i.Price.ToString("0.00")
                };

                var listItem = new ListViewItem(row);
                listViewProductsWorked.Items.Add(listItem);
            }
        }

        private void listViewProductsWorked_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            MainForm.Instance.PutImage(listViewProductsWorked.FocusedItem.Text);
            labelProduct.Text = listViewProductsWorked.FocusedItem.Text + " - " + listViewProductsWorked.FocusedItem.SubItems[1].Text;
            labelPrice.Text = "ЦЕНА: " + listViewProductsWorked.FocusedItem.SubItems[3].Text + " грн.";
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listViewProductsWorked.Items.Clear();
            if (treeView1.SelectedNode.Text != "<< Все товары >>")
            {
                foreach (var i in loClient.SearchByGroup(treeView1.SelectedNode.Text))
                {
                    string[] row = {
                    i.Marking,
                    i.Name,
                    i.Quantity.ToString(),
                    i.Price.ToString("0.00")
                };

                    var listItem = new ListViewItem(row);
                    listViewProductsWorked.Items.Add(listItem);

                }
            } else
            {
                ReloadList();
            }
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            formListClient.ShowDialog();
        }
    }
}
