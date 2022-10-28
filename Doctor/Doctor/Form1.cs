using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor
{
    public partial class Form1 : Form
    {
        Queue<string> patients = new Queue<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patients.Enqueue(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string proverka = textBox2.Text;
            if (patients.Peek() == proverka) patients.Dequeue();
            else MessageBox.Show("Пациентът не е записан или не е дошъл неговия ред");
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = (patients.Count).ToString();
        }
    }
}
