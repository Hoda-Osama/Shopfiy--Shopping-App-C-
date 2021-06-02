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
    public partial class Form6 : Form
    {
        List<Elec> p = new List<Elec>();
        List<Home> h = new List<Home>();
        List<Fashion> f = new List<Fashion>();
        int pid;
        string tittle;
        string description;
        int price;
        int instock;
        string supplier;
        public Form6()
        {
            InitializeComponent();
            load();
            Elec.initialize(p);
            Home.initialize(h);
            Fashion.initialize(f);
            groupBox2.Hide();
        }
        public void load()
        {
            f = Fashion.P;
            p = Elec.P;
            h = Home.P;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pid = Convert.ToInt32(textBox1.Text);
            Fashion x = new Fashion();
            Home y = new Home();
            Elec z = new Elec();
            if (Fashion.bsearch(f, pid) == false || Home.bsearch(h, pid) == false || Elec.bsearch(p, pid) == false)
            {
                MessageBox.Show("Invalid Id!");

            }
            else
            {
                if (checkBox1.Checked)
                {
                    x = Fashion.search(f, pid);
                    groupBox2.Show();
                    textBox2.Text = x.Tittle;
                    textBox6.Text = x.Description;
                    textBox5.Text = Convert.ToString(x.Price);
                    textBox3.Text = Convert.ToString(x.Instocks);
                    textBox4.Text = x.Designer;

                }
                else if (checkBox2.Checked)
                {
                    y = Home.search(h, pid);
                    groupBox2.Show();
                    textBox2.Text = y.Tittle;
                    textBox6.Text = y.Description;
                    textBox5.Text = Convert.ToString(y.Price);
                    textBox3.Text = Convert.ToString(y.Instocks);
                    textBox4.Text = y.Supplier;
                }
                else
                {
                    z = Elec.search(p, pid);
                    groupBox2.Show();
                    textBox2.Text = z.Tittle;
                    textBox6.Text = z.Description;
                    textBox5.Text = Convert.ToString(z.Price);
                    textBox3.Text = Convert.ToString(z.Instocks);
                    textBox4.Text = z.Supplier;
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            tittle = textBox2.Text;
            description = textBox6.Text;
            price = Convert.ToInt32(textBox5.Text);
            instock = Convert.ToInt32(textBox3.Text);
            supplier = textBox4.Text;
            pid = Convert.ToInt32(textBox1.Text);
            Fashion x = new Fashion();
            Home y = new Home();
            Elec z = new Elec();
            if (checkBox1.Checked)
            {
                x = Fashion.search(f, pid);
                x.Tittle = tittle;
                x.Description = description;
                x.Price = price;
                x.Instocks = instock;
                x.Designer = supplier;

            }
            else if (checkBox2.Checked)
            {
                y = Home.search(h, pid);
                y.Tittle = tittle;
                y.Description = description;
                y.Price = price;
                y.Instocks = instock;
                y.Supplier = supplier;
            }
            else
            {
                z = Elec.search(p, pid);
                z.Tittle = tittle;
                z.Description = description;
                z.Price = price;
                z.Instocks = instock;
                z.Supplier = supplier;
            }
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(0);
            f7.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(0);
            f1.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(0);
            f7.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
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

