using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binary_stuff
{
    public partial class Form1 : Form
    {
        int total1 = 0;
        int total2 = 0;
        int[] bits = new int[8];
        int[] bits2 = new int[8];
        public Form1()
        {
            InitializeComponent();
        }


        //private void bit1_TextChanged(object sender, EventArgs e)
        // {

        // }

        private void bit8_TextChanged(object sender, EventArgs e)
        {



         
        }
        private void firstcalc()
        {
            total1 = 0;
            if (bits[0] != 0)
            {
                total1 += 1;
            }
            if (bits[1] != 0)
            {
                total1 += 2;
            }
            if (bits[2] != 0)
            {
                total1 += 4;
            }
            if (bits[3] != 0)
            {
                total1 += 8;
            }
            if (bits[4] != 0)
            {
                total1 += 16;
            }
            if (bits[5] != 0)
            {
                total1 += 32;
            }
            if (bits[6] != 0)
            {
                total1 += 64;
            }
            if (bits[7] != 0)
            {
                total1 += 128;
            }
            answertb.Text = total1.ToString();
        }

        private void b8_TextChanged(object sender, EventArgs e)
        {

        }
        private void secondcalc()
        {
            total2 = 0;
            if (bits2[0] != 0)
            {
                total2 += 1;
            }
            if (bits2[1] != 0)
            {
                total2 += 2;
            }
            if (bits2[2] != 0)
            {
                total2 += 4;
            }
            if (bits2[3] != 0)
            {
                total2 += 8;
            }
            if (bits2[4] != 0)
            {
                total2 += 16;
            }
            if (bits2[5] != 0)
            {
                total2 += 32;
            }
            if (bits2[6] != 0)
            {
                total2 += 64;
            }
            if (bits2[7] != 0)
            {
                total2 += 128;
            }
            total2tb.Text = total2.ToString();
        }

        private void bit1_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else 
             ((TextBox)sender).Text = "1";

            if (bit1.Text == "1")
            {
                bits[0] = 1; 
            }
            else
            {
                bits[0] = 0;
            }
           firstcalc();
        }

        private void bit2_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
                ((TextBox)sender).Text = "1";
            if (bit2.Text == "1")
            {
                bits[1] = 1;
            }
            else
            {
                bits[1] = 0;
            }
            firstcalc();
        }

        private void bit3_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
                ((TextBox)sender).Text = "1";

            if (bit3.Text == "1")
            {
                bits[2] = 1;
            }
            else
            {
                bits[2] = 0;
            }
            firstcalc();
        }

        private void bit4_MouseDown(object sender, MouseEventArgs e)
        {

            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
                ((TextBox)sender).Text = "1"; 
            if (bit4.Text == "1")
            {
                bits[3] = 1;
            }
            else
            {
                bits[3] = 0;
            }
            firstcalc();
        }

        private void bit5_MouseDown(object sender, MouseEventArgs e)
        {

            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
                ((TextBox)sender).Text = "1"; 
            
            if (bit5.Text == "1")
            {
                bits[4] = 1;
            }
            else
            {
                bits[4] = 0;
            }
            firstcalc();
        }

        private void bit6_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
                ((TextBox)sender).Text = "1";
            
            if (bit6.Text == "1")
            {
                bits[5] = 1;
            }
            else
            {
                bits[5] = 0;
            }
            firstcalc();
        }

        private void bit7_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
                ((TextBox)sender).Text = "1";
            
            if (bit7.Text == "1")
            {
                bits[6] = 1;
            }
            else
            {
                bits[6] = 0;
            }
            firstcalc();
        }

        private void bit8_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
                ((TextBox)sender).Text = "1"; 
            
            if (bit8.Text == "1")
            {
                bits[7] = 1;
            }
            else
            {
                bits[7] = 0;
            }
            firstcalc();
        }

        private void b1_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
                ((TextBox)sender).Text = "1";
            
            if (b1.Text == "1")
            {
                bits2[0] = 1;
            }
            else
            {
                bits2[0] = 0;
            }
            secondcalc();
        }  

        private void b2_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
                ((TextBox)sender).Text = "1";

            if (b2.Text == "1")
            {
                bits2[1] = 1;
            }
            else
            {
                bits2[1] = 0;
            }
            secondcalc();
        }

        private void b3_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
                ((TextBox)sender).Text = "1";
            
            if (b3.Text == "1")
            {
                bits2[2] = 1;
            }
            else
            {
                bits2[2] = 0;
            }
            secondcalc();
        }

        private void b4_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
                ((TextBox)sender).Text = "1";
            
            if (b4.Text == "1")
            {
                bits2[3] = 1;
            }
            else
            {
                bits2[3] = 0;
            }
            secondcalc();
        }

        private void b5_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
                ((TextBox)sender).Text = "1";
            
            if (b5.Text == "1")
            {
                bits2[4] = 1;
            }
            else
            {
                bits2[4] = 0;
            }
            secondcalc();
        }

        private void b6_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
                ((TextBox)sender).Text = "1";
            
            if (b6.Text == "1")
            {
                bits2[5] = 1;
            }
            else
            {
                bits2[0] = 0;
            }
            secondcalc();
        }

        private void b7_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
                ((TextBox)sender).Text = "1"; 
            
            if (b7.Text == "1")
            {
                bits2[6] = 1;   
            }
            else
            {
                bits2[6] = 0;
            }
            secondcalc();
        }

        private void b8_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
                ((TextBox)sender).Text = "1"; 
            
            if (b8.Text == "1")
            {
                bits2[7] = 1;
            }
            else
            {
                bits2[7] = 0;
            }
            secondcalc();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                bits[i] = 0;
            }
            update();

        }
        private void update()
        {
            bit1.Text = (bits[0] == 1 ? "1" : "0");
            bit2.Text = (bits[0] == 1 ? "1" : "0");
            bit3.Text = (bits[0] == 1 ? "1" : "0");
            bit4.Text = (bits[0] == 1 ? "1" : "0");
            bit5.Text = (bits[0] == 1 ? "1" : "0");
            bit6.Text = (bits[0] == 1 ? "1" : "0");
            bit7.Text = (bits[0] == 1 ? "1" : "0");
            bit8.Text = (bits[0] == 1 ? "1" : "0");
           // answertb.Text = total1.ToString();

            b1.Text = (bits[0] == 1 ? "1" : "0");
            b2.Text = (bits[0] == 1 ? "1" : "0");
            b3.Text = (bits[0] == 1 ? "1" : "0");
            b4.Text = (bits[0] == 1 ? "1" : "0");
            b5.Text = (bits[0] == 1 ? "1" : "0");
            b6.Text = (bits[0] == 1 ? "1" : "0");
            b7.Text = (bits[0] == 1 ? "1" : "0");
            b8.Text = (bits[0] == 1 ? "1" : "0");
          //  answertb.Text = total2.ToString();

            bi1.Text = (bits[0] == 1 ? "1" : "0");
            bi2.Text = (bits[0] == 1 ? "1" : "0");
            bi3.Text = (bits[0] == 1 ? "1" : "0");
            bi4.Text = (bits[0] == 1 ? "1" : "0");
            bi5.Text = (bits[0] == 1 ? "1" : "0");
            bi6.Text = (bits[0] == 1 ? "1" : "0");
            bi7.Text = (bits[0] == 1 ? "1" : "0");
            bi8.Text = (bits[0] == 1 ? "1" : "0");
        }

        private void shiftrightbutton_Click(object sender, EventArgs e)
        {
            bit1.Text = bit2.Text;
            bit2.Text = bit3.Text;
            bit3.Text = bit4.Text;
            bit4.Text = bit5.Text;
            bit5.Text = bit6.Text;
            bit6.Text = bit7.Text;
            bit7.Text = bit8.Text;
            bit8.Text = bit1.Text;
        }

        private void shiftleftbutton_Click(object sender, EventArgs e)
        {
            bit1.Text = bit8.Text;
            bit2.Text = bit1.Text;
            bit3.Text = bit2.Text;
            bit4.Text = bit3.Text;
            bit5.Text = bit4.Text;
            bit6.Text = bit5.Text;
            bit7.Text = bit6.Text;
            bit8.Text = bit7.Text;
            

        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                bits[i] = 0;
            }
            update();
        }
    }
}
