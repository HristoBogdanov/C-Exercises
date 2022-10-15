using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoparts
{
    public partial class Form1 : Form
    {
        public PartCategory result()
        {
            PartCategory p = PartCategory.Engine;
            if (comboBox1.SelectedIndex == 0) p = PartCategory.Engine;
            else if (comboBox1.SelectedIndex == 1) p = PartCategory.Tires;
            else if (comboBox1.SelectedIndex == 2) p = PartCategory.Exhaust;
            else if (comboBox1.SelectedIndex == 3) p = PartCategory.Suspention;
            else if (comboBox1.SelectedIndex == 4) p = PartCategory.Break;
            return p;
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manufacturer manufacturer = new Manufacturer(textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text);
            PartCategory partCategory = result();
            Part part = new Part(textBox1.Text, textBox2.Text, partCategory, double.Parse(textBox4.Text), double.Parse(textBox5.Text),manufacturer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manufacturer manufacturer = new Manufacturer(textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text);
        }
    }
}
