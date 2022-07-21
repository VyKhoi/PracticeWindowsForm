using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_three_dice
{
    public partial class rollDice : Form
    {
        List<Dice> listDice = new List<Dice>(); // list dice
        int dx = 5;
        public rollDice()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (namePerson.Left > this.Width)
            {
                namePerson.Left = -namePerson.Width;
            }
                namePerson.Left += dx; 
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDice();
            loadForm();
        }
        private void loadDice()
        {
            // full duong dan
            int num = 1;
            string[] Paths = Directory.GetFiles(Application.StartupPath + "\\Resources");
        
            // load dice
            foreach (string i in Paths)
            {
                Dice tmp = new Dice(i, num);
                listDice.Add(tmp);
                num++;
            }

            //foreach(Dice tmp in listDice)
            //{
            //    MessageBox.Show(tmp.GetPathImage() + "  " + tmp.Value.ToString());
            //}

        }
        void loadForm()
        {
            Random ran = new Random();
            int a = ran.Next(0, 6);
            int b = ran.Next(0, 6);
            int c = ran.Next(0, 6);

            dice1.Image = listDice[a].Image;
            dice2.Image = listDice[b].Image;
            dice3.Image = listDice[c].Image;


            result.Text = (listDice[a].Value + listDice[b].Value + listDice[c].Value).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm();
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         DialogResult r =   MessageBox.Show("do you want to leave?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
               // MessageBox.Show("oke");
                this.Close();
            }
            else
            {
                return;
            }
        }


        public static rollDice rolldice; //a  form
        private void button3_Click(object sender, EventArgs e)
        {
            rolldice = this;
            rolldice.Hide();
            GuessDices f = new GuessDices();
            f.Show();
            //f.Show(); 

        }
    }
}
