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
    public partial class ucClientCatalog : UserControl, ISelected
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
            //listViewClientCatalog.Columns.Add(new ColumnHeader());
            //listViewClientCatalog.Columns[0].
            foreach (var i in loClient.ClientCatalogList())
            {
                
                string[] row = {i.ID.ToString(), i.Name, i.Discount.ToString(), i.TotalSum.ToString(), i.CardNumber.ToString(), i.PhoneNumber, i.CreateDate.ToString("dd-MM-yyyy"), i.Descripton };
                var listItem = new ListViewItem(row);
                listViewClientCatalog.Items.Add(listItem);
            }
            listViewClientCatalog.Columns[0].Width = 0;
        }

        public int GetSelectedId()
        {
            if(listViewClientCatalog.SelectedItems.Count > 0)
            {
                
                return int.Parse(listViewClientCatalog.SelectedItems[0].SubItems[0].Text);
            }
            return -1;
        }

        private void listViewClientCatalog_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            if (e.ColumnIndex == 0)
            {
                e.NewWidth = listViewClientCatalog.Columns[0].Width;

            }
            //listViewClientCatalog.Columns[0].Width = 0;
        }
    }
}
