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

namespace Firm
{
    public partial class Form1 : Form
    {
        ArrayList names = new ArrayList();
        ArrayList years = new ArrayList();
        ArrayList type_work = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int year = int.Parse(textBox2.Text);
            string work = textBox3.Text;

            if (name != "Край" && name != "край") names.Add(name);
            else {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
         
            }
            if (work != "Край" && work != "край") type_work.Add(work);
            else {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
            years.Add(year);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < names.Count; i++)
            {
                listBox1.Items.Add(names[i] + "--" +years[i] + "--" + type_work[i]);
            }
    }

        private void button3_Click(object sender, EventArgs e)
        {
            string name_search = textBox4.Text;
            int name_index = names.IndexOf(name_search);
            if (names.Contains(name_search)) listBox2.Items.Add(name_search + "--" + years[name_index] + "--" + type_work[name_index]);
            else listBox2.Items.Add("Няма регистрирана фирма с такова име");
        }
    }
}
