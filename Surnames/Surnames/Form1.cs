using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Surnames
{
    public partial class Form1 : Form
    {
        StringBuilder jeni= new StringBuilder();
        StringBuilder muje= new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int length = name.Length;
            string pom = name.Substring(length - 2);

            if (pom == "ев" || pom == "ов") muje.AppendLine(name);
            else jeni.AppendLine(name);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = muje.ToString();
            label2.Text = jeni.ToString();
        }
    }
}
