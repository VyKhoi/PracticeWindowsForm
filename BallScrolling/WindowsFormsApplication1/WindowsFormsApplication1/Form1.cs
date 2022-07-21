using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
              timer1.Enabled = true;

        }
        int x = 10;
        int y = 10;
        private void button1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            if (axWindowsMediaPlayer1.Bottom > this.Height || axWindowsMediaPlayer1.Top < 0)
            {
                x = -x;     
            }
           if(axWindowsMediaPlayer1.Right > this.Width || axWindowsMediaPlayer1.Left < 0)
            {
                y = -y;
            }

            axWindowsMediaPlayer1.Top += x;
            axWindowsMediaPlayer1.Left += y;
            //axWindowsMediaPlayer1.Location = new Point(x+5, y+5);

            if(axWindowsMediaPlayer1.Location.X > 270 && axWindowsMediaPlayer1.Location.X < 320 &&
                axWindowsMediaPlayer1.Location.Y > 318 && axWindowsMediaPlayer1.Location.Y < 340 )
            {
                timer1.Enabled = false;
                MessageBox.Show("zeke đã bắt đc đầu ển","Ôi Không!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            //284,318 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show(axWindowsMediaPlayer1.Location.X.ToString() + "   " + axWindowsMediaPlayer1.Location.Y.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          ///  MessageBox.Show(Application.StartupPath + "eren.mp4");
            axWindowsMediaPlayer1.URL = Application.StartupPath + "\\erren.webm";
        }
    }
}
