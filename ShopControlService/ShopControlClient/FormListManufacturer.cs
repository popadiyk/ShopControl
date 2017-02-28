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
    public partial class FormListManufacturer : Form
    {
        private ServiceClient loClient = new ServiceClient();
        public FormListManufacturer()
        {
            InitializeComponent();
            
        }

        private void FormListManufacturer_Load(object sender, EventArgs e)
        {
            ReloadList();
        }

        private void ReloadList()
        {
            listManufacturer.Items.Clear();
            foreach(var i in loClient.ManufacturerCatalogList())
            {
                string[] row =
                {
                    i.ID.ToString(),
                    i.Name
                };
                var listItem = new ListViewItem(row);
                listManufacturer.Items.Add(listItem);
            }
        }

        private void FormListManufacturer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void listManufacturer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Tag = listManufacturer.SelectedItems[0].SubItems[1].Text;
            Close();
        }

        private void FormListManufacturer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
