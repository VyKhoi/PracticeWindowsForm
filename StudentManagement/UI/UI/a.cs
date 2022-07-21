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
    public partial class a : Form
    {
        public static a formA ;
        public a()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formA = this;
            this.Hide();
            b formB = new b();
            formB.Show();

        }
    }
}
