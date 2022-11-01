using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraction
{
    public partial class Form1 : Form
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chislitel1 = int.Parse(textBox1.Text);
            int znamenatel1 = int.Parse(textBox2.Text);
            int chislitel2 = int.Parse(textBox4.Text);
            int znamenatel2 = int.Parse(textBox3.Text);
            fraction1.Chislitel = chislitel1;
            fraction1.Chislitel = fraction1.Chislitel / fraction1.SUM(chislitel1, znamenatel1);
            fraction1.Znamenatel = znamenatel1;
            fraction1.Znamenatel = fraction1.Znamenatel / fraction1.SUM(chislitel1, znamenatel1);
            fraction2.Chislitel = chislitel2;
            fraction2.Chislitel = fraction2.Chislitel / fraction2.SUM(chislitel2, znamenatel2);
            fraction2.Znamenatel = znamenatel2;
            fraction2.Znamenatel = fraction2.Znamenatel / fraction2.SUM(chislitel2, znamenatel2);
            int result_chislitel;
            int result_znamenatel;
            result_chislitel = (fraction1.Chislitel * fraction2.Znamenatel) + (fraction1.Znamenatel * fraction2.Chislitel);
            result_znamenatel = fraction1.Znamenatel * fraction2.Znamenatel;
            fraction1.Znamenatel = result_znamenatel / fraction1.SUM(result_chislitel, result_znamenatel);
            fraction1.Chislitel = result_chislitel / fraction1.SUM(result_chislitel, result_znamenatel);
            if (fraction1.Chislitel == fraction1.Znamenatel) listBox1.Items.Add("1");
            else if (fraction1.Chislitel == -fraction1.Znamenatel) listBox1.Items.Add("-1");
            else
            {
                listBox1.Items.Add(fraction1.Chislitel);
                listBox1.Items.Add("━");
                listBox1.Items.Add(fraction1.Znamenatel);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int chislitel1 = int.Parse(textBox1.Text);
            int znamenatel1 = int.Parse(textBox2.Text);
            int chislitel2 = int.Parse(textBox4.Text);
            int znamenatel2 = int.Parse(textBox3.Text);
            fraction1.Chislitel = chislitel1;
            fraction1.Chislitel = fraction1.Chislitel / fraction1.SUM(chislitel1, znamenatel1);
            fraction1.Znamenatel = znamenatel1;
            fraction1.Znamenatel = fraction1.Znamenatel / fraction1.SUM(chislitel1, znamenatel1);
            fraction2.Chislitel = chislitel2;
            fraction2.Chislitel = fraction2.Chislitel / fraction2.SUM(chislitel2, znamenatel2);
            fraction2.Znamenatel = znamenatel2;
            fraction2.Znamenatel = fraction2.Znamenatel / fraction2.SUM(chislitel2, znamenatel2);
            int result_chislitel;
            int result_znamenatel;
            result_chislitel = fraction1.Chislitel * fraction2.Chislitel;
            result_znamenatel = fraction1.Znamenatel * fraction2.Znamenatel;
            fraction1.Chislitel = result_chislitel / fraction1.SUM(result_chislitel, result_znamenatel);
            fraction1.Znamenatel=result_znamenatel/ fraction1.SUM(result_chislitel, result_znamenatel);
            if (fraction1.Chislitel == fraction1.Znamenatel) listBox1.Items.Add("1");
            else if (fraction1.Chislitel == -fraction1.Znamenatel) listBox1.Items.Add("-1");
            else
            {
                listBox1.Items.Add(fraction1.Chislitel);
                listBox1.Items.Add("━");
                listBox1.Items.Add(fraction1.Znamenatel);
            }
        }
    }
}
