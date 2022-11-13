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

namespace Masivi_min_max_suma
{
    public partial class Form1 : Form
    {
        int[] a = new int[10];
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] =int.Parse( Interaction.InputBox(""));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (int x in a)
                listBox1.Items.Add(x);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int MIN()
            {
                int min = a[0];
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < min) min=a[i];
                    
                }
                return min ;
            }
            listBox1.Items.Add($"Най-малкият елемент е:{MIN()}{Environment.NewLine}");

            int MIN_Index()
            {
                int index = 0;
                int min = a[0];
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] < min) { min = a[i];
                        index = i;};
                }
                return index;
            }
            listBox1.Items.Add($"Най-малкият елемент е:{MIN()}{Environment.NewLine}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int MAX()
            {
                int max = a[0];
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] >max) max = a[i];
                }
                return max;
            }
            listBox1.Items.Add($"Най-големият елемент е:{MAX()}{Environment.NewLine}");

            int MAX_Index()
            {
                int index = 0;
                int max = a[0];
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                        index = i;
                    }
                }
                return index;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for()
        }
    }
}
