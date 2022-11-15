using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masivi_suvpadeniq
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
                a[i] = r.Next(0, 5000);
            }
            foreach (int x in a)
                listBox1.Items.Add(x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int br = 0;
            for (int i = 0; i < a.Length; i++)
            {
                List<int> cifri = new List<int>();
                do
                {
                    cifri.Add(a[i] % 10);
                    a[i] = a[i] / 10;
                } while (a[i] > 0);
                if (cifri.Contains(i)) br++;
            }
            listBox1.Items.Add(br);
        }
    }
}
