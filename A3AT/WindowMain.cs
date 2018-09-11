using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms;
using A3AT.UserControls;

namespace A3AT
{
    public partial class WindowMain : Form
    {
        public WindowMain()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void WindowMain_Load(object sender, EventArgs e)
        {
            Server testValues1 = new Server("Test Server 1", "156.513.51.16", 21);
            Server testValues2 = new Server("Test Server 2", "test.sampleIPMask.net", 21);
            Server testValues3 = new Server("Test Server 3", "test.sampleIPMask.net", 21);
            Server testValues4 = new Server("Test Server 4", "test.sampleIPMask.net", 21);
            Server testValues5 = new Server("Test Server 5", "test.sampleIPMask.net", 21);
            List<Server> TestList = new List<Server>() { testValues1, testValues2, testValues3, testValues4, testValues5 };

            bool success = CreateServerEntry(TestList);
            Debug.WriteLine("List population result: " + success.ToString());
        }

        private bool CreateServerEntry(List<Server> Servers)
        {
            int startPosX = 3;
            int startPosY = 3;
            int[] buttonSize = new int[2] { 75, 23};
            int[] TitleSize = new int[2] { 314, 15 };
            int[] IPSize = new int[2] { 164, 15 };
            int[] PortSize = new int[2] { 43, 15 };

            int i = 0;
            foreach (Server entry in Servers)
            {
                Debug.WriteLine(Servers.Count.ToString());
                UserControl uc = new UserControl();
                ServerInfo SI = new ServerInfo();
                SI.LblServerName = entry.Name;
                SI.LblServerAddress = String.Format("{0}: {1}", entry.IP, entry.Port);
                gbServers.Controls.Add(SI);
                SI.Location = new Point(startPosX, (startPosY + (100 * i)));
                i++;
            }

            return true;
        }
    }
}
