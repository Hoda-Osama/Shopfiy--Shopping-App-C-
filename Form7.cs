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
    public partial class Form7 : Form
    {
        int id;
        public Form7(int i)
        {
            InitializeComponent();
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            id = i;
            
        }
                               
        private void label1_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl11.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            userControl31.Hide();
            userControl11.Hide();
            userControl21.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            userControl31.Hide();
            userControl21.Hide();
            userControl31.Show();

        }     

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(id);
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
