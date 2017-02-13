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
    public partial class FormAddChangeManufacturer : Form
    {
        private ServiceClient loClient = new ServiceClient();
        public FormAddChangeManufacturer()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtBoxName.Text = "";
            txtBoxPhone.Text = "";
            txtBoxEmail.Text = "";
            txtBoxWebsite.Text = "";
            checkBox1.Checked = false;
            txtBoxINN.Text = "";
            txtBoxEDERPOU.Text = "";
            txtBoxMFO.Text = "";
            txtBoxRR.Text = "";
            txtBoxBank.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                loClient.AddNewManufacturer(
                    txtBoxName.Text, 
                    txtBoxPhone.Text,
                    txtBoxEmail.Text,
                    txtBoxWebsite.Text,
                    checkBox1.Checked,
                    txtBoxINN.Text,
                    txtBoxEDERPOU.Text,
                    txtBoxMFO.Text,
                    txtBoxRR.Text,
                    txtBoxBank.Text
                );

                ClearForm();

                ucManufacturerCatalog.Instance.ReloadList();

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                int _id = Convert.ToInt32(Tag.ToString());
                loClient.UpdateManufacturer(_id, txtBoxName.Text, txtBoxPhone.Text, txtBoxEmail.Text,
                    txtBoxWebsite.Text, checkBox1.Checked, txtBoxINN.Text, txtBoxEDERPOU.Text, 
                    txtBoxMFO.Text, txtBoxRR.Text, txtBoxBank.Text);

                ClearForm();
                ucManufacturerCatalog.Instance.ReloadList();

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormAddChangeManufacturer_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            ClearForm();
        }
    }
}
