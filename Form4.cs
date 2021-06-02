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
    public partial class Form4 : Form
    {
        List<User> user = new List<User>();
        int id;
        public Form4(int i)
        {
            InitializeComponent();
            id = i;
            load();
            richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            showlist();
            
        }
        private void showlist()
        {
            User x = new User();
            x = User.user(user, id);
            richTextBox2.AppendText("User name: " + x.Name +"\n" + "User id: "+ x.Id +"\n" + "User address: "+ x.Address +"\n" +" User email: "+ x.Email +"\n"+ " User phone: "+x.Phone);
            
        }
        public void load()
        {
            user = User.Us;
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(id);
            this.Hide();
            f8.Show();
        }

      

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(id);
            f7.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(id);
            f8.Show();
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(id);
            f1.Show();
            this.Hide();
        }
    }
}
