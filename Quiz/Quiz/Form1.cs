using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        private int _ticks;
 
        public int certo;
        public int errado;

        public Form1()
        {
            InitializeComponent();
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicio.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button1.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            res.Enabled = true;
            timer1.Enabled = true;
            timer1.Start();
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            certo = certo + 1;
            button2.Enabled = false;
            button3.Enabled = false;
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            errado = errado + 1;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            errado = errado + 1;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            certo = certo + 1;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            certo = certo + 1;
            button6.Enabled = false;
            button7.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            errado = errado + 1;
            button6.Enabled = false;
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(certo);
            label5.Text = Convert.ToString(errado);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            errado = errado + 1;
            button8.Enabled = false;
            button1.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            certo = certo + 1;
            button8.Enabled = false;
            button1.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            errado = errado + 1;
            button9.Enabled = false;
            button10.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            certo = certo + 1;
            button9.Enabled = false;
            button10.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            certo = certo + 1;
            button20.Enabled = false;
            button19.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            errado = errado + 1;
            button20.Enabled = false;
            button19.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            certo = certo + 1;
            button18.Enabled = false;
            button17.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            errado = errado + 1;
            button18.Enabled = false;
            button17.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            certo = certo + 1;
            button15.Enabled = false;
            button16.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            errado = errado + 1;
            button15.Enabled = false;
            button16.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            errado = errado + 1;
            button14.Enabled = false;
            button13.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            certo = certo + 1;
            button14.Enabled = false;
            button13.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            certo = certo + 1;
            button12.Enabled = false;
            button11.Enabled = false;
            timer1.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            errado = errado + 1;
            button12.Enabled = false;
            button11.Enabled = false;
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            label13.Text = Convert.ToString(_ticks);
            if (_ticks == 10)
            {
                timer1.Stop();
                MessageBox.Show("Seu Tempo Acabou!!!!!!");
                Application.Exit();
            }
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
            
        }
    }
}
