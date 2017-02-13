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
    public partial class ucManufacturerCatalog : UserControl, ISelected
    {
        private static ucManufacturerCatalog _instance;
        private ServiceClient loClient = new ServiceClient();

        public static ucManufacturerCatalog Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucManufacturerCatalog();
                return _instance;

            }
        }

        public ucManufacturerCatalog()
        {
            InitializeComponent();
            ReloadList();
        }

        public void ReloadList()
        {
            listViewManufacturerCatalog.Items.Clear();
            foreach (var i in loClient.ManufacturerCatalogList())
            {
                string[] row = { i.ID.ToString(), i.Name, i.Phone, i.SumDebt.ToString()};
                var listItem = new ListViewItem(row);
                listViewManufacturerCatalog.Items.Add(listItem);
            }
            listViewManufacturerCatalog.Columns[0].Width = 0;
        }

        public int GetSelectedId()
        {
            if (listViewManufacturerCatalog.SelectedItems.Count > 0)
            {

                return int.Parse(listViewManufacturerCatalog.SelectedItems[0].SubItems[0].Text);
            }
            return -1;
        }

        private void listViewManufacturerCatalog_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            if (e.ColumnIndex == 0)
            {
                e.NewWidth = listViewManufacturerCatalog.Columns[0].Width;

            }
        }
    }
}
