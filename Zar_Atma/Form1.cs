using System;
using System.Windows.Forms;

namespace Zar_Atma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 7);
            label1.Text = a.ToString();

            switch (a)
            {
                case 1: pictureBox1.Image = Properties.Resources._1; break;
                case 2: pictureBox1.Image = Properties.Resources._2; break;
                case 3: pictureBox1.Image = Properties.Resources._3; break;
                case 4: pictureBox1.Image = Properties.Resources._4; break;
                case 5: pictureBox1.Image = Properties.Resources._5; break;
                case 6: pictureBox1.Image = Properties.Resources._6; break;
            }

            //if (1 == a) pictureBox1.Image = Properties.Resources._1;
            //else if (2 == a) pictureBox1.Image = Properties.Resources._2;
            //else if (3 == a) pictureBox1.Image = Properties.Resources._3;
            //else if (4 == a) pictureBox1.Image = Properties.Resources._4;
            //else if (5 == a) pictureBox1.Image = Properties.Resources._5;
            //else if (6 == a) pictureBox1.Image = Properties.Resources._6;
        }

    }
}
