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
    public partial class ucProductGroup : UserControl
    {
        private static ucProductGroup _instance;
        public static ucProductGroup Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucProductGroup();
                return _instance;

            }
        }
        public ucProductGroup()
        {
            InitializeComponent();
        }
    }
}
