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

        private void bit1_MouseDown(object sender, MouseEventArgs e)
        {
            if (bit1.Text == "1")
            {
                bit1.Text = "0";
            }
            else
            {
                bit1.Text = "1";
            }
        }

        private void bit2_MouseDown(object sender, MouseEventArgs e)
        {
            if (bit2.Text == "1")
            {
                bit2.Text = "0";
            }
            else
            {
                bit2.Text = "1";
            }
        }

        private void bit3_MouseDown(object sender, MouseEventArgs e)
        {
            if (bit3.Text == "1")
            {
                bit3.Text = "0";
            }
            else
            {
                bit3.Text = "1";
            }
        }

        private void bit4_MouseDown(object sender, MouseEventArgs e)
        {
            if (bit4.Text == "1")
            {
                bit4.Text = "0";
            }
            else
            {
                bit4.Text = "1";
            }
        }

        private void bit5_MouseDown(object sender, MouseEventArgs e)
        {
            if (bit5.Text == "1")
            {
                bit5.Text = "0";
            }
            else
            {
                bit5.Text = "1";
            }
        }

        private void bit6_MouseDown(object sender, MouseEventArgs e)
        {
            if (bit6.Text == "1")
            {
                bit6.Text = "0";
            }
            else
            {
                bit6.Text = "1";
            }
        }

        private void bit7_MouseDown(object sender, MouseEventArgs e)
        {
            if (bit7.Text == "1")
            {
                bit7.Text = "0";
            }
            else
            {
                bit7.Text = "1";
            }
        }

        private void bit8_MouseDown(object sender, MouseEventArgs e)
        {
            if (bit8.Text == "1")
            {
                bit8.Text = "0";
            }
            else
            {
                bit8.Text = "1";
            }
        }

        private void b1_MouseDown(object sender, MouseEventArgs e)
        {
            if (b1.Text == "1")
            {
                b1.Text = "0";
            }
            else
            {
                b1.Text = "1";
            }
        }

        private void b2_MouseDown(object sender, MouseEventArgs e)
        {
            if (b2.Text == "1")
            {
                b2.Text = "0";
            }
            else
            {
                b2.Text = "1";
            }
        }

        private void b3_MouseDown(object sender, MouseEventArgs e)
        {
            if (b3.Text == "1")
            {
                b3.Text = "0";
            }
            else
            {
                b3.Text = "1";
            }
        }

        private void b4_MouseDown(object sender, MouseEventArgs e)
        {
            if (b4.Text == "1")
            {
                b4.Text = "0";
            }
            else
            {
                b4.Text = "1";
            }
        }

        private void b5_MouseDown(object sender, MouseEventArgs e)
        {
            if (b5.Text == "1")
            {
                b5.Text = "0";
            }
            else
            {
                b5.Text = "1";
            }
        }

        private void b6_MouseDown(object sender, MouseEventArgs e)
        {
            if (b6.Text == "1")
            {
                b6.Text = "0";
            }
            else
            {
                b6.Text = "1";
            }
        }

        private void b7_MouseDown(object sender, MouseEventArgs e)
        {
            if (b7.Text == "1")
            {
                b7.Text = "0";
            }
            else
            {
                b7.Text = "1";
            }
        }

        private void b8_MouseDown(object sender, MouseEventArgs e)
        {
            if (b8.Text == "1")
            {
                b8.Text = "0";
            }
            else
            {
                b8.Text = "1";
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
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

            b1.Text = (bits[0] == 1 ? "1" : "0");
            b2.Text = (bits[0] == 1 ? "1" : "0");
            b3.Text = (bits[0] == 1 ? "1" : "0");
            b4.Text = (bits[0] == 1 ? "1" : "0");
            b5.Text = (bits[0] == 1 ? "1" : "0");
            b6.Text = (bits[0] == 1 ? "1" : "0");
            b7.Text = (bits[0] == 1 ? "1" : "0");
            b8.Text = (bits[0] == 1 ? "1" : "0");
        }
    }
}
