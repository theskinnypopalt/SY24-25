using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper
{
    public partial class Form1 : Form
    { 
        Button[] bntgrid = new Button[64];
        tile[] tilegrid = new tile[64];
        public Form1()
        {
            
            InitializeComponent();
          
            for (int i  = 0; i < 64;  i++)
            {
                bntgrid[i] = (Button)Controls["button" + (i + 1)];
                tilegrid[i] = new tile(bntgrid[i]);
                bntgrid[i].BackColor = Color.LightGreen;
            }

        }
        private Button getButton(int r, int c)
        {
            return (Button)getButton(r, c);
        }
        private int getIndex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal - 1;
        }
        
            
            bool flag = false;
        private void button1_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (!flag)
                {
                    button1.BackgroundImage = pictureBox2.Image;
                }
                else
                {
                    button1.BackgroundImage = null;
                    flag = !flag;
                }
            }
            if (e.Button == MouseButtons.Left)
            {
                button1.BackgroundImage = pictureBox1.Image;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // tile t = new tile();
            
        }


        private void button63_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.HotPink;
        }
    }
}
