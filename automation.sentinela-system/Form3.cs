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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void loginempresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginempresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automationsentinelaDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'automationsentinelaDataSet.loginempresa'. Você pode movê-la ou removê-la conforme necessário.
            this.loginempresaTableAdapter.Fill(this.automationsentinelaDataSet.loginempresa);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
