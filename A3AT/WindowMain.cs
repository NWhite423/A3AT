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
            string[] testValues1 = new string[3] { "Server 1", "Server IP", "Server port" };
            string[] testValues2 = new string[3] { "Server 2", "Server IP", "Server port" };
            List<string[]> TestList = new List<string[]>() { testValues1, testValues2 };

            bool success = CreateServerEntry(TestList);
            Debug.WriteLine("List population result: " + success.ToString());
        }

        private bool CreateServerEntry(List<string[]> Servers)
        {
            int startPosX = 16;
            int startPosY = 5;
            int[] buttonSize = new int[2] { 75, 23};
            int[] TitleSize = new int[2] { 314, 15 };
            int[] IPSize = new int[2] { 164, 15 };
            int[] PortSize = new int[2] { 43, 15 };

            int i = 1;
            foreach (string[] entry in Servers)
            {
                Debug.WriteLine(Servers.Count.ToString());

                int yPos = (startPosY + TitleSize[1]) * i;
                Label Title = new Label
                {
                    Text = entry[0],
                    AutoSize = false,
                    Location = new Point(startPosX, yPos),
                    Size = new Size(TitleSize[0], TitleSize[1])
                };
                gbServers.Controls.Add(Title);
                Debug.WriteLine("Index " + i + " has been parsed.");
                i++;
            }

            return true;
        }
    }
}
