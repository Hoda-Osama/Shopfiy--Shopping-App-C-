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
    public partial class Form2 : Form
    {
        List<User> user = new List<User>();
        public Form2()
        {
            InitializeComponent();
            load();
            User.initialize(user);
        }
        public void load()
        {
            user = User.Us;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(0);
            f1.Show();
            this.Hide();
        }
    }
}
