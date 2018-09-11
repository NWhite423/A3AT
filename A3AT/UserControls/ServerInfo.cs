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
                lblServerName.Text = value;
            }

            get
            {
                return lblServerName.Text;
            }
        }

        public string LblServerAddress
        {
            set
            {
                lblServerInfo.Text = value;
            }

            get
            {
                return lblServerInfo.Text;
            }
        }

        public string LblServerDisplayName
        {
            set
            {
                lblDisplayName.Text = value;
            }
            get
            {
                return lblDisplayName.Text;
            }
        }
    }
}
