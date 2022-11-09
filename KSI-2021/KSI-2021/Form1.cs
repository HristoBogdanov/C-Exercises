using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSI_2021
{
    public partial class Form1 : Form
    {
        List<Item> items = new List<Item>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item item = new Item(int.Parse(textBox1.Text), textBox2.Text, double.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text));
            items.Add(item);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var items_sorted = items.OrderBy(x => x.Name);
            foreach (Item x in items_sorted) listBox1.Items.Add(x.Print());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Item> items_type = new List<Item>();
            int wanted_type = int.Parse(textBox6.Text);
            foreach (Item x in items)
            {
                if (x.Type == wanted_type) items_type.Add(x);
            }
            var items_sort_type = items_type.OrderBy(x => x.Total_price());

            foreach (Item x in items_sort_type) listBox1.Items.Add($"{x.Print()} -- {x.Total_price()}лв.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            void Sum(List<Item>items_sum,double sum_total)
            {
                foreach (Item x in items_sum) sum = sum + x.Price;
            }

            List<Item> items_4 = new List<Item>();
            foreach (Item x in items) if (x.Type == 4) items_4.Add(x);

            if (items_4.Count == 0) MessageBox.Show("Няма артикули от този тип.");
            else
            {
                Sum(items_4, 0);
                 listBox1.Items.Add($"Средна единична цена: {sum_total}")
            }
        }
    }
}
