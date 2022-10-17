using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barrels
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int br = 0;
            Barels barel1 = new Barels(int.Parse(textBox1.Text));
            Barels barel2 = new Barels(int.Parse(textBox2.Text));
            Barels barel3 = new Barels(int.Parse(textBox3.Text));
            Barels barel4 = new Barels(int.Parse(textBox4.Text));
            int a = barel1.Vmestimost;
            int b = barel2.Vmestimost;
            int c = barel3.Vmestimost;
            int s = barel4.Vmestimost;
            
            for (int x = 0; x <= s; x++)
            {
                for (int y = 0; y <= s; y++)
                {
                    for (int z = 0; z <= s; z++)
                    {
                        if (x * a + y * b + z * c == s) br++;
                    }
                }
            }
            label3.Text = br.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
