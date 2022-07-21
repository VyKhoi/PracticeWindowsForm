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
    public partial class GuessDices : Form
    {
        private List<Dice> listDice = new List<Dice>(); // list dice
        private bool checkChoose = false; // check selected user
        private int valueChoose;
        private int randomValue;
        private int count = 0; // count how many time play;
        private int countWin = 0;// number of time win
        private int countLost = 0;//number of time lost
             
        public GuessDices()
        {
            InitializeComponent();
        }

        private void GuessDices_Load(object sender, EventArgs e)
        {
            loadDice();
        }
        void loadDice()
        {
            int num = 1;
            string[] Paths = Directory.GetFiles(Application.StartupPath + "\\Resources");

            // load dice
            foreach (string i in Paths)
            {
                Dice tmp = new Dice(i, num);
                listDice.Add(tmp);
                num++;
            }
        }

        private void Dice1_Click(object sender, EventArgs e)
        {
            // tiet lap gia tri
            Button tp = sender as Button;
            int i = Convert.ToInt32(tp.Text) - 1;
             DiceChoose.Image = listDice[i].Image;

            // set value
            checkChoose = true;
            valueChoose = i + 1;

            // thit lap mau sac
            // use var as it will have the received value type
            var listButton = groupBox1.Controls.OfType<Button>();
            foreach (Button button in listButton)
            {
                if (button == sender)
                {
                    button.BackColor = Color.Red;
                    button.ForeColor = Color.White;
                }
                else
                {
                    button.BackColor = Color.FromArgb(255, 192, 192);
                    button.ForeColor = Color.Black;
                }
            }
        }

        private void roll_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkChoose == false)
                {
                    throw new Exception("vui lòng chọn số");
                }
                RandomDice();
                returnResult();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }
        void RandomDice()
        {
            Random r = new Random();
            int i = r.Next(0, 6);
            DiceResult.Image = listDice[i].Image;
            randomValue = listDice[i].Value;
        }
        private void returnResult()
        {
            if(valueChoose == randomValue)
            {
                string re = String.Format("{0}.Thắng (Đoán {1} ra {2} )", count+1, valueChoose, randomValue); // the result of this game
                history.Items.Add(re);
                history.SetSelected((count), true);
                countWin++;
               
            }
            else
            {
                string re = String.Format("{0}.Thua (Đoán {1} ra {2} )", count+1, valueChoose, randomValue);
                history.Items.Add(re);
          
                history.SetSelected((count), true);
                countLost++;

            }
            count++;
            Statistical();
        }
        private void Statistical()
        {
            CountTheNumberOfGamesPlayed.Text ="Thống Kê :" + (count).ToString();

            string a = String.Format("Lần thắng :{0} ({1:0.00}%)", countWin, ((double)countWin  / (double)count));
            timesWin.Text = a;

            string b = String.Format("Lần thua :{0} ({1:0.00}%)", countLost, ((double)countLost/ (double)count));
            timesLost.Text = b;
        }

        private void reset_Click(object sender, EventArgs e)
        {
           DiceChoose.Image = null;
           DiceResult.Image = null;
            history.Items.Clear();
           count = 0; // count how many time play;
           countWin = 0;// number of time win
           countLost = 0;//number of time lost

            Statistical();

            //reset color button 
            var listButton = groupBox1.Controls.OfType<Button>();
            foreach (Button button in listButton)
            {
                
                    button.BackColor = Color.FromArgb(255, 192, 192);
                    button.ForeColor = Color.Black;
                
               
            }
        }

        private void GuessDices_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if(MessageBox.Show("Bạn có muốn thoát","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==
            //    DialogResult.Yes)
            //{
               

            //}
            //else
            //{
            //    e.Cancel = true;
            //}
                
        }

        private void GuessDices_FormClosed(object sender, FormClosedEventArgs e)
        {
            rollDice.rolldice.Show();
          //  this.Close();
        }
    }
}
