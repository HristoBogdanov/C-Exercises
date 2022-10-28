using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diofant_09._02._21
{
    public partial class Form1 : Form
    {
        public void Solution(int a, int b, ref int x1, ref int y1)
        {
            int q, r, x2, y2, t;
            x1 = 1; y1 = 0; x2 = 0; y2 = 1;
            while (b != 0)
            {
                q = a / b;
                r = a % b;
                a = b;
                b = r;
                t = x2;
                x2 = x1 - q * x2;
                x1 = t;
                t = y2;
                y2 = y1 - q * y2;
                y1 = t;
            }
        }

        int NOD_Substraction(int n, int m)
        {
            while (n != m)
            {
                if (n < m)
                {
                    int x = n;
                    n = m;
                    m = x;
                }
                n = n - m;
            }
            return n;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x0, y0;
            int x = 0, y = 0;
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = NOD_Substraction(a, b);
            label1.Text = d.ToString();
            if (c % d != 0)
            {
                label2.Text = "NO";
            }
            else {
                a /= d;
                b /= d;
                c /= d;
                Solution(a, b, ref x, ref y);
                x0 = x * c;
                y0 = y * c;
                label2.Text = $"{x0}\n{y0}";
                for (int i = -c; i <= c; i++)
                {
                    x = x0 - b * i;
                    y = y0 + a * i;
                    listBox1.Items.Add("x= " + x + "  y=" + y);
                }
            }
        }
    }
}
