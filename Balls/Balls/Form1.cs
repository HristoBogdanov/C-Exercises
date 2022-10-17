using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balls
{
    public partial class Form1 : Form
    {
        Queue<int> all = new Queue<int>();
        Queue<int> black = new Queue<int>();
        Queue<int> white = new Queue<int>();
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            all.Enqueue(r.Next(1, 3));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int check;
            do
            {
                check = all.Dequeue();
                if (check == 1) listBox1.Items.Add("Бяло");
                else listBox2.Items.Add("Черно");
            }
            while (all.Count > 0);
        }
    }
}
