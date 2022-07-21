using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (s1.Text.Length > Convert.ToInt16(indexS1.Text))
            {
                s1.Text = s1.Text.Insert(Convert.ToInt16(indexS1.Text), s2.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left < panel1.Width)
            {
                label1.Left += 5;
            }
            else
            {
                label1.Left = -250;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(s1.Text.Contains(s2.Text))
            {
                s1.Text =  s1.Text.Replace(s2.Text, s3.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] CharStr = s1.Text.ToArray();
            Array.Reverse(CharStr);

            s1.Text = new string(CharStr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (s1.Text.Contains(s2.Text))
            {
                s1.Text = s1.Text.Remove(s1.Text.IndexOf(s2.Text), s2.Text.Length);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "";
            string[] arrStr = s1.Text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
                //Split(new char[] { ' ', ',', '.' });
            foreach(string i in arrStr)
            {
                //i.Trim();
                str += i + " ";
               // MessageBox.Show(i);
            }
            s1.Text = str;
        }

        private void indexS1_KeyDown(object sender, KeyEventArgs e)
        {
        
        }

        private void indexS1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( !char.IsDigit( e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
