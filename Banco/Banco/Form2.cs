using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btSac_Click(object sender, EventArgs e)
        {
            double total, quant,saldo;
            saldo = Convert.ToDouble(Sald.Text);
            quant = Convert.ToDouble(valorBox.Text);
            total = saldo - quant;

            if (quant > saldo)
            {
                MessageBox.Show("Saldo Insuficiente");
                valorBox.Clear();
                lbTotal.Text = "";
            }else
            {
                MessageBox.Show("Foi Sacado R$"+quant);
                Sald.Text = "";
                Sald.Text = Convert.ToString(total);
            }
        }
   
        private void clean_Click(object sender, EventArgs e)
        {
            valorBox.Clear();
            lbTotal.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btSac_Click_1(object sender, EventArgs e)
        {
            double total, quant, saldo;
            saldo = Convert.ToDouble(Sald.Text);
            quant = Convert.ToDouble(valorBox.Text);
            total = saldo + quant;
            MessageBox.Show("Foi Depositado R$" + quant);
            Sald.Text = "";
            Sald.Text = Convert.ToString(total);
        }
    }
}
