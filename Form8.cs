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
    public partial class Form8 : Form
    {
        List<Product> pro = new List<Product>();
        List<User> user = new List<User>();
        int id;
        public Form8(int i)
        {
            InitializeComponent();
            id = i;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            load();
            show();
            showlist(id);
        }
        private void show()
        {
            if (Order.isempty(pro) == true)
            {
                richTextBox1.Text = (" No Items Added!");
            }
            else
            {
                int i = 1;
                foreach (Product x in pro)
                {

                    richTextBox1.AppendText("Item ( " + i + ")" + "\n \n" + x + "\n \n");
                    i += 1;
                }
            }
        }
        public void load()
        {
            pro = Order.P;
            user = User.Us;
        }
        private void showlist(int i)
        {
            if (i == 0)
            {
                textBox1.Text = ("");
                textBox2.Text = ("");
                textBox3.Text = ("");
                textBox5.Text = ("");
                textBox4.Text = ("");
            }
            else
            {
                User x = new User();
                x = User.user(user, id);
                textBox1.Text = (x.Name);
                textBox2.Text = (x.Address);
                textBox3.Text = (x.Phone);
                textBox5.Text = (Convert.ToString(Order.count(pro)));
                textBox4.Text = (Convert.ToString(Order.total(pro)));
            }
        }

      

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ordered Confirmed!");
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(id);
            f7.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 f2= new Form2();
            this.Hide();
            f2.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(id);
            f8.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(id);
            f1.Show();
            this.Hide();
        }
    }
}
