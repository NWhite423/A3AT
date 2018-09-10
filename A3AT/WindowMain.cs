using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private bool CreateServerEntry(List<string[]> Servers)
        {
            int[] buttonSize = new int[2] { 75, 23};
            int[] TitleSize = new int[2] { 314, 15 };
            int[] IPSize = new int[2] { 164, 15 };
            int[] PortSize = new int[2] { 43, 15 };

            return false;
        }
    }
}
