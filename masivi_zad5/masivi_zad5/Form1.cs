using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace masivi_zad5
{
    public partial class Form1 : Form
    {
        List<River> rivers = new List<River>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            River river = new River(textBox1.Text, int.Parse(textBox2.Text));
            rivers.Add(river);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<rivers.Count();i++)
            {
                for(int j=0;j<rivers.Count()-1;j++)
                {
                    if(rivers[j].Length<rivers[j+1].Length)
                    {
                        string pom_name = rivers[j].Name;
                        int pom_length = rivers[j].Length;

                        rivers[j].Name = rivers[j + 1].Name;
                        rivers[j].Length = rivers[j + 1].Length;

                        rivers[j + 1].Name = pom_name;
                        rivers[j + 1].Length = pom_length;
                    }
                }
            }
            foreach (River x in rivers) listBox1.Items.Add(x.ToString());
        }
    }
}
