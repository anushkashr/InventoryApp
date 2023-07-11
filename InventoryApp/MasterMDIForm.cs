using InventoryApp.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class MasterMDIForm : Form
    {
        public MasterMDIForm()
        {
            InitializeComponent();
            //lblUserInfo.Text = "Welcome " + firstName + "!";
        }

        private void broadwayContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://broadwayinfosys.com/");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblUserInfo.Text = string.Format("Username:{0}, UserID:{1}, Role: {2}", SessionHelper.UserName, SessionHelper.UserID, SessionHelper.UserRole);
        }

        private void MasterMDIForm_Load(object sender, EventArgs e)
        {

        }
    }
}
