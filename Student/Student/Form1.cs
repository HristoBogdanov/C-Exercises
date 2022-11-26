using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        List<int> grades = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBox1.Text, textBox2.Text);
            grades = textBox3.Text.Split(',').Select(int.Parse).ToList();
            foreach (int x in grades) if (x < 2 || x > 6) throw new ArgumentException("Въведете оценка от 2 до 6");

             listBox1.Items.Add(student.Min(grades));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Student student = new Student(textBox1.Text, textBox2.Text);
            grades = textBox3.Text.Split(',').Select(int.Parse).ToList();
            foreach (int x in grades) if (x < 2 || x > 6) throw new ArgumentException("Въведете оценка от 2 до 6");
            listBox1.Items.Add(student.Max(grades));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Student student = new Student(textBox1.Text, textBox2.Text);
            grades = textBox3.Text.Split(',').Select(int.Parse).ToList();
            foreach (int x in grades) if (x < 2 || x > 6) throw new ArgumentException("Въведете оценка от 2 до 6");
            listBox1.Items.Add(student.Average(grades));
        }
    }
}
