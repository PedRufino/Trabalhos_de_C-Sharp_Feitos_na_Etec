using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Pessoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cad_Click(object sender, EventArgs e)
        {
            if (namebox.Text == "")
            {
                MessageBox.Show("PRIMEIRO DIGITE SEU NOME");
                namebox.Focus();
            }
            else { 
            
                listBox1.Items.Add(namebox.Text);
                listBox1.Items.Add(cpf.Text);
                listBox1.Items.Add(rua.Text);
                listBox1.Items.Add(City.Text);
                listBox1.Items.Add(Estad.Text);
                listBox1.Items.Add(fone.Text);
                listBox1.Items.Add(email.Text);
            }

        }
    }
}
