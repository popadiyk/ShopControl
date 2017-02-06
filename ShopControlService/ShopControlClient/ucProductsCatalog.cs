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
    public partial class ucProductsCatalog : UserControl
    {
        private static ucProductsCatalog _instance;
        public static ucProductsCatalog Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucProductsCatalog();
                return _instance;

            }
        }
        public ucProductsCatalog()
        {
            InitializeComponent();
        }
    }
}
