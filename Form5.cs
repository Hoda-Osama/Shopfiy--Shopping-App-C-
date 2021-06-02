using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoda_17100682_FinalProject
{
    public partial class Form5 : Form
    {
        Admin[] a;
        int id;
        int pass;
        public Form5()
        {
            InitializeComponent();
            a = new Admin[2];
            Admin a0 = new Admin(1, 123, "Ahmed");
            Admin a1 = new Admin(2, 123, "Mohaned");
            a[0] = a0;
            a[1] = a1;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(textBox3.Text);
            pass = Convert.ToInt32(textBox1.Text);
            if ((Admin.isadmin(a, id, pass) == 1))
            {
                Form6 f6 = new Form6();
                f6.Show();
               this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username and password, please re-enter");
                textBox1.Clear();
                textBox1.Clear();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(0);
            f1.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(0);
            f7.Show();
            this.Hide();
        }

        

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(0);
            f8.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(0);
            f1.Show();
            this.Hide();
        }
    }
}
