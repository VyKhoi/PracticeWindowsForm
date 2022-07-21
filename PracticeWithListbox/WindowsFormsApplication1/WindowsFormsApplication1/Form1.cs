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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(inputItem.Text);
            inputItem.Text = "";
        }

        private void LToR_Click(object sender, EventArgs e)
        {
            foreach(var i in listBox1.SelectedItems)
            {
                listBox2.Items.Add(i);
            }
            for (int i = listBox1.SelectedIndices.Count-1; i >= 0; i--)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }
            //foreach (var k in listBox1.SelectedItems)
            //{
            //    listBox1.Items.Remove(k);
            //}
        }

        private void RToL_Click(object sender, EventArgs e)
        {
            foreach (var i in listBox2.SelectedItems)
            {
                listBox1.Items.Add(i);
            }
            for (int i = listBox2.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
          for(int i =  listBox1.SelectedIndices.Count -1; i >=0; i--)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }
            for (int i = listBox2.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ColorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Color a = new Color();

            listBox2.BackColor = Color.FromName(ColorList.SelectedItem.ToString());
            listBox2.ForeColor = Color.White;
        }
    }
}
