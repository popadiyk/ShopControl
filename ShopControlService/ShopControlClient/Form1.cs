using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopControlClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            formAddNewClient = new FormAddNewClient();
        }

        FormAddNewClient formAddNewClient;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // ініцалізуємо, що в нас за ЮзерКонтрол в момент натискання батона
            string myControl = string.Empty;
            var list = this.panel.Controls;
            foreach (var control in list)
            {
                myControl = control.GetType().Name;
                break;
            }

            // перевіряємо, що в нас за ЮзерКонтрол в момент натискання батона
            switch (myControl)
            {
                case "ucClientCatalog":
                    formAddNewClient.ShowDialog();                   
                    break;
                case "ucManufacturerCatalog":
                    MessageBox.Show(myControl);
                    break;
                case "ucMenuCashier":
                    MessageBox.Show(myControl);
                    break;
                case "ucProductGroup":
                    MessageBox.Show(myControl);
                    break;
                case "ucProductsCatalog":
                    MessageBox.Show(myControl);
                    break;
                case "ucPurchaseCatalog":
                    MessageBox.Show(myControl);
                    break;
                case "ucSaleCatalog":
                    MessageBox.Show(myControl);
                    break;
                case "ucWriteOffCatalog":
                    MessageBox.Show(myControl);
                    break;


            }
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!panel.Controls.Contains(ucClientCatalog.Instance))
            {
                panel.Controls.Add(ucClientCatalog.Instance);
                ucClientCatalog.Instance.Dock = DockStyle.Fill;
                ucClientCatalog.Instance.BringToFront();
            }
            else
                ucClientCatalog.Instance.BringToFront();                
        }

        private void ManufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ucManufacturerCatalog.Instance))
            {
                panel.Controls.Add(ucManufacturerCatalog.Instance);
                ucManufacturerCatalog.Instance.Dock = DockStyle.Fill;
                ucManufacturerCatalog.Instance.BringToFront();
            }
            else
                ucManufacturerCatalog.Instance.BringToFront();

        }

        private void GroupТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ucProductGroup.Instance))
            {
                panel.Controls.Add(ucProductGroup.Instance);
                ucProductGroup.Instance.Dock = DockStyle.Fill;
                ucProductGroup.Instance.BringToFront();
            }
            else
                ucProductGroup.Instance.BringToFront();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ucProductsCatalog.Instance))
            {
                panel.Controls.Add(ucProductsCatalog.Instance);
                ucProductsCatalog.Instance.Dock = DockStyle.Fill;
                ucProductsCatalog.Instance.BringToFront();
            }
            else
                ucProductsCatalog.Instance.BringToFront();
        }

        private void MenuCasiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ucMenuCashier.Instance))
            {
                panel.Controls.Add(ucMenuCashier.Instance);
                ucMenuCashier.Instance.Dock = DockStyle.Fill;
                ucMenuCashier.Instance.BringToFront();
            }
            else
                ucMenuCashier.Instance.BringToFront();
        }

        private void prodazhiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ucSaleCatalog.Instance))
            {
                panel.Controls.Add(ucSaleCatalog.Instance);
                ucSaleCatalog.Instance.Dock = DockStyle.Fill;
                ucSaleCatalog.Instance.BringToFront();
            }
            else
                ucSaleCatalog.Instance.BringToFront();
        }

        private void zakupkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ucPurchaseCatalog.Instance))
            {
                panel.Controls.Add(ucPurchaseCatalog.Instance);
                ucPurchaseCatalog.Instance.Dock = DockStyle.Fill;
                ucPurchaseCatalog.Instance.BringToFront();
            }
            else
                ucPurchaseCatalog.Instance.BringToFront();
        }

        private void spisanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(ucWriteOffCatalog.Instance))
            {
                panel.Controls.Add(ucWriteOffCatalog.Instance);
                ucWriteOffCatalog.Instance.Dock = DockStyle.Fill;
                ucWriteOffCatalog.Instance.BringToFront();
            }
            else
                ucWriteOffCatalog.Instance.BringToFront();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var control = (ISelected)panel.Controls[0];
            int id = control.GetSelectedId();
            MessageBox.Show(id.ToString());
        }
    }
}
