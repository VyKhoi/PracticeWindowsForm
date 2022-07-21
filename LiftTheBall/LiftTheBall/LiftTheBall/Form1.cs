using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiftTheBall
{
    public partial class Form1 : Form
    {
        int x =5;
        int y = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if( pictureBox1.Top < 0 || pictureBox1.Bounds.IntersectsWith(label1.Bounds))
            {
                y = -y;
                //if(pictureBox1.Bottom == label1.Top)
                //{
                //    y = -y;
                //}

            }
            if (pictureBox1.Left < 0 || pictureBox1.Right > this.Width || pictureBox1.Bounds.IntersectsWith(label1.Bounds))
            {
                x = -x;
            }
            if(pictureBox1.Bottom > this.Height)
            {
                timer1.Enabled = false;
              //  timer1.Enabled = false;

                MessageBox.Show("you lose");
                this.Close();
               // Application.Exit();
            }
            pictureBox1.Top += y;
            pictureBox1.Left += x;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
           // if(e.Bu)
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            { 
                case Keys.Left:
                {
                        if (label1.Left > 0)
                        {
                            label1.Left -= 10;
                            
                        }
                    break;
                }
                case Keys.Right:
                    {
                        if (label1.Right < this.Width)
                        {
                            label1.Left += 10;
                        }
                        break;
                    }
            }
        }
    }
}
