using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concert
{
    public partial class Form1 : Form
    {
        Queue<Ticket> tickets = new Queue<Ticket>();
        Queue<Ticket> left = new Queue<Ticket>();
        Queue<Ticket> right = new Queue<Ticket>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(int.Parse(textBox1.Text), char.Parse(textBox2.Text));
            tickets.Enqueue(ticket);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ticket[] array = new Ticket[tickets.Count];
            array = tickets.ToArray();
            foreach(Ticket x in array)
            {
                if (x.Sector == 'A' && x.Number % 2 == 0) left.Enqueue(x);
                else if (x.Sector == 'A' && x.Number % 2 != 0) right.Enqueue(x);
                else if (x.Sector == 'B' && x.Number % 2 == 0) right.Enqueue(x);
                else left.Enqueue(x);
            }
            foreach (Ticket x in left)
                listBox1.Items.Add($"{x.Number}-{x.Sector}- ляво");
            foreach (Ticket x in right)
                listBox1.Items.Add($"{x.Number}-{x.Sector}- дясно");
        }
    }
}
