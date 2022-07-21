using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        string math = "";
        double data1, data2;

        int tmpLength;
        public Form1()
        {
            InitializeComponent();
        }



        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button a = sender as Button;
            form.Text += a.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                Button a = sender as Button;
                data1 = Convert.ToDouble(form.Text);

                form.Text += a.Text;
                math = a.Text;
                tmpLength = (int)form.Text.Length;
            }catch(FormatException)
            {
                MessageBox.Show("pls input correct type", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void del_Click(object sender, EventArgs e)
        {
            form.Clear();
        }

        private void re_Click(object sender, EventArgs e)
        {
            form.Text = form.Text.Substring(0, form.Text.Length - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(tmpLength.ToString());
            data2 = Convert.ToDouble(form.Text.Substring(tmpLength));
            form.Text += "=";
        //    MessageBox.Show(data2.ToString());
            
             switch(math)
            {
                case "+":
                    {
                        form.Text += (data1 + data2).ToString();
                        break;
                    }
                case "-":
                    {
                        form.Text += (data1 - data2).ToString();
                        break;
                    }
                case "x":
                    {
                        form.Text += (data1 * data2).ToString();
                        break;
                    }
                case "/":
                    {
                        try
                        {
                            if(data2 == 0)
                                throw new Exception("Loi chia cho 0");
                            form.Text += (data1 / data2).ToString();
                        }catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    }
            }
        }
    }
}
