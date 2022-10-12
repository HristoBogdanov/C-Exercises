using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayList_student
{
    public partial class Form1 : Form
    {
        ArrayList student = new ArrayList();
        string[] names= new string[3];
        int[] ages = new int[3];
        int[] klasses = new int[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 3; i++)
            {
                names[i] = textBox1.Text;
                ages[i] = int.Parse(textBox2.Text);
                klasses[i] = int.Parse(textBox3.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student.AddRange(names);
            student.AddRange(ages);
            student.AddRange(klasses);
            listBox1.Items.Add(student[0] + "-" + student[3] + "-" + student[6]);
            listBox1.Items.Add(student[1] + "-" + student[4] + "-" + student[7]);
            listBox1.Items.Add(student[2] + "-" + student[5] + "-" + student[8]);
            //listBox1.Items.Add(student[3] + "-" + student[4] + "-" + student[5]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*t[0] = int.Parse(textBox4.Text);
            t[1] = int.Parse(textBox5.Text);
            t[2] = int.Parse(textBox6.Text);
            student.AddRange(t);
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();*/
        }
    }
}
