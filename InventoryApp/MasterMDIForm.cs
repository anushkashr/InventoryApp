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
        }

        private void broadwayContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://broadwayinfosys.com/");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
    }
}
