using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domashna_06._01._2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            for (int i = 1000; i < 10000; i++)
            {
                int s = 0;
                int x = i;
                do
                {
                    
                    s = s + x % 10;
                    x = x / 10;
                } while (x > 0);

                if (i % s == 0) listBox1.Items.Add(i.ToString());
            }
        }
    }
}
