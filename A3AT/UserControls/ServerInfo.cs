using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3AT.UserControls
{
    public partial class ServerInfo : UserControl
    {
        public ServerInfo()
        {
            InitializeComponent();
        }
        public string LblServerName
        {
            set
            {
                label1.Text = value;
            }

            get
            {
                return label1.Text;
            }
        }

        public string LblServerAddress
        {
            set
            {
                label2.Text = value;
            }

            get
            {
                return label2.Text;
            }
        }
    }
}
