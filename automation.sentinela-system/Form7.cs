using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automation.sentinela_system
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void residênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 consulresi = new Form9();
            consulresi.ShowDialog();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 consulempresa = new Form8();
            consulempresa.ShowDialog();
        }
    }
}
