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
    public partial class FormAddNewClient : Form
    {
        private ServiceClient loClient = new ServiceClient();
        public FormAddNewClient()
        {
            InitializeComponent();
        }

        private void FormAddNewClient_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {                
                loClient.AddNewClient(txtBoxName.Text,txtBoxDescripton.Text, Convert.ToInt32(txtBoxDiscount.Text.Trim()), Convert.ToInt32(txtBoxCardNumber.Text.Trim()), txtBoxPhoneNumber.Text, dateTimePickerAddClient.Value);
                txtBoxName.Text = "";
                txtBoxDescripton.Text = "";
                txtBoxDiscount.Text = "";
                txtBoxCardNumber.Text = "";
                txtBoxPhoneNumber.Text = "";
                dateTimePickerAddClient.Value = DateTime.Now;

                ucClientCatalog.Instance.ReloadList();

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //MessageBox.Show(dateTimePickerAddClient.Text.ToString());
        }
    }
}
