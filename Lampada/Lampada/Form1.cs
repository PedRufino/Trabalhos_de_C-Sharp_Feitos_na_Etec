using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lampada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LigDes_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (LigDes.CausesValidation == false)
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lamp1.Visible == true)
            {
                lamp1.Visible = false;
                lamp2.Visible = true;
                lamp3.Visible = false;
                lamp4.Visible = false;
                lamp5.Visible = false;
                lamp6.Visible = false;
                lamp7.Visible = false;
                lamp8.Visible = false;
                lamp9.Visible = false;
                lamp10.Visible = false;
                lamp11.Visible = false;
                lamp12.Visible = false;
                lamp13.Visible = false;
                lamp14.Visible = false;

            }else if(lamp2.Visible == true){
                lamp1.Visible = false;
                lamp2.Visible = false;
                lamp3.Visible = true;
                lamp4.Visible = false;
                lamp5.Visible = false;
                lamp6.Visible = false;
                lamp7.Visible = false;
                lamp8.Visible = false;
                lamp9.Visible = false;
                lamp10.Visible = false;
                lamp11.Visible = false;
                lamp12.Visible = false;
                lamp13.Visible = false;
                lamp14.Visible = false;

            }else if(lamp3.Visible == true){
                lamp1.Visible = false;
                lamp2.Visible = false;
                lamp3.Visible = false;
                lamp4.Visible = true;
                lamp5.Visible = false;
                lamp6.Visible = false;
                lamp7.Visible = false;
                lamp8.Visible = false;
                lamp9.Visible = false;
                lamp10.Visible = false;
                lamp11.Visible = false;
                lamp12.Visible = false;
                lamp13.Visible = false;
                lamp14.Visible = false;

            }else if(lamp4.Visible == true){
                lamp1.Visible = false;
                lamp2.Visible = false;
                lamp3.Visible = false;
                lamp4.Visible = false;
                lamp5.Visible = true;
                lamp6.Visible = false;
                lamp7.Visible = false;
                lamp8.Visible = false;
                lamp9.Visible = false;
                lamp10.Visible = false;
                lamp11.Visible = false;
                lamp12.Visible = false;
                lamp13.Visible = false;
                lamp14.Visible = false;

            }else if(lamp5.Visible == true){
                lamp1.Visible = false;
                lamp2.Visible = false;
                lamp3.Visible = false;
                lamp4.Visible = false;
                lamp5.Visible = false;
                lamp6.Visible = true;
                lamp7.Visible = false;
                lamp8.Visible = false;
                lamp9.Visible = false;
                lamp10.Visible = false;
                lamp11.Visible = false;
                lamp12.Visible = false;
                lamp13.Visible = false;
                lamp14.Visible = false;

            }else if(lamp6.Visible == true){
                lamp1.Visible = false;
                lamp2.Visible = false;
                lamp3.Visible = false;
                lamp4.Visible = false;
                lamp5.Visible = false;
                lamp6.Visible = false;
                lamp7.Visible = true;
                lamp8.Visible = false;
                lamp9.Visible = false;
                lamp10.Visible = false;
                lamp11.Visible = false;
                lamp12.Visible = false;
                lamp13.Visible = false;
                lamp14.Visible = false;

            }else if(lamp7.Visible == true){
                lamp1.Visible = false;
                lamp2.Visible = false;
                lamp3.Visible = false;
                lamp4.Visible = false;
                lamp5.Visible = false;
                lamp6.Visible = false;
                lamp7.Visible = false;
                lamp8.Visible = true;
                lamp9.Visible = false;
                lamp10.Visible = false;
                lamp11.Visible = false;
                lamp12.Visible = false;
                lamp13.Visible = false;
                lamp14.Visible = false;

            }else if(lamp8.Visible == true){
                lamp1.Visible = false;
                lamp2.Visible = false;
                lamp3.Visible = false;
                lamp4.Visible = false;
                lamp5.Visible = false;
                lamp6.Visible = false;
                lamp7.Visible = false;
                lamp8.Visible = false;
                lamp9.Visible = true;
                lamp10.Visible = false;
                lamp11.Visible = false;
                lamp12.Visible = false;
                lamp13.Visible = false;
                lamp14.Visible = false;

            }else if(lamp9.Visible == true){
                lamp1.Visible = false;
                lamp2.Visible = false;
                lamp3.Visible = false;
                lamp4.Visible = false;
                lamp5.Visible = false;
                lamp6.Visible = false;
                lamp7.Visible = false;
                lamp8.Visible = false;
                lamp9.Visible = false;
                lamp10.Visible = true;
                lamp11.Visible = false;
                lamp12.Visible = false;
                lamp13.Visible = false;
                lamp14.Visible = false;

            }else if (lamp10.Visible == true){
                lamp1.Visible = false;
                lamp2.Visible = false;
                lamp3.Visible = false;
                lamp4.Visible = false;
                lamp5.Visible = false;
                lamp6.Visible = false;
                lamp7.Visible = false;
                lamp8.Visible = false;
                lamp9.Visible = false;
                lamp10.Visible = false;
                lamp11.Visible = true;
                lamp12.Visible = false;
                lamp13.Visible = false;
                lamp14.Visible = false;
            }else if(lamp11.Visible == true){
                lamp1.Visible = false;
                lamp2.Visible = false;
                lamp3.Visible = false;
                lamp4.Visible = false;
                lamp5.Visible = false;
                lamp6.Visible = false;
                lamp7.Visible = false;
                lamp8.Visible = false;
                lamp9.Visible = false;
                lamp10.Visible = false;
                lamp11.Visible = false;
                lamp12.Visible = true;
                lamp13.Visible = false;
                lamp14.Visible = false;

            }else if(lamp12.Visible == true){
                lamp1.Visible = false;
                lamp2.Visible = false;
                lamp3.Visible = false;
                lamp4.Visible = false;
                lamp5.Visible = false;
                lamp6.Visible = false;
                lamp7.Visible = false;
                lamp8.Visible = false;
                lamp9.Visible = false;
                lamp10.Visible = false;
                lamp11.Visible = false;
                lamp12.Visible = false;
                lamp13.Visible = true;
                lamp14.Visible = false;

            }else if(lamp13.Visible == true){
                lamp1.Visible = false;
                lamp2.Visible = false;
                lamp3.Visible = false;
                lamp4.Visible = false;
                lamp5.Visible = false;
                lamp6.Visible = false;
                lamp7.Visible = false;
                lamp8.Visible = false;
                lamp9.Visible = false;
                lamp10.Visible = false;
                lamp11.Visible = false;
                lamp12.Visible = false;
                lamp13.Visible = false;
                lamp14.Visible = true;

            }else if(lamp14.Visible == true){
                lamp1.Visible = true;
                lamp2.Visible = false;
                lamp3.Visible = false;
                lamp4.Visible = false;
                lamp5.Visible = false;
                lamp6.Visible = false;
                lamp7.Visible = false;
                lamp8.Visible = false;
                lamp9.Visible = false;
                lamp10.Visible = false;
                lamp11.Visible = false;
                lamp12.Visible = false;
                lamp13.Visible = false;
                lamp14.Visible = false;
            }
        }
    }
}
