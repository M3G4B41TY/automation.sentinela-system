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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void cadastroempresarialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadastroempresarialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automationsentinelaDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'automationsentinelaDataSet.cadastroempresarial'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroempresarialTableAdapter.Fill(this.automationsentinelaDataSet.cadastroempresarial);

        }
    }
}
