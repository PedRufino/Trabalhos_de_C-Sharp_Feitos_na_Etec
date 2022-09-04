using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (homem1.Visible == true)
            {
                homem1.Visible = false;
                homem2.Visible = true;
                homem3.Visible = false;
                homem4.Visible = false;
                homem5.Visible = false;
                homem6.Visible = false;
                homem7.Visible = false;
                homem8.Visible = false;
            }else if(homem2.Visible == true){
                homem1.Visible = false;
                homem2.Visible = false;
                homem3.Visible = true;
                homem4.Visible = false;
                homem5.Visible = false;
                homem6.Visible = false;
                homem7.Visible = false;
                homem8.Visible = false;
            }else if(homem3.Visible == true){
                homem1.Visible = false;
                homem2.Visible = false;
                homem3.Visible = false;
                homem4.Visible = true;
                homem5.Visible = false;
                homem6.Visible = false;
                homem7.Visible = false;
                homem8.Visible = false;
            }else if(homem4.Visible == true){
                homem1.Visible = false;
                homem2.Visible = false;
                homem3.Visible = false;
                homem4.Visible = false;
                homem5.Visible = true;
                homem6.Visible = false;
                homem7.Visible = false;
                homem8.Visible = false;
            }else if(homem5.Visible == true){
                homem1.Visible = false;
                homem2.Visible = false;
                homem3.Visible = false;
                homem4.Visible = false;
                homem5.Visible = false;
                homem6.Visible = true;
                homem7.Visible = false;
                homem8.Visible = false;
            }else if(homem6.Visible == true){
                homem1.Visible = false;
                homem2.Visible = false;
                homem3.Visible = false;
                homem4.Visible = false;
                homem5.Visible = false;
                homem6.Visible = false;
                homem7.Visible = true;
                homem8.Visible = false;
            }else if(homem7.Visible == true){
                homem1.Visible = false;
                homem2.Visible = false;
                homem3.Visible = false;
                homem4.Visible = false;
                homem5.Visible = false;
                homem6.Visible = false;
                homem7.Visible = false;
                homem8.Visible = true;
            }else if(homem8.Visible == true){
                homem1.Visible = true;
                homem2.Visible = false;
                homem3.Visible = false;
                homem4.Visible = false;
                homem5.Visible = false;
                homem6.Visible = false;
                homem7.Visible = false;
                homem8.Visible = false;
            }
        }
    }
}
