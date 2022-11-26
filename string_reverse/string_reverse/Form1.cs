using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_reverse
{
    public partial class Form1 : Form
    {
        StringBuilder text = new StringBuilder();
        StringBuilder pom = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text.Append(textBox1.Text);
            string text_string = text.ToString();
            int a = text_string.Length;
            for (int i = a-1; i >=0; i--)
            {
                pom.Append(text[i]);
            }
            label1.Text = pom.ToString();
        }
    }
}
