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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int count = 0;
        Point pOld;
        Random rand = new Random();
        string[] arrImage;
        int widthImage = 90;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadAllImages();
        }
        private void loadAllImages()
        {
            arrImage = Directory.GetFiles(Application.StartupPath + "\\Resources\\");
            addNewPicture();
        }
        private void addNewPicture()
        {
            count++;
            string path = arrImage[rand.Next(arrImage.Length)];
            Bitmap image = new Bitmap(path);
            PictureBox picture = new PictureBox();
            picture.Name = count.ToString();
            picture.Image = image;
            picture.Width = picture.Height = widthImage;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Location = new Point(0, 0);
            //su kien tren anh
            picture.MouseDown += Picture_MouseDown;
            picture.MouseMove += Picture_MouseMove;
            picture.MouseUp += Picture_MouseUp;

            this.Controls.Add(picture);
            this.Controls.SetChildIndex(pnBound, this.Controls.Count - 1);
        }

        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            PictureBox pic = sender as PictureBox;
            if (pnBound.Bounds.Contains(pic.Bounds))
            {
                pnBound.Controls.Add(pic);
                addNewPicture();
            }
        }

        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            // throw new NotImplementedException();
            if (e.Button == MouseButtons.Left)
            {
                //   MessageBox.Show("oke" + pOld.X.ToString());
                PictureBox pic = sender as PictureBox;
                int dx = e.X - pOld.X;
                int dy = e.Y - pOld.Y;
                pic.Left += dx;
                pic.Top += dy;

            }
        }

        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
            // throw new NotImplementedException();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //this.Controls.Find(count.ToString(), false);
            Control[] arrControls = this.Controls.Find(count.ToString(), false);
            PictureBox pic = arrControls[0] as PictureBox;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    {
                        if (pic.Left > 0) pic.Left -= 5;
                        break;
                    }
                case Keys.Right:
                    {
                        if (pic.Right < this.Width) pic.Left += 5;
                        break;
                    }
                case Keys.Up:
                    {
                        if (pic.Top > 0) pic.Top -= 5;
                        break;
                    }
                case Keys.Down:
                    {
                        if (pic.Top < this.Height) pic.Top += 5;
                        break;
                    }
            }
          //  PictureBox pic = sender as PictureBox;
            if (pnBound.Bounds.Contains(pic.Bounds))
            {
                pnBound.Controls.Add(pic);
                addNewPicture();
            }
        }

        private void pnBound_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void pnBound_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //   MessageBox.Show("oke" + pOld.X.ToString());
                FlowLayoutPanel pic = sender as FlowLayoutPanel;
                int dx = e.X - pOld.X;
                int dy = e.Y - pOld.Y;
                pic.Left += dx;
                pic.Top += dy;

            }
        }
    }
}
