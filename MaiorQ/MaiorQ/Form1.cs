using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaiorQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Verif_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            num1 = Convert.ToDouble(n1.Text);
            num2 = Convert.ToDouble(n2.Text);
            num3 = Convert.ToDouble(n3.Text);
            if (num1 > num2 && num1 > num3)
            {
                result.Text = ("o Número " + num1.ToString() + " é Maior!");

            }
            else if (num2 > num1 && num2 > num3)
            {
                result.Text = ("o Número " + num2.ToString() + " é Maior!");

            }
            else
            {
                result.Text = ("o Número " + num3.ToString() + " é Maior!");
            }
        }
    }
}