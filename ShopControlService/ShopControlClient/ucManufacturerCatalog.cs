using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopControlClient
{
    public partial class ucManufacturerCatalog : UserControl
    {
        private static ucManufacturerCatalog _instance;
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
        }
    }
}
