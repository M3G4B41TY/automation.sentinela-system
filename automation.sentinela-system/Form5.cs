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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void cadastroempresarialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if(nomeTextBox.Text == "")//testa se o campo tem algum valor digitado
            {
                MessageBox.Show("Campo em branco");
            }
            else
            {
                this.Validate();
                this.cadastroempresarialBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.automationsentinelaDataSet);
            }
            


        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'automationsentinelaDataSet.cadastroempresarial'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroempresarialTableAdapter.Fill(this.automationsentinelaDataSet.cadastroempresarial);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

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
                this.cadastroempresarialBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.automationsentinelaDataSet);
            }
        }
    }
}
