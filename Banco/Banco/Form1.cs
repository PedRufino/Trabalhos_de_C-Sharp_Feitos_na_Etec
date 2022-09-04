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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void log_cont_Click(object sender, EventArgs e)
        {
            string usuario;
            string senha;
            usuario = user_name.Text;
            senha = pass_user.Text;
            if((usuario == "1234") && (senha == "2838"))
            {
                MessageBox.Show("Seja Bem Vindo!!! Pedro Rufino");
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!!!!!");
            }
        }

        private void clear_log_Click(object sender, EventArgs e)
        {
            user_name.Clear();
            pass_user.Clear();
        }
    }
}

