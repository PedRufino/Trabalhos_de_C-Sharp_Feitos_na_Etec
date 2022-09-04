using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impar_Par
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Verif_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(num1.Text);
            if (num % 2 == 0)
            {
                MessageBox.Show("O "+num+" número é PAR");
            }
            else
            {
                MessageBox.Show("O "+num+" número é IMPAR");
            }
        }
    }
}
