using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> aa = new List<int>();
            List<int> b = new List<int>();
            aa.Add(int.Parse(textBox1.Text));
            aa.Add(int.Parse(textBox2.Text));
            aa.Add(int.Parse(textBox3.Text));
            b = aa;
            foreach (int x in b) listBox1.Items.Add(x);
        }
    }
}
