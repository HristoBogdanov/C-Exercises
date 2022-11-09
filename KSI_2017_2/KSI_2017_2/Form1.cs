using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSI_2017_2
{
    public partial class Form1 : Form
    {
        List<Worker> workers = new List<Worker>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sorted_workers_2 = workers.OrderBy(x => x.Country).ThenBy(x => x.Name_worker);

            foreach (Worker x in sorted_workers_2) listBox1.Items.Add(x.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") throw new ArgumentException("Missing data");
            Worker worker = new Worker(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            workers.Add(worker);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Worker> workers_empty = new List<Worker>();

            foreach (Worker x in workers) if (x.City == "" || x.Postcode == "") workers_empty.Add(x);

            var sorted_list_3 = workers_empty.OrderBy(x => x.EGN);
            foreach (Worker x in sorted_list_3) listBox1.Items.Add(x.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Worker x in workers)
            {
                if (x.Print_post() != "Missing data") listBox1.Items.Add(x.Print_post());
            }
        }
    }
}
