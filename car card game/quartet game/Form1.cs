using car_card_game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quartet_game
{
    public partial class Form1 : Form
    {
        car_card A1 = new car_card("a1", "BMW Z8", 250, 4.7, 400, 4941, 8, 6600);
        car_card A2 = new car_card("a2", "MG Xpower SV Club Sport", 230, 4.2, 465, 4997, 8, 6450);
        car_card A3 = new car_card("a3", "Ferrari F430 F1", 315, 4.0, 490, 4308, 8, 8500);
        car_card A4 = new car_card("a4", "Viper GTS", 285, 4.6, 411, 7990, 10, 5100);
        car_card B1 = new car_card("b1", "Ford GT", 325, 3.3, 550, 5403, 8, 5250);
        car_card B2 = new car_card("b2", "TVR Sagaris", 300, 3.9, 3966, 400, 8, 7000);
        car_card B3 = new car_card("b3", "Range Rover Sport", 225, 7.6, 390, 4197, 8, 5750);
        car_card B4 = new car_card("b4", "Rindspeed Chopster", 290, 4.4, 600, 4511, 8, 6700);
        car_card C1 = new car_card("c1", "Maserati Spyder", 283, 5.0, 390, 4244, 8, 7000);
        car_card C2 = new car_card("c2", "Toyota Celia", 205, 8.7, 143, 1794, 4, 6400);
        car_card C3 = new car_card("c3", "Porsche 911 Targa", 285, 5.2, 320, 3596, 6, 6800);
        car_card C4 = new car_card("c4", "Corvette Coupe", 281, 5.2, 344, 5665, 8, 5400);
        car_card D1 = new car_card("d1", "Audi RS4", 250, 4.8, 420, 4163, 8, 7800);
        car_card D2 = new car_card("d2", "Audi RS 6 Plus", 280, 4.6, 480, 4172, 8, 6400);
        car_card D3 = new car_card("d3", "Nissan 350 Z", 250, 5.9, 280, 3498, 6, 6200);
        car_card D4 = new car_card("d4", "Mercedes CLK DTM AMG", 320, 4.0, 582, 5439, 8, 6100);
        car_card E1 = new car_card("e1", "Aston Martin V8 Vantage", 280, 5.0, 4282, 385, 8, 7000);
        car_card E2 = new car_card("e2", "Ferrari F50", 325, 3.9, 521, 4700, 12, 8500);
        car_card E3 = new car_card("e3", "BMW 645 Ci", 250, 5.6, 333, 4398, 7, 6100);
        car_card E4 = new car_card("e4", "Bentley Azure", 241, 6.7, 6750, 388, 8, 4000);
        car_card F1 = new car_card("f1", "Opel Astra Coupe 2.0", 245, 7.5, 192, 1998, 4, 5400);
        car_card F2 = new car_card("f2", "VW Golf R32", 248, 6.2, 250, 3189, 6, 6300);
        car_card F3 = new car_card("f3", "Chrysler Crossfire", 250, 6.9, 218, 3199, 6, 5700);
        car_card F4 = new car_card("f4", "Fisker Tramonto", 325, 3.6, 610, 5439, 8, 6100);
        car_card G1 = new car_card("g1", "Marcos Mantara", 225, 5.4, 190, 3998, 8, 4750);
        car_card G2 = new car_card("g2", "Mercedes-Benz SL 500", 250, 6.3, 4966, 306, 8, 5600);
        car_card G3 = new car_card("g3", "Alfa Romeo Brera", 248, 6.3, 260, 3195, 6, 6200);
        car_card G4 = new car_card("g4", "Porsche Cayman S", 275, 5.4, 295, 3387, 6, 6250);
        car_card H1 = new car_card("h1", "BMW Z4", 250, 5.9, 2979, 231, 6, 5900);
        car_card H2 = new car_card("h2", "Alfa Romeo GT", 243, 6.7, 240, 3179, 6, 6400);
        car_card H3 = new car_card("h3", "Pontiac GTO", 280, 5.7, 5970, 400, 8, 5200);
        car_card H4 = new car_card("h4", "BMW M5", 250, 4.7, 4999, 507, 10, 7750);

        deck d;

        hand h1 = new hand();
        hand h2 = new hand();
        hand h3 = new hand();
        hand h4 = new hand();
        public Form1()
        {
            InitializeComponent();
        }

       private void showcard1(car_card c)
        {
            if (c == null)
            {
                pictureBox1.Image = null;
                nametb1.Text = null;
                maxspeedtb1.Text = null;
                zerotosixtytb1.Text = null;
                hptb1.Text = null;
                cmtb1.Text = null;
                RPMTB1.Text = null;
                CYLENDERSTB1.Text = null;
            }

            pictureBox1.Load(c.id + ".jpg");
            nametb1.Text = c.name;
            maxspeedtb1.Text = c.maxSpeed.ToString();
            zerotosixtytb1.Text = c.zerotosixty.ToString();
            hptb1.Text = c.horsepower.ToString();
            cmtb1.Text = c.cubiccentimeters.ToString();
            RPMTB1.Text = c.rpm.ToString();
            CYLENDERSTB1.Text = c.cylinders.ToString();

            
        }

        private void showcard2(car_card c)
        {
           if (c == null)
            {
                pictureBox2.Image = null;
                name2.Text = null;
                topspeed2.Text = null;
                zerotosixty2.Text = null;
                hp2.Text = null;
                cc2.Text = null;
                rpm2.Text = null;
                cylenders2.Text = null;
            }
            
            pictureBox2.Load(c.id + ".jpg");
            name2.Text = c.name;
            topspeed2.Text = c.maxSpeed.ToString();
            zerotosixty2.Text = c.zerotosixty.ToString();
            hp2.Text = c.horsepower.ToString();
            cc2.Text = c.cubiccentimeters.ToString();
            rpm2.Text = c.rpm.ToString();
            cylenders2.Text = c.cylinders.ToString();

            
        }

        private void showcard3(car_card c)
        {
            if (c == null)
            {
                pictureBox3.Image = null;
                label14.Text = null;
                label13.Text = null;
                label12.Text = null;
                label11.Text = null;
                label10.Text = null;
                label8.Text = null;
                label9.Text = null;
            }
            
            pictureBox3.Load(c.id + ".jpg");
            label14.Text = c.name;
            label13.Text = c.maxSpeed.ToString();
            label12.Text = c.zerotosixty.ToString();
            label11.Text = c.horsepower.ToString();
            label10.Text = c.cubiccentimeters.ToString();
            label8.Text = c.rpm.ToString();
            label9.Text = c.cylinders.ToString();

            
        }

        private void showcard4(car_card c)
        {
          if (c == null)
            {
                pictureBox4.Image = null;
                label21.Text = null;
                label20.Text = null;
                label19.Text = null;
                label18.Text = null;
                label17.Text = null;
                label15.Text = null;
                label16.Text = null;
            }
            
            pictureBox4.Load(c.id + ".jpg");
            label21.Text = c.name;
            label20.Text = c.maxSpeed.ToString();
            label19.Text = c.zerotosixty.ToString();
            label18.Text = c.horsepower.ToString();
            label17.Text = c.cubiccentimeters.ToString();
            label15.Text = c.rpm.ToString();
            label16.Text = c.cylinders.ToString();
        }

        //public bool isEmpty()
        //{
        //    return car_card.count == 0; 
        //}
        
        private void Form1_Load(object sender, EventArgs e)
        {
            


            List<car_card> list = new List<car_card>();
            list.Add(A1);
            list.Add(A2);
            list.Add(A3);
            list.Add(A4);
            list.Add(B1);
            list.Add(B2);
            list.Add(B3);
            list.Add(B4);
            list.Add(C1);
            list.Add(C2);
            list.Add(C3);
            list.Add(C4);
            list.Add(D1);
            list.Add(D2);
            list.Add(D3);
            list.Add(D4);
            list.Add(E1);
            list.Add(E2);
            list.Add(E3);
            list.Add(E4);
            list.Add(F1);
            list.Add(F2);
            list.Add(F3);
            list.Add(F4);
            list.Add(G1);
            list.Add(G2);
            list.Add(G3);
            list.Add(G4);
            list.Add(H1);
            list.Add(H2);
            list.Add(H3);
            list.Add(H4);
            d = new deck(list);
            d.shuffle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showcard1(d.GetCard(0));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showcard2(d.GetCard(0));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            showcard3(d.GetCard(0));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showcard4(d.GetCard(0));
        }

        private void dealbutton_Click(object sender, EventArgs e)
        {
            //shuffle deck
            d.shuffle();

            //deal cards
           // while (d.)
            h1.add(d.GetCard(0));
            h2.add(d.GetCard(0));
            h3.add(d.GetCard(0));
            h4.add(d.GetCard(0));
        }
    }
}
