using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Drawing.Text;

namespace Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        
        private void Form1_Load(object sender, EventArgs e)
        {
           // get full name font fami
            InstalledFontCollection col = new InstalledFontCollection();
            foreach (FontFamily fa in col.Families)
            {
                listBox1.Items.Add(fa.Name);
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new 
                Font(listBox1.SelectedItem.ToString(), float.Parse(sizeFont.Text));
         
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if  (richTextBox1.SelectionFont.Bold == false)
            {
                richTextBox1.SelectionFont = new Font("",
                    richTextBox1.SelectionFont.Size, FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font("",
                  richTextBox1.SelectionFont.Size, FontStyle.Regular);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Italic == false)
            {
                richTextBox1.SelectionFont = new Font("",
                    richTextBox1.SelectionFont.Size, FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font("",
                  richTextBox1.SelectionFont.Size, FontStyle.Regular);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Underline == false)
            {
                richTextBox1.SelectionFont = new Font("",
                    richTextBox1.SelectionFont.Size, FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font("",
                  richTextBox1.SelectionFont.Size, FontStyle.Regular);
            }
        }

        private void red_Scroll(object sender, ScrollEventArgs e)
        {
            Color a = Color.FromArgb(red.Value, green.Value, blue.Value);
            mixValueColor.BackColor = a;
            richTextBox1.SelectionColor = a;
        }
    }
}
