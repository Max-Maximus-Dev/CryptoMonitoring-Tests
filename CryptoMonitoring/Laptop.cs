using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoMonitoring
{
    public partial class Laptop : Form
    {

        bool isLaptopOpen = false;
        public Laptop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 424; 260 - початковий розмір
            // 192; 167 - початкова позиція
            // button2 - початковий розмір ( 52; 52 ), позиція ( 210; 185 );
            // настпуна розмір ( 77; 77 ), позиція ( 45; 40 );
            // button3 - початковий розмір ( 52; 52 ), позиція ( 281; 185 );
            // настпуна розмір ( 77; 77 ), позиція ( 165; 40 );
            // button4 - початковий розмір ( 52; 52 ), позиція ( 351; 185 );
            // настпуна розмір ( 77; 77 ), позиція ( 285; 40 );

            if (!isLaptopOpen)
            {
                button1.Dock = DockStyle.Fill;
                button2.Location = new Point(45, 40);
                button2.Size = new Size(77, 77);
                button3.Location = new Point(165, 40);
                button3.Size = new Size(77, 77);
                button4.Location = new Point(285, 40);
                button4.Size = new Size(77, 77);
                isLaptopOpen = true;
            }
            else
            {
                button1.Dock = DockStyle.None;
                button2.Location = new Point(210, 185);
                button2.Size = new Size(52, 52);
                button3.Location = new Point(281, 185);
                button3.Size = new Size(52, 52);
                button4.Location = new Point(351, 185);
                button4.Size = new Size(52, 52);
                isLaptopOpen = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            do
            {
                if (isLaptopOpen)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                }
                else
                {
                    button1.Dock = DockStyle.Fill;
                    button2.Location = new Point(45, 40);
                    button2.Size = new Size(77, 77);
                    button3.Location = new Point(165, 40);
                    button3.Size = new Size(77, 77);
                    button4.Location = new Point(285, 40);
                    button4.Size = new Size(77, 77);
                    isLaptopOpen = true;
                }
            } while (!isLaptopOpen);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            do
            {
                if (isLaptopOpen)
                {
                    AchiveMents achiveMents = new AchiveMents();
                    achiveMents.Show();
                }
                else
                {
                    button1.Dock = DockStyle.Fill;
                    button2.Location = new Point(45, 40);
                    button2.Size = new Size(77, 77);
                    button3.Location = new Point(165, 40);
                    button3.Size = new Size(77, 77);
                    button4.Location = new Point(285, 40);
                    button4.Size = new Size(77, 77);
                    isLaptopOpen = true;
                }
            } while (!isLaptopOpen);
        }

        private void Laptop_Load(object sender, EventArgs e)
        {

        }
    }
}
