using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICar
{
    public partial class Form1 : Form
    {
        List<Seat> seats = new List<Seat>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seat car = new Seat(textBox1.Text,textBox2.Text,int.Parse(textBox3.Text));
            seats.Add(car);
            comboBox1.Items.Add(car.Model);
            comboBox2.Items.Add(car.Year);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Seat x in seats)
                listBox1.Items.Add(x.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Seat x in seats)
                if (!comboBox1.Items.Contains(x.Model)) comboBox1.Items.Add(x.Model);
                
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Seat x in seats)
                if (!comboBox2.Items.Contains(x.Year)) comboBox2.Items.Add(x.Year);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string st = comboBox1.Text;
            foreach (Seat x in seats)
                if (x.Model == st) listBox1.Items.Add(x.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int y = int.Parse(comboBox2.Text);
            foreach (Seat x in seats)
                if (x.Year == y) listBox2.Items.Add(x.ToString());
        }
    }
}
