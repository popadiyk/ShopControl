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
    public partial class ucClientCatalog : UserControl
    {
        private static ucClientCatalog _instance;
        public static ucClientCatalog Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucClientCatalog();
                    return _instance;
                
            }
        }
        public ucClientCatalog()
        {
            InitializeComponent();
        }
    }
}
