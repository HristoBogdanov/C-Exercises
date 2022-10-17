using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box
{
    public partial class Form1 : Form
    {
        Box_all<string> secret = new Box_all<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string treasure = textBox1.Text;
            string sweet = comboBox1.Text;
            if (treasure != "")
            {
                secret.AddBox(treasure);
                textBox1.Clear();
            }
            else
            {
                secret.AddBox(sweet);
                comboBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(secret.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {          
            listBox1.Items.Clear();
            secret.Remove();
            listBox1.Items.Add(secret.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"Брой предмети в списъка: {secret.Count}");
        }
    }
}
