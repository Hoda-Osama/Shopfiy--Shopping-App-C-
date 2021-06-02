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
    public partial class UserControl3 : UserControl
    {
        List<Fashion> f = new List<Fashion>();
        List<Product> pro = new List<Product>();
        public UserControl3()
        {
            InitializeComponent();
            load();
            Fashion.initialize(f);
            showlist();
        }
        public void load()
        {
            f = Fashion.P;
            pro = Order.P;
        }
        private void showlist()
        {
            richTextBox1.AppendText(f[0].ToString());
            richTextBox2.AppendText(f[1].ToString());
            richTextBox3.AppendText(f[2].ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order.add(pro, f[0]);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Order.add(pro, f[0]);
            Fashion.editstock(f, 1);
            MessageBox.Show("Item added to Cart");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order.add(pro, f[1]);
            Fashion.editstock(f, 2);
            MessageBox.Show("Item added to Cart");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order.add(pro, f[2]);
            Fashion.editstock(f, 3);
            MessageBox.Show("Item added to Cart");
        }
    }
}
