using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<int> arr = new List<int>();
        List<int> ArrIncrease;
        List<int> ArrReduce;
        List<int> ArrRevert;
        List<int> arrEO;
        bool kt = false;

        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(sizeArr.Text) > 0)
                {
                    createRandomArrayInt(arr);
                    addArrayInTextBox(arr, originArr);
                    kt = true;
                }
            }catch(FormatException)
            {
                MessageBox.Show("vui lòng nhập đúng số");
            }
           
        }
        private void createRandomArrayInt(List<int> arr)
        {           
            Random rand = new Random();
            for(int i = 0; i< Convert.ToInt16(sizeArr.Text); i++)
            {
                arr.Add(rand.Next(100));        
            }
            ArrIncrease = new List<int>(arr);
            ArrReduce = new List<int>(arr);
            ArrRevert = new List<int>(arr);
            arrEO = new List<int>(arr);
        }
        private void SortIncreaseArray(List<int> arr)
        {
            arr.Sort();
        }
        private void SortReduceArray(List<int> arr)
        {
            arr.Sort((s1, s2) =>
            {
                if (s1 > s2)
                    return -1;
                else
                    return 1;

            });
        }
        private void RevertArray(List<int> arr)
        {
            arr.Reverse();
        }
        private void addArrayInTextBox(List<int>  arr, TextBox t)
        {
            foreach(int i in arr)
            {
                t.Text += i.ToString() + ',';
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ArrevenIncreaseOddDecrease(ref List<int> arr)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            foreach(int i in arr)
            {
                if(i % 2 == 0)
                {
                    even.Add(i);
                }else
                {
                    odd.Add(i);
                }

            }
            SortIncreaseArray(even);
            SortReduceArray(odd);
            even.AddRange(odd);
            arr = even;//even + odd;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (kt == true)
            {
                // mang tang
                SortIncreaseArray(ArrIncrease);
                addArrayInTextBox(ArrIncrease, ArrayIncrease);
                // mang giaam
                SortReduceArray(ArrReduce);
                addArrayInTextBox(ArrReduce, ArrayReduce);
                // mang dao
                RevertArray(ArrRevert);
                addArrayInTextBox(ArrRevert, ArrayRevert);
                // mang chan tang le giam
                ArrevenIncreaseOddDecrease(ref arrEO);
                addArrayInTextBox(arrEO, EO);
            }else
            {
                MessageBox.Show("vui lòng tạo mảng");
            }
        }
    }
}
