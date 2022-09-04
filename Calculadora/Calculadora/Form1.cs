using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            lblresult.Text = "";
        }

        private void soma_Click(object sender, EventArgs e)
        {
            int nota1, nota2, result;
            nota1 = Convert.ToInt16(txtNota1.Text);
            nota2 = Convert.ToInt16(txtNota2.Text);
            result = nota1 + nota2;
            lblresult.Text = Convert.ToString(result);
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            int nota1, nota2, result;
            nota1 = Convert.ToInt16(txtNota1.Text);
            nota2 = Convert.ToInt16(txtNota2.Text);
            result = nota1 / nota2;
            lblresult.Text = Convert.ToString(result);
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            int nota1, nota2, result;
            nota1 = Convert.ToInt16(txtNota1.Text);
            nota2 = Convert.ToInt16(txtNota2.Text);
            result = nota1 - nota2;
            lblresult.Text = Convert.ToString(result);
        }
    }
}
