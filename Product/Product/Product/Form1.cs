using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            product_group ResultP()
            {
                product_group p = product_group.bread;
                if (comboBox1.SelectedIndex == 0) p = product_group.bread;
                else if (comboBox1.SelectedIndex == 1) p = product_group.sweets;
                else if (comboBox1.SelectedIndex == 2) p = product_group.cans;
                else if (comboBox1.SelectedIndex == 3) p = product_group.dairy;
                else if (comboBox1.SelectedIndex == 4) p = product_group.meat;
                return p;
            }
            currency ResultC()
            {
                currency c = currency.amount;
                if (comboBox2.SelectedIndex == 0) c = currency.kg;
                else if (comboBox2.SelectedIndex == 1) c = currency.liters;
                else if (comboBox2.SelectedIndex == 2) c = currency.amount;
                return c;
            }

            Product product = new Product(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text),ResultP(),ResultC());
            products.Add(product);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Product x in products)
                listBox1.Items.Add(x.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Product x in products)
                listBox2.Items.Add(x.ProfitString());
        }
    }
}
