using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cassino
{
    public partial class Form1 : Form
    {
        int cont;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quant;
            quant = Convert.ToInt16(textBox1.Text);
            if (quant >= 1) {
                cont = cont + 1;
                pictureBox1.Visible = false;
                Random radNum = new Random();
                label1.Text = Convert.ToString(radNum.Next(1, 10));
                label2.Text = Convert.ToString(radNum.Next(1, 10));
                label3.Text = Convert.ToString(radNum.Next(1, 10));
                if (cont == quant)
                {
                    button1.Enabled = false;
                    MessageBox.Show("SUAS TENTATIVAS ACABARAM!!!!!");
                }else if ((label1.Text == "7") && (label2.Text == "7") && (label3.Text == "7"))
                {
                    pictureBox1.Visible = true;
                    MessageBox.Show("Parabéns você ganhou!!!!!!");
                }
            }else{
                MessageBox.Show("INSIRA MOEDA");
            }
        }
    }
}
