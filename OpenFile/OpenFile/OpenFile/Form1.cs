using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFile
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void ChoseFile_Click(object sender, EventArgs e)
        {
           
            file.ShowDialog();
            ShowFile.Items.Add(file.FileName);
        }

        private void chooseFiles_Click(object sender, EventArgs e)
        {
          
            files.ShowDialog();
            //  MessageBox.Show(files.)
            foreach (string i in files.FileNames)
            {
                MessageBox.Show(i);
                ShowFile.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chooseFolder.ShowDialog();
            ShowFile.Items.Add(chooseFolder.SelectedPath);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chooseColor.ShowDialog();
            ShowFile.BackColor = chooseColor.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chooseColor.ShowDialog();
            ShowFile.ForeColor = chooseColor.Color;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chooseFont.ShowDialog();
            ShowFile.Font = chooseFont.Font;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            ShowFile.Items.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("con muonn thoat","exit",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
