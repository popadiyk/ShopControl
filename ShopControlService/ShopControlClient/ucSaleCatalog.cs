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
    public partial class ucSaleCatalog : UserControl
    {
        private static ucSaleCatalog _instance;
        public static ucSaleCatalog Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSaleCatalog();
                return _instance;

            }
        }
        public ucSaleCatalog()
        {
            InitializeComponent();
        }
    }
}
