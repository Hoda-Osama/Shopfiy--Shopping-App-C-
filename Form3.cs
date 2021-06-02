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
    public partial class Form3 : Form
    {

        int id;
        int pass;
        List<User> user = new List<User>(); 
        public Form3()
        {
            InitializeComponent();
            load();
            User.initialize(user);

        }
        public void load()
        {
            user = User.Us;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(textBox4.Text);
            pass = Convert.ToInt32(textBox3.Text);
            if ((User.isuser(user, id, pass) == 1))
            {
                Form4 f4 = new Form4(id);
                Form8 f8 = new Form8(id);
                Form1 f1 = new Form1(id);

                f4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username and password, please re-enter");
                textBox4.Clear();
                textBox3.Clear();

            }
        }

        

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(id);
            f7.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(id);
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

