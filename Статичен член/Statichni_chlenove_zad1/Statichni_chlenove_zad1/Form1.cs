using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statichni_chlenove_zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Magazin.Add(textBox1.Text, textBox2.Text, double.Parse(textBox3.Text), double.Parse(textBox4.Text));
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Magazin.Load( textBox5.Text, double.Parse(textBox6.Text));

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Magazin.SellProduct(textBox8.Text, double.Parse(textBox7.Text));
          
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Magazin.Calculate();
        }
    }
}
