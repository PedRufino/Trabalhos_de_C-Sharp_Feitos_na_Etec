using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acesso_Idade
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
            int idade;
            idade = Convert.ToInt32(num.Text);
            if (idade >= 18)
            {
                MessageBox.Show("Maior de 18, Pode passar!!!");
            }else{
                MessageBox.Show("Idade Não Permitida");
            }
        }
    }
}
