using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack_basic
{
    public partial class Form1 : Form
    {
        Places place = new Places(50);
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            do
            {
                listBox1.Items.Add(place.Pop());
            }
            while (place.Size() > 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            place.Push(textBox1.Text);
            textBox1.Clear();
        }
    }
}
