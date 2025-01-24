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
        int total3 = 0;
        int[] bits = new int[8];
        int[] bits2 = new int[8];
        int[] bits3 = new int[8];
        int[] carrybit1 = new int[8];
        
        
        public Form1()
        {
            InitializeComponent();
        }


        //private void bit1_TextChanged(object sender, EventArgs e)
        // {

        // }

       
        private void firstcalc()
        { 
            total1 = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] != 0)
                {
                    total1 += (int) Math.Pow(2,i);
                }
            }
            
           
           
            answertb.Text = total1.ToString();
        }

        private void b8_TextChanged(object sender, EventArgs e)
        {

        }
        private void secondcalc()
        {
           total2 = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits2[i] != 0)
                {
                    total2 += (int)Math.Pow(2, 1);
                }
            }
            

            
            total2tb.Text = total2.ToString();
        }

        private void thirdcalc()
        {
            total3 = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits3[i] != 0)
                {
                    total3 += (int)Math.Pow(2, 1);
                }
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                bits[i] = 0;
            }
            for (int i = 0; i < bits.Length; i++)
            {
                bits2[i] = 0;
            }
            for (int i = 0; i < bits.Length; i++)
            {
                bits3[i] = 0;
            }

            update();

        }
        private void update()
        {
            bit1.Text = (bits[0] == 1 ? "1" : "0");
            bit2.Text = (bits[1] == 1 ? "1" : "0");
            bit3.Text = (bits[2] == 1 ? "1" : "0");
            bit4.Text = (bits[3] == 1 ? "1" : "0");
            bit5.Text = (bits[4] == 1 ? "1" : "0");
            bit6.Text = (bits[5] == 1 ? "1" : "0");
            bit7.Text = (bits[6] == 1 ? "1" : "0");
            bit8.Text = (bits[7] == 1 ? "1" : "0");
           

            b1.Text = (bits2[0] == 1 ? "1" : "0");
            b2.Text = (bits2[1] == 1 ? "1" : "0");
            b3.Text = (bits2[2] == 1 ? "1" : "0");
            b4.Text = (bits2[3] == 1 ? "1" : "0");
            b5.Text = (bits2[4] == 1 ? "1" : "0");
            b6.Text = (bits2[5] == 1 ? "1" : "0");
            b7.Text = (bits2[6] == 1 ? "1" : "0");
            b8.Text = (bits2[7] == 1 ? "1" : "0");
          

            bi1.Text = (bits3[0] == 1 ? "1" : "0");
            bi2.Text = (bits3[1] == 1 ? "1" : "0");
            bi3.Text = (bits3[2] == 1 ? "1" : "0");
            bi4.Text = (bits3[3] == 1 ? "1" : "0");
            bi5.Text = (bits3[4] == 1 ? "1" : "0");
            bi6.Text = (bits3[5] == 1 ? "1" : "0");
            bi7.Text = (bits3[6] == 1 ? "1" : "0");
            bi8.Text = (bits3[7] == 1 ? "1" : "0");
            firstcalc();
            secondcalc();
            answertb.Text = total1.ToString();
            total2tb.Text = total2.ToString();
            answer3tb.Text = total3.ToString();

        }

        private void shiftrightbutton_Click(object sender, EventArgs e)
        {
           
            
            for (int i = 1; i < bits.Length; i++)
            {
                bits[i - 1] = bits[i];
            }
            bits[7] = 0;
            update();
            
           
        }

        private void shiftleftbutton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < bits.Length; i++)
            {
                bits[i + 1] = bits[i];
            }
            bits[0] = 0;
            update();


        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                bits[i] = 0;
            }
            update();
        }

        private void andbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] != 0 & bits2[i] != 0)
                {
                    bits3[i] = 1;
                }
                else if (bits[i] != 0 & bits2[i] == 0 || bits[i] == 0 & bits2[i] != 0 || bits[i] == 0 & bits2[i] == 0)
                {
                    bits3[i] = 0;
                }
            }
            update();
        }

       

        private void bit8_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
            {
                ((TextBox)sender).Text = "1";
            }

            if (bit1.Text == "1")
            {
                bits[0] = 1;
            }
            else
            {
                bits[0] = 0;
            }
            if (bit2.Text == "1")
            {
                bits[1] = 1;

            }
            else
            {
                bits[1] = 0;
            }
            if (bit3.Text == "1")
            {
                bits[2] = 1;

            }
            else
            {
                bits[2] = 0;
            }
            if (bit4.Text == "1")
            {
                bits[3] = 1;
            }
            else
            {
                bits[3] = 0;
            }
            if (bit5.Text == "1")
            {
                bits[4] = 1;
            }
            else
            { 
                bits[4] = 0;
            }
            if (bit6.Text == "1")
            {
                bits[5] = 1;
            }
            else
            {
                bits[5] = 0;
            }
            if (bit7.Text == "1")
            {
                bits[6] = 1;
            }
            else
            {
                bits[6] = 0;
            }
            if (bit8.Text == "1")
            {
                bits[7] = 1;
            }
            else
            {
                bits[7] = 0;
            }
            update();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (bits[0] == 1 & bits2[0] == 1 )
            {
                bits3[0] = 0;
                carrybit1[0] = 1;
            }
            else if (bits[0] == 0 & bits2[0] == 0 || bits[0] == 0 & bits2[0] == 1 || bits[0] == 1 & bits2[0] == 0)
            {
                bits3[0] = 1;
                carrybit1[0] = 0;
            }
            if (bits[1] == 1 & bits2[1] == 1 & carrybit1[1] == 0 || bits[1] == 1 & bits2[1] == 0 & carrybit1[1] == 1 ||
                bits[1] == 0 & bits2[1] == 1 & carrybit1[1] == 1)
            {
                bits3[1] = 0;
                carrybit1[1] = 1;
            }
            else if (bits[1] == 0 & bits2[1] == 1 && carrybit1[1] == 0 || bits[1] == 0 & bits2[1] == 0 & carrybit1[1] == 1 ||
                bits[1] == 1 & bits2[1] == 0 & carrybit1[1] == 0)
            {
                bits3[1] = 1;
                carrybit1[1] = 0;
            }
            //
            if (bits[2] == 1 & bits2[2] == 1 & carrybit1[2] == 0 || bits[2] == 1 & bits2[2] == 0 & carrybit1[2] == 1 ||
                bits[2] == 0 & bits2[2] == 1 & carrybit1[2] == 1)
            {
                bits3[2] = 0;
                carrybit1[2] = 1;
            }
            else if (bits[2] == 0 & bits2[2] == 1 && carrybit1[2] == 0 || bits[2] == 0 & bits2[2] == 0 & carrybit1[2] == 1 ||
                bits[2] == 1 & bits2[2] == 0 & carrybit1[2] == 0)
            {
                bits3[2] = 1;
                carrybit1[2] = 0;
            }
            //
            if (bits[3] == 1 & bits2[3] == 1 & carrybit1[3] == 0 || bits[3] == 1 & bits2[3] == 0 & carrybit1[3] == 1 ||
                bits[3] == 0 & bits2[3] == 1 & carrybit1[3] == 1)
            {
                bits3[3] = 0;
                carrybit1[3] = 1;
            }
            else if (bits[3] == 0 & bits2[3] == 1 && carrybit1[3] == 0 || bits[3] == 0 & bits2[3] == 0 & carrybit1[3] == 1 ||
                bits[3] == 1 & bits2[3] == 0 & carrybit1[3] == 0)
            {
                bits3[3] = 1;
                carrybit1[3] = 0;
            }
            //
            if (bits[4] == 1 & bits2[4] == 1 & carrybit1[4] == 0 || bits[4] == 1 & bits2[4] == 0 & carrybit1[4] == 1 ||
                bits[4] == 0 & bits2[4] == 1 & carrybit1[4] == 1)
            {
                bits3[4] = 0;
                carrybit1[4] = 1;
            }
            else if (bits[4] == 0 & bits2[4] == 1 && carrybit1[4] == 0 || bits[4] == 0 & bits2[4] == 0 & carrybit1[4] == 1 ||
                bits[4] == 1 & bits2[4] == 0 & carrybit1[4] == 0)
            {
                bits3[4] = 1;
                carrybit1[4] = 0;
            }
            //
            if (bits[5] == 1 & bits2[5] == 1 & carrybit1[5] == 0 || bits[5] == 1 & bits2[5] == 0 & carrybit1[5] == 1 ||
                bits[5] == 0 & bits2[5] == 1 & carrybit1[5] == 1)
            {
                bits3[5] = 0;
                carrybit1[5] = 1;
            }
            else if (bits[5] == 0 & bits2[5] == 1 && carrybit1[5] == 0 || bits[5] == 0 & bits2[5] == 0 & carrybit1[5] == 1 ||
                bits[5] == 1 & bits2[5] == 0 & carrybit1[5] == 0)
            {
                bits3[5] = 1;
                carrybit1[5] = 0;
            }
            //
            if (bits[6] == 1 & bits2[6] == 1 & carrybit1[6] == 0 || bits[6] == 1 & bits2[6] == 0 & carrybit1[6] == 1 ||
                bits[6] == 0 & bits2[6] == 1 & carrybit1[6] == 1)
            {
                bits3[6] = 0;
                carrybit1[6] = 1;
            }
            else if (bits[6] == 0 & bits2[6] == 1 && carrybit1[6] == 0 || bits[6] == 0 & bits2[6] == 0 & carrybit1[6] == 1 ||
                bits[6] == 1 & bits2[6] == 0 & carrybit1[6] == 0)
            {
                bits3[6] = 1;
                carrybit1[6] = 0;
            }
            //
            if (bits[7] == 1 & bits2[7] == 1 & carrybit1[7] == 0 || bits[7] == 1 & bits2[7] == 0 & carrybit1[7] == 1 ||
                bits[7] == 0 & bits2[7] == 1 & carrybit1[7] == 1)
            {
                bits3[7] = 0;
                carrybit1[7] = 1;
            }
            else if (bits[7] == 0 & bits2[7] == 1 && carrybit1[7] == 0 || bits[7] == 0 & bits2[7] == 0 & carrybit1[7] == 1 ||
                bits[7] == 1 & bits2[7] == 0 & carrybit1[7] == 0)
            {
                bits3[7] = 1;
                carrybit1[7] = 0;
            }



            update();
        }

        private void b8_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "1")
            {
                ((TextBox)sender).Text = "0";
            }
            else
            {
                ((TextBox)sender).Text = "1";
            }

            if (b1.Text == "1")
            {
                bits2[0] = 1;
            }
            else
            {
                bits2[0] = 0;
            }
            if (b2.Text == "1")
            {
                bits2[1] = 1;

            }
            else
            {
                bits2[1] = 0;
            }
            if (b3.Text == "1")
            {
                bits2[2] = 1;

            }
            else
            {
                bits2[2] = 0;
            }
            if (b4.Text == "1")
            {
                bits2[3] = 1;
            }
            else
            {
                bits2[3] = 0;
            }
            if (b5.Text == "1")
            {
                bits2[4] = 1;
            }
            else
            {
                bits2[4] = 0;
            }
            if (b6.Text == "1")
            {
                bits2[5] = 1;
            }
            else
            {
                bits2[5] = 0;
            }
            if (b7.Text == "1")
            {
                bits2[6] = 1;
            }
            else
            {
                bits2[6] = 0;
            }
            if (b8.Text == "1")
            {
                bits2[7] = 1;
            }
            else
            {
                bits2[7] = 0;
            }
            update();
        }

        private void orbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] != 0 & bits2[i] != 0 || bits[i] != 0 & bits2[i] == 0 || bits[i] == 0 & bits2[i] != 0)
                {
                    bits3[i] = 1;
                }
                else if (bits[i] == 0 & bits2[i] == 0)
                {
                    bits3[i] = 0;
                }
            }
            update();
        }
    }
}
