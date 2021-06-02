using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoda_17100682_FinalProject
{
    public partial class UserControl2 : UserControl
    {
        List<Home> h = new List<Home>();
        List<Product> pro = new List<Product>();
        public UserControl2()
        {
            InitializeComponent();
            load();
            Home.initialize(h);
            showlist();
        }
        public void load()
        {
            h = Home.P;
            pro = Order.P;
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
        private void showlist()
        {
            richTextBox1.AppendText(h[0].ToString());
            richTextBox2.AppendText(h[1].ToString());
            richTextBox3.AppendText(h[2].ToString());

        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            Order.add(pro, h[0]);
            Home.editstock(h,1);
            MessageBox.Show("Item added to Cart");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order.add(pro, h[1]);
            Home.editstock(h, 2);
            MessageBox.Show("Item added to Cart");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order.add(pro, h[2]);
            Home.editstock(h, 3);
            MessageBox.Show("Item added to Cart");
        }
    }
}
