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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 loginempresarial = new Form3();
            loginempresarial.ShowDialog(); //caso o usuário clique nesse buton, ele será direcionada para o login empresarial
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 loginresidencial = new Form4();//caso o usuário clique nesse buton, ele será direcionada para o login residencial
            loginresidencial.ShowDialog();
        }
    }
}
