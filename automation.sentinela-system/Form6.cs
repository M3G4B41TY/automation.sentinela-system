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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void cadastroresidencialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (nomeTextBox.Text == "")//testa se o campo tem algum valor digitado
            {
                MessageBox.Show("Campo em branco");
            }
            else
            {
                this.Validate();
                this.cadastroresidencialBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.automationsentinelaDataSet);
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'automationsentinelaDataSet.cadastroresidencial'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroresidencialTableAdapter.Fill(this.automationsentinelaDataSet.cadastroresidencial);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nomeTextBox.Text == "")//testa se o campo tem algum valor digitado
            {
                MessageBox.Show("Campo em branco");
            }
            else
            {
                this.Validate();
                this.cadastroresidencialBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.automationsentinelaDataSet);
            }
        }
    }
}
