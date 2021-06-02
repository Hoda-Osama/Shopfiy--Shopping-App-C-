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
    public partial class UserControl1 : UserControl
    {
        List<Elec> p = new List<Elec>();
        List<Product> pro = new List<Product>();
        public UserControl1()
        {
            InitializeComponent();
            load();
            Elec.initialize(p);
            showlist();
        }
        public void load()
        {

            p = Elec.P;
            pro = Order.P;
        }
        private void showlist()
        {
            richTextBox1.AppendText(p[0].ToString());
            richTextBox2.AppendText(p[1].ToString());
            richTextBox3.AppendText(p[2].ToString());

        }

            private void button1_Click(object sender, EventArgs e)
        {
            Order.add(pro, p[0]);
            Elec.editstock(p, 1);
            MessageBox.Show("Item added to Cart");
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order.add(pro, p[1]);
            Elec.editstock(p, 2);
            MessageBox.Show("Item added to Cart");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order.add(pro, p[2]);
            Elec.editstock(p, 3);
            MessageBox.Show("Item added to Cart");
        }
    }
}
