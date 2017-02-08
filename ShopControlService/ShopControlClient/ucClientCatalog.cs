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
    public partial class ucClientCatalog : UserControl
    {
        private ServiceClient loClient = new ServiceClient();

        private static ucClientCatalog _instance;
        public static ucClientCatalog Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucClientCatalog();
                    return _instance;
                
            }
        }
        public ucClientCatalog()
        {
            InitializeComponent();
            ReloadList();
        }

        public void ReloadList()
        {
            listViewClientCatalog.Items.Clear();
            foreach (var i in loClient.ClientCatalogList())
            {
                string[] row = { i.Name, i.Discount.ToString(), i.TotalSum.ToString(), i.CardNumber.ToString() };
                var listItem = new ListViewItem(row);
                listViewClientCatalog.Items.Add(listItem);
            }
        }

        
    }
}
