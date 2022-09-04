using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaAluno
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
            txtNota3.Clear();
            txtNota4.Clear();
            lblresult.Text = "";  // Deixa o label vazio ja que ele não tem uma opção de Clear


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Nota1, Nota2, Nota3, Nota4, media;  // Define as Variáveis
            Nota1 = Convert.ToDouble(txtNota1.Text); // converte o numero da caixa de texto para double = float
            Nota2 = Convert.ToDouble(txtNota2.Text);
            Nota3 = Convert.ToDouble(txtNota3.Text);
            Nota4 = Convert.ToDouble(txtNota4.Text);
            media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            lblresult.Text = Convert.ToString(media); // Converte o resultado para string e manda para Resultado

        }
    }
}
