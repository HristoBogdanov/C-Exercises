using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSI___2015_2
{
    public partial class Form1 : Form
    {
        List<Deal> deals = new List<Deal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            int N = int.Parse(textBox6.Text);
            if (N > 5000) throw new ArgumentException("Надвишен брой сделки!");
            else 
            {
                int year = int.Parse(string.Join("", input[0], input[1], input[2], input[3]));
                int month= int.Parse(string.Join("", input[4], input[5]));
                int day= int.Parse(string.Join("", input[6], input[7]));
                int hour= int.Parse(string.Join("", input[8], input[9]));
                int minutes = int.Parse(string.Join("", input[10], input[11]));
                int code = int.Parse(textBox2.Text);
                int quality = int.Parse(textBox3.Text);
                int quantity = int.Parse(textBox4.Text);
                string name_worker = textBox5.Text;

                Deal deal = new Deal(year, month, day, hour, minutes, code, quality, quantity, name_worker);
                deals.Add(deal);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Deal x in deals) listBox1.Items.Add(x.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sorted_deals_2 = deals.OrderBy(x => x.Quality).ThenByDescending(x => x.Quantity);

            foreach (Deal x in sorted_deals_2) listBox1.Items.Add(x.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] Kilos = new int[6];

            for (int i = 0; i < 6; i++)
            {
                foreach (Deal x in deals) if (x.Code == i) Kilos[i] += x.Quantity;
            }

            var sorted_Kilos = Kilos.OrderBy(x => Kilos);

        }
    }
}
