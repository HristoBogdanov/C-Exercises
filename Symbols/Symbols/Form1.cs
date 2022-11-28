using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;
namespace Symbols
{
    public partial class Form1 : Form
    {
        ArrayList stuff = new ArrayList();
        List<string> words = new List<string>();
        List<int> whole_numbers = new List<int>();
        List<double> real_numbers = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int count = int.Parse(textBox1.Text);
            for(int i =0;i<count;i++)
            {
                stuff.Add(Interaction.InputBox("Въведи символи"));
            }
            for (int i = 0; i < stuff.Count; i++)
            {
                if (stuff[i] is string) listBox1.Items.Add(stuff[i]);
                if (stuff[i] is int) listBox2.Items.Add(stuff[i]);
                if (stuff[i] is double) listBox3.Items.Add(stuff[i]);


            }
        }
    }
}
