using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masivi_ravni_elementi
{
    public partial class Form1 : Form
    {
        int[] a = new int[7];
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1, 10);
            }
            foreach (int x in a) listBox1.Items.Add(x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<a.Length;i++)
            {
                for (int j = i + 1; j < a.Length-1; j++)
                {
                    if (a[i] == a[j]) label1.Text = label1.Text + $"{a[i]} се повтаря на {i} и {j} позиция! {Environment.NewLine}";
                }
            }
        }
    }
}
