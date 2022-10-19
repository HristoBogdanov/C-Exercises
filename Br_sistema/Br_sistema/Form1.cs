using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Br_sistema
{
    public partial class Form1 : Form
    {
        Stack<int> ostatuci = new Stack<int>();
        string result = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nachalno_chislo = int.Parse(textBox1.Text);
            int osnova = int.Parse(textBox2.Text);
            
            do
            {
                ostatuci.Push(nachalno_chislo % osnova);
                nachalno_chislo = nachalno_chislo / osnova;
            }
            while (nachalno_chislo != 0);

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            do
            {
                result += (ostatuci.Pop()).ToString();
            } while (ostatuci.Count > 0);
            listBox1.Items.Add(result);
        }
    }
}
