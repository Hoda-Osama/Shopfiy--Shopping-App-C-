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
    public partial class Form9 : Form
    {
        List<User> user = new List<User>();
        int x;
        public Form9()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            load();
            x = User.generateid(user);
            textBox1.Text = Convert.ToString(x);
        }
        public void load()
        {
            user = User.Us;
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            int pass = Convert.ToInt32(textBox3.Text);
            string stat = textBox4.Text;
            string address = textBox6.Text;
            string phone= textBox5.Text;
            string email= textBox7.Text;
            User nuser = new User(x, name, pass, stat, phone, address, email);
            User.adduser(user, nuser);
            MessageBox.Show(nuser.ToString());
            Form4 f4 = new Form4(x);
            this.Hide();
            f4.Show();
        }

        

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(x);
            f7.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(x);
            f8.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(x);
            f1.Show();
            this.Hide();
        }
    }
}
