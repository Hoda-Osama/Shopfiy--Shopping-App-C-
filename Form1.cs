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
   
    public partial class Form1 : Form
    {
      
        int id;
        public Form1(int i)
        {
            InitializeComponent();
            id = i;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox3.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox4.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.Text = ("Samsun \n 70 - Inch Full HD Monitor Black\n Model Number: LC24RG50FQNXZA \n rated 4.4 \n PRICE: 33665");
            richTextBox4.Text = ("Canon\n MG2540S Pixma Multifunction All-In-One Printer Black\n Model Number: MG2540S\n PRICE 616");
            richTextBox3.Text = ("DeFacto\n Three Quarter Sleeves Shirt White \n Model Number: I5280AZ \n PRICE 296");
            richTextBox2.Text = ("Tornado\n Silent Action Ceiling Fan TCF56BW White\n Model Number: TCF56BW\n PRICE 500");



         }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(0);
            f7.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(id);
            f8.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(id);
            f7.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(id);
            f7.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(id);
            f7.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(id);
            f7.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
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
