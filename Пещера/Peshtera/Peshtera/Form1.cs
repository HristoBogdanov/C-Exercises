using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peshtera
{
    public partial class Form1 : Form
    {
        Form2 f1 = new Form2();
        Form2 f2 = new Form2();
        Form2 f3 = new Form2();
        Form2 f4 = new Form2();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.Show();
            f1.richTextBox1.Text = "Магурата";
            f1.pictureBox1.Image=Image.FromFile("Magura1.jpg");
            f1.pictureBox2.Image = Image.FromFile("Magura2.jpg");
            f1.pictureBox3.Image = Image.FromFile("Magura3.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2.Show();
            f2.richTextBox1.Text = "Дяволско гърло";
            f2.pictureBox1.Image = Image.FromFile("d1.jpg");
            f2.pictureBox2.Image = Image.FromFile("d2.jpg");
            f2.pictureBox3.Image = Image.FromFile("d3.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f3.Show();
            f3.richTextBox1.Text = "Деветашка пещера";
            f3.pictureBox1.Image = Image.FromFile("dev1.jpg");
            f3.pictureBox2.Image = Image.FromFile("dev2.jpg");
            f3.pictureBox3.Image = Image.FromFile("dev3.jpg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f4.Show();
            f4.richTextBox1.Text = "Бачо Киро";
            f4.pictureBox1.Image = Image.FromFile("b1.jpg");
            f4.pictureBox2.Image = Image.FromFile("b2.jpg");
            f4.pictureBox3.Image = Image.FromFile("b3.jpg");
        }
    }
}
