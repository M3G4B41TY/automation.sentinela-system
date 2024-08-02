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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void loginresidencialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginresidencialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automationsentinelaDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'automationsentinelaDataSet.loginresidencial'. Você pode movê-la ou removê-la conforme necessário.
            this.loginresidencialTableAdapter.Fill(this.automationsentinelaDataSet.loginresidencial);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 cadastroresi = new Form6();
            cadastroresi.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
