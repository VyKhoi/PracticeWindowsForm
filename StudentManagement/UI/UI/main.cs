using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;
using System.IO;
namespace UI
{
    public partial class main : Form
    {
     
        StudentManagement list = new StudentManagement();

        public static string userName;

        // image list


        public main()
        {
            InitializeComponent();
           
            labelUserNam.Text = userName;
        }
        public main(string s):this()
        {
            labelUserNam.Text = userName;
        }
            
            

        void LoadListView()
        {
            listStudent.View = View.Details;

            //cach 1
            ColumnHeader a = new ColumnHeader();
            a.Text = "Họ và tên";
            a.Width = (int)(listStudent.Width * 0.4);
            a.TextAlign = HorizontalAlignment.Center;
            listStudent.Columns.Add(a);

            // cach 2
            //ColumnHeader b = new ColumnHeader() {Text = "Tuổi",Width = (int)(listView1.Width * 0.2),
            //    TextAlign = HorizontalAlignment.Center };
            //cach 3
            listStudent.Columns.Add("Ngày sinh", (int)(listStudent.Width * 0.2), HorizontalAlignment.Center);

            //listView1.Columns.Add(b);
            listStudent.Columns.Add("Giới tính", (int)(listStudent.Width * 0.2), HorizontalAlignment.Center);


        }

        private void label4_Click(object sender, EventArgs e)
        {

            // MessageBox.Show(list.GetIndex(0).Name);
        }
        private void LoadDataPersons()
        {
            list.ReadFilePerson(Application.StartupPath +"\\Resources\\"+"haha.txt"); // lay dc file sv\\
            for (int i = 0; i < list.List.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = list.GetIndex(i).Name;

                item.SubItems.Add(list.GetIndex(i).BirthDay.ToString("dd/MM/yyyy"));
                item.SubItems.Add(list.GetIndex(i).Sex.ToString());
                if(list.GetIndex(i).Sex.ToString()== "Nam")
                {
                    item.ImageIndex = 0;
                }
                else
                {
                    item.ImageIndex = 1;
                   
                }

                listStudent.Items.Add(item);
                // MessageBox.Show(list.GetIndex(i).Name);
            }

           }
        private void ReLoadDataPersons()
        {
            listStudent.Items.Clear();
           // list.ReadFilePerson(Application.StartupPath + "\\Resources\\" + "haha.txt"); // lay dc file sv\\
            for (int i = 0; i < list.List.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                // tao 1 item lítview
                item.Text = list.GetIndex(i).Name;
                item.SubItems.Add(list.GetIndex(i).BirthDay.ToString("dd/MM/yyyy"));
                item.SubItems.Add(list.GetIndex(i).Sex.ToString());
                if (list.GetIndex(i).Sex.ToString() == "Nam")
                {
                    item.ImageIndex = 0;
                }
                else
                {
                    item.ImageIndex = 1;

                }

                listStudent.Items.Add(item);
                // MessageBox.Show(list.GetIndex(i).Name);
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInputPeson())
                {
                    Person tmp = GetPersonFromFrom();
                    list.AddPerson(tmp);
                    AddPersonToListView(listStudent,tmp );
                }
                else
                {
                    throw new Exception("chua nhap ten");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


        }
        private Person GetPersonFromFrom()
        {
            Person a = new Person();
            a.Name = name.Text;
            var checkedButton = radSex.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            a.Sex = checkedButton.Text;
            a.BirthDay = birthDay.Value;
            return a;
        }
        private void AddPersonToListView(ListView lv,Person p)
        {
            ListViewItem item = new ListViewItem();
            item.Text = p.Name;

            item.SubItems.Add(p.BirthDay.ToString("dd/MM/yyyy"));
            item.SubItems.Add(p.Sex);
            if(p.Sex.ToString() == "Nam")
            {
                item.ImageIndex = 0;
            }else
            {
                item.ImageIndex = 1;

            }
            lv.Items.Add(item);
                  
        }
        private bool CheckInputPeson()
        {
            if (name.Text == "")
            {
                return false;
            }else
            {
                return true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(int item in listStudent.SelectedIndices)
            {
                listStudent.Items.RemoveAt(item);
                list.RemovePerson(item);
             //   MessageBox.Show(item.ToString());
             //   list.List.re
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                list.WriteFilePerson(Application.StartupPath + "\\Resources\\" + "haha.txt");
                MessageBox.Show("Luu Thanh cong");         
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void main_Load(object sender, EventArgs e)
        {
            this.Hide();
            loadSmallImmageSex();
            LoadListView();
            LoadDataPersons();
            
        }
      

        private void loadSmallImmageSex()
        {
            ImageList a = new ImageList();
            a.Images.AddRange(new Bitmap[] {new Bitmap(Application.StartupPath + "\\Resources\\" + "1.png"),
                    new Bitmap(Application.StartupPath + "\\Resources\\" + "2.png")}
                        );
            listStudent.SmallImageList = a;
        }
        private void button4_Click(object sender, EventArgs e)
        {
       
        SaveFileDialog saveAs = new SaveFileDialog();
        saveAs.Filter ="Text File(*.txt)|*.txt";
            if(saveAs.ShowDialog() == DialogResult.OK)
            {
                list.WriteFilePerson(saveAs.FileName);
            }
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("co muon thoat", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1.login.Close();

            }
            else
            {
                e.Cancel = true;
            }
           

        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {

        

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //
            string name = searchName.Text;
            StudentManagement foundStudent =  new StudentManagement( list.SearchPersons(name));

            //foreach (var i in foundStudent.List)
            //{
            //    MessageBox.Show(i.Name);
            //}

            listStudent.Items.Clear();


            for (int i = 0; i < foundStudent.List.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = foundStudent.GetIndex(i).Name;

                item.SubItems.Add(foundStudent.GetIndex(i).BirthDay.ToString("dd/MM/yyyy"));
                item.SubItems.Add(foundStudent.GetIndex(i).Sex.ToString());
                if (foundStudent.GetIndex(i).Sex.ToString() == "Nam")
                {
                    item.ImageIndex = 0;
                }
                else
                {
                    item.ImageIndex = 1;

                }

                listStudent.Items.Add(item);
                // MessageBox.Show(list.GetIndex(i).Name);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReLoadDataPersons();
        }
    }
}
