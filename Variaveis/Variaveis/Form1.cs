using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variaveis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorsaque = 10.0;
            saldo = saldo - valorsaque;
            MessageBox.Show("O saldo da conta após o saque é: " + saldo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensagem = "Boa Noite!!";
            string nome = "Drácula";
            MessageBox.Show(mensagem + " " + nome);
            int idade = 25;
            string msg = "Sua idade é :" + idade;
            MessageBox.Show(msg);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = 10.0;
            double num2 = 5.0;
            double num3 = 7.5;
            double num4 = 3.5;
            double res = (num1 + num2 + num3 + num4) / 4;
            MessageBox.Show("A média do aluno é: " + res);

        }
    }
}
