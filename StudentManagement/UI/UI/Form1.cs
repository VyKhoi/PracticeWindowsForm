using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public static Form1 login;
       
        private string password = "admin";
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(inputPassword.Text.CompareTo(password) != 0)
            {
                checkPass.Text = "password or user name don't correct,please input again";
             //MessageBox.Show("oke");
            }else
            {
                main.userName = inputUserName.Text;
                login = this;
                this.Hide();
                main Ql = new main();
                Ql.Show();
             
            }

        }

        private void inputUserName_Click(object sender, EventArgs e)
        {
            checkPass.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime b = new DateTime();
            DateTime a = new DateTime(2002, 12, 18);
            MessageBox.Show(a.Day + " " + a.Month + "  " + a.Year);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.ExitThread();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
