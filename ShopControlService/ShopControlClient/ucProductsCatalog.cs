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
    public partial class ucProductsCatalog : UserControl
    {
        private ServiceClient loClient = new ServiceClient();
        private static ucProductsCatalog _instance;
        public static ucProductsCatalog Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucProductsCatalog();
                return _instance;

            }
        }
        public ucProductsCatalog()
        {
            InitializeComponent();
            ReloadList();
        }

        public void ReloadList()
        {
            listViewProductsCatalog.Items.Clear();
            foreach (var i in loClient.ProductCatalogList())
            {
                string[] row = {
                    i.Marking,
                    i.Name,
                    i.Quantity.ToString(),
                    i.Price.ToString(),
                    i.Group?.Name,
                    i.Manufacturer?.Name
                };
                
                var listItem = new ListViewItem(row);
                listViewProductsCatalog.Items.Add(listItem);
            }
        }

        private void listViewProductsCatalog_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listViewProductsCatalog_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            MainForm.Instance.PutImage(listViewProductsCatalog.FocusedItem.Text);
        }
    }
}
