using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tail
{
    public partial class Form1 : Form
    {
        public class intQueue
        {
            public int n;
            public int bottom, top;
            public int[] Elemets = new int[1];
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queue intqueue = new queue(int.Parse(textBox2.Text));
            intqueue.Push(int.Parse(textBox1.Text));
            textBox1.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            queue intqueue = new queue(int.Parse(textBox2.Text));
            listBox1.Items.Add(intqueue.Output());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            queue intqueue = new queue(int.Parse(textBox2.Text));
            listBox1.Items.Add(intqueue.Look());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            queue intqueue = new queue(int.Parse(textBox2.Text));
            listBox1.Items.Add(intqueue.Count());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            queue intqueue = new queue(int.Parse(textBox2.Text));
            listBox1.Items.Add(intqueue.Pop());
        }
    }
}
