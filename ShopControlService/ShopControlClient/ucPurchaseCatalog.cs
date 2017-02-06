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
    public partial class ucPurchaseCatalog : UserControl
    {
        private static ucPurchaseCatalog _instance;
        public static ucPurchaseCatalog Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucPurchaseCatalog();
                return _instance;

            }
        }
        public ucPurchaseCatalog()
        {
            InitializeComponent();
        }
    }
}
