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
    public partial class FormAddChangeProducts : Form
    {
        private ServiceClient loClient = new ServiceClient();
        public FormAddChangeProducts()
        {
            InitializeComponent();
            formListManufacturer = new FormListManufacturer();
            formTreeGroup = new FormTreeGroup();
        }

        private FormTreeGroup formTreeGroup;
        private FormListManufacturer formListManufacturer;

        private int GetGroupID()
        {
            foreach (var i in loClient.ProductGroupList())
            {
                if (i.Name == txtBoxGroup.Text)
                {
                    return i.ID;
                }
            }
            return -1;
        }

        private int GetManufacturerID()
        {
            foreach (var i in loClient.ManufacturerCatalogList())
            {
                if (i.Name == txtBoxManufacturer.Text)
                {
                    return i.ID;
                }
            }
            return -1;
        }

        private void ClearAndIncrementedForm()
        {
            txtBoxMarking.Text = (int.Parse(txtBoxMarking.Text)+1).ToString();
            txtBoxPrice.Text = "";
            txtBoxPurchPrice.Text = "";
            txtBoxKoef.Text = "";
        }

        private void ClearForm()
        {
            txtBoxName.Text = "";
            txtBoxMarking.Text = "";
            txtBoxPrice.Text = "";
            txtBoxPurchPrice.Text = "";
            txtBoxKoef.Text = "";
            txtBoxDescripton.Text = "";
        }

        private void btnPlusGroup_Click(object sender, EventArgs e)
        {
            formTreeGroup.ShowDialog();
            txtBoxGroup.Text = formTreeGroup.Tag?.ToString();
        }

        private void btnPlusManufacturer_Click(object sender, EventArgs e)
        {
            formListManufacturer.ShowDialog();
            txtBoxManufacturer.Text = formListManufacturer.Tag?.ToString();
        }

        private void FormAddChangeProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (checkInput() == 0)
            {
                loClient.AddNewProduct(
                    txtBoxName.Text,
                    GetGroupID(),
                    GetManufacturerID(),
                    txtBoxMarking.Text,
                    (float)Math.Round(float.Parse(txtBoxPurchPrice.Text),2),
                    (float)Math.Round(float.Parse(txtBoxPrice.Text),2),
                    txtBoxDescripton.Text
                    );
                ClearAndIncrementedForm();
                ucProductsCatalog.Instance.ReloadList();
                Close();
            } else if (checkInput() == -1)
            {
                MessageBox.Show("Не все данные введены!");
            } else if (checkInput() == -2)
            {
                MessageBox.Show("Некоректно введены данные!");
            } else if (checkInput() == -3)
            {
                MessageBox.Show("Товар с таким артикулом уже существует!");
            }
        }

        private int checkInput()
        {

            if (string.IsNullOrEmpty(txtBoxName.Text))
            {
                return -1;
            }
            else if (string.IsNullOrEmpty(txtBoxManufacturer.Text))
            {
                return -1;
            }
            else if (string.IsNullOrEmpty(txtBoxGroup.Text))
            {
                return -1;
            }
            else if (string.IsNullOrEmpty(txtBoxMarking.Text))
            {
                return -1;
            }
            else if (string.IsNullOrEmpty(txtBoxPrice.Text))
            {
                return -1;
            }
            else if (string.IsNullOrEmpty(txtBoxPurchPrice.Text))
            {
                return -1;
            }

            try
            {
                float.Parse(txtBoxPrice.Text);
                float.Parse(txtBoxPurchPrice.Text);
                float.Parse(txtBoxKoef.Text);
                int.Parse(txtBoxMarking.Text);
            }
            catch
            {
                return -2;
            }

            foreach (var i in loClient.ProductCatalogList())
            {
                if (i.Marking == txtBoxMarking.Text.Trim())
                {
                    return -3;
                }
            }
            


            return 0;
        }

        private void btnDecide_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtBoxPurchPrice.Text) && !string.IsNullOrEmpty(txtBoxKoef.Text) && !string.IsNullOrEmpty(txtBoxPrice.Text))
                {
                    MessageBox.Show("Все поля заполнены!");
                }

                if (!string.IsNullOrEmpty(txtBoxPurchPrice.Text))
                {
                    if (!string.IsNullOrEmpty(txtBoxKoef.Text) && string.IsNullOrEmpty(txtBoxPrice.Text))
                    {
                        txtBoxPrice.Text = (float.Parse(txtBoxPurchPrice.Text) * float.Parse(txtBoxKoef.Text)).ToString();
                    }
                    else if (!string.IsNullOrEmpty(txtBoxPrice.Text) && string.IsNullOrEmpty(txtBoxKoef.Text))
                    {
                        txtBoxKoef.Text = (float.Parse(txtBoxPrice.Text) / float.Parse(txtBoxPurchPrice.Text)).ToString();
                    }

                    if (string.IsNullOrEmpty(txtBoxKoef.Text) && string.IsNullOrEmpty(txtBoxPrice.Text))
                    {
                        MessageBox.Show("Введите коэф. или цену продажи!");
                    }
                }
                else MessageBox.Show("Введите закупочную цену!");
            } catch
            {
                MessageBox.Show("Некоректно введены данные!");
            }
        }
    }
}
