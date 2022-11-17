using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int NOD_Delenie(int a, int b)
        {
            if (b == 0) return a;
            else return NOD_Delenie(b, a % b);
        }
        public int NOD_Izvajdane(int a,int b)
        {
            if (a == b) return a;
            else if (a > b) return NOD_Izvajdane(a - b, b);
            else return NOD_Izvajdane(a, b - a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            label3.Text = NOD_Delenie(a, b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            label3.Text = NOD_Izvajdane(a, b).ToString();
        }
    }
}
