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
    public partial class FormListClient : Form
    {
        private readonly ServiceClient loClient = new ServiceClient();
        public FormListClient()
        {
            InitializeComponent();
        }

        private void FormListClient_Load(object sender, EventArgs e)
        {
            ReloadList();
        }

        public void ReloadList()
        {
            listClient.Items.Clear();
            foreach (var i in loClient.ClientCatalogList())
            {
                string[] row = {
                    i.CardNumber.ToString(),
                    i.Name
                };
                var listItem = new ListViewItem(row);
                listClient.Items.Add(listItem);
            }
        }

        private void FormListClient_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
