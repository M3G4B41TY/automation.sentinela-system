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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value < 100)
            {
                progressBar2.Value = progressBar2.Value + 2;//Mostra o progresso da barra de progressão baseada no timer
            }
            else
            {
            timer1.Enabled = false;//Deixa o timer disponível para uso, o real tempo.
            this.Visible = false;
            Form2 qual = new Form2();//Responsável por levar o usuário de um form para outro.
            qual.ShowDialog();
            }
        }
    }
}
