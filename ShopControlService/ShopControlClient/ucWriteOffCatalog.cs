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
    public partial class ucWriteOffCatalog : UserControl
    {
        private static ucWriteOffCatalog _instance;
        public static ucWriteOffCatalog Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucWriteOffCatalog();
                return _instance;

            }
        }
        public ucWriteOffCatalog()
        {
            InitializeComponent();
        }
    }
}
