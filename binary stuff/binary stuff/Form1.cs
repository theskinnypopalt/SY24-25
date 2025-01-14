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
        

        private void bit1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bit8_TextChanged(object sender, EventArgs e)
        {
            
            

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
                bits[1] = 2;
            }
            else
            {
                bits[1] = 0;
            }
            if (bit3.Text == "1")
            {
                bits[2] = 4;
            }
            else
            {
                bits[2] = 0;
            }
            if (bit4.Text == "1")
            {
                bits[3] = 8;
            }
            else
            {
                bits[3] = 0;
            }
            if (bit5.Text == "1")
            {
                bits[4] = 16;
            }
            else
            {
                bits[4] = 0;
            }
            if (bit6.Text == "1")
            {
                bits[5] = 32;
            }
            else
            {
                bits[5] = 0;
            }
            if (bit7.Text == "1")
            {
                bits[6] = 64;
            }
            else
            {
                bits[6] = 0;
            }
            if (bit8.Text == "1")
            {
                bits[7] = 128;
            }
            else
            {
                bits[7] = 0;
            }
            firstcalc();
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
                bits2[1] = 2;
            }
            else
            {
                bits2[1] = 0;
            }
            if (b3.Text == "1")
            {
                bits2[2] = 4;
            }
            else
            {
                bits2[2] = 0;
            }
            if (b4.Text == "1")
            {
                bits2[3] = 8;
            }
            else
            {
                bits2[3] = 0;
            }
            if (b5.Text == "1")
            {
                bits2[4] = 16;
            }
            else
            {
                bits2[4] = 0;
            }
            if (b6.Text == "1")
            {
                bits2[5] = 32;
            }
            else
            {
                bits2[5] = 0;
            }
            if (b7.Text == "1")
            {
                bits2[6] = 64;
            }
            else
            {
                bits2[6] = 0;
            }
            if (b8.Text == "1")
            {
                bits2[7] = 128;
            }
            else
            {
                bits2[7] = 0;
            }
            secondcalc();
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
    }
}
