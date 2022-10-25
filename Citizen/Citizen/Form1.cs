using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Citizen
{
    public partial class Form1 : Form
    {
        List<Citizen> citizens = new List<Citizen>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Citizen citizen = new Citizen(textBox1.Text, int.Parse(textBox2.Text));
            citizens.Add(citizen);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Citizen x in citizens)
            {
                if (x.Age >= 18 && x.Age < 23 && comboBox1.SelectedIndex == 0) listBox1.Items.Add(x.ToString());
                if (x.Age >= 23 && x.Age < 28 && comboBox1.SelectedIndex == 1) listBox1.Items.Add(x.ToString());
                if (x.Age >= 28 && x.Age <33 && comboBox1.SelectedIndex == 2) listBox1.Items.Add(x.ToString());
                if (x.Age >= 33 && x.Age < 38 && comboBox1.SelectedIndex == 3) listBox1.Items.Add(x.ToString());
                if (x.Age >= 38 && x.Age < 43 && comboBox1.SelectedIndex == 4) listBox1.Items.Add(x.ToString());
                if (x.Age >= 43 && x.Age < 48 && comboBox1.SelectedIndex == 5) listBox1.Items.Add(x.ToString());
                if (x.Age >= 48 && x.Age < 53 && comboBox1.SelectedIndex == 6) listBox1.Items.Add(x.ToString());
                if (x.Age >= 53 && x.Age < 58 && comboBox1.SelectedIndex == 7) listBox1.Items.Add(x.ToString());
                if (x.Age >= 58 && x.Age < 63 && comboBox1.SelectedIndex == 8) listBox1.Items.Add(x.ToString());
                if (x.Age >= 63 && x.Age <= 70 && comboBox1.SelectedIndex == 9) listBox1.Items.Add(x.ToString());
            }
        }
    }
}
