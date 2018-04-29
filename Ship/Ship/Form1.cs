using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ship
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pictureBox1.Location.X>0 && pictureBox1.Location.X <= 500)
            {

                pictureBox1.Left += 5;

            }
            else if(pictureBox1.Location.Y>0 && pictureBox1.Location.Y <= 300)
            {
                pictureBox1.Top += 5;

                Image img = pictureBox1.Image;
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = img;
            }
            else if(!(pictureBox1.Location.X> -500 && pictureBox1.Location.X <= 0))
            {
                //pictureBox1.Left += -40;
            }

        }
    }
}


    

