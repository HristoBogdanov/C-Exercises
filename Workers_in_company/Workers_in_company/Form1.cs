using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workers_in_company
{ 
    public partial class Form1 : Form
    {
        List<FullTimeEmployee> employees = new List<FullTimeEmployee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            FullTimeEmployee NewEmployee = new FullTimeEmployee(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            NewEmployee.WorkingHours = int.Parse(textBox6.Text);
            employees.Add(NewEmployee);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            employees = employees.OrderByDescending(x => x.WorkingHours).ToList();
            foreach (FullTimeEmployee x in employees)
                richTextBox1.Text += x.Print();
        }
    }
}
