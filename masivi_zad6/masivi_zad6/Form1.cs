using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace masivi_zad6
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            students.Add(student);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<students.Count();i++)
            {
                for(int j=i+1;j<students.Count();j++)
                    if(students[i].Score()<students[j].Score())
                    {
                        string pom_name = students[i].Name;
                        int pom_result1 = students[i].Result1;
                        int pom_result2 = students[i].Result2;
                        int pom_result3 = students[i].Result3;

                        students[i].Name = students[j].Name;
                        students[i].Result1 = students[j].Result1;
                        students[i].Result2 = students[j].Result2;
                        students[i].Result3 = students[j].Result3;

                        students[j].Name = pom_name;
                        students[j].Result1 = pom_result1;
                        students[j].Result2 = pom_result2;
                        students[j].Result3 = pom_result3;
                    }
            }
            foreach (Student x in students) listBox1.Items.Add(x.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result1 = students.OrderByDescending(x => x.Result1);

            listBox1.Items.Add(result1.First().ToString());

            var result2 = students.OrderByDescending(x => x.Result2);

            listBox1.Items.Add(result2.First().ToString());

            var result3 = students.OrderByDescending(x => x.Result3);

            listBox1.Items.Add(result3.First().ToString());
        }
    }
}
