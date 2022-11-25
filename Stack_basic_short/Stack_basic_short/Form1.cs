using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack_basic_short
{
    public partial class Form1 : Form
    {
        Stack<string> competitors = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            competitors.Push(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            do
            {
                listBox1.Items.Add(competitors.Pop());
            }
            while (competitors.Count != 0);
        }
    }
}
