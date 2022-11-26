using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Console;

namespace Students_Visual
{
    public partial class Form1 : Form
    {
        int count = 0;
        List<Stipendiant> stipendianti = new List<Stipendiant>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = int.Parse(textBox1.Text);
            MessageBox.Show("Успешно въведен брой.Моля преминете на следващата страница");
            label8.Text = $"Оставащи записи:{count}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            double dohod = double.Parse(textBox3.Text);
            List<int> ocenki = new List<int>();
            ocenki.Add(int.Parse(comboBox1.Text));
            ocenki.Add(int.Parse(comboBox2.Text));
            ocenki.Add(int.Parse(comboBox3.Text));
            ocenki.Add(int.Parse(comboBox4.Text));
            Stipendiant stipendiant = new Stipendiant(name, ocenki, dohod);
            stipendianti.Add(stipendiant);
            count--;
            label8.Text = $"Оставащи записи:{count}";
            textBox2.Clear();
            textBox3.Clear();
            if (count == 0) MessageBox.Show("Изчерпахте записите си.Моля преминете на следващата страница.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Stipendiant x in stipendianti) listBox1.Items.Add(x.Info());
        }
    }
}
