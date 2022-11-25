using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reverse_word
{
    
    public partial class Form1 : Form
    {
        Stack<char> reverse = new Stack<char>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            for (int i = 0; i < word.Length; i++)
            {
                reverse.Push(word[i]);
            }

            do
            {
                label1.Text += reverse.Pop();
            } while (reverse.Count != 0);
        }
    }
}
