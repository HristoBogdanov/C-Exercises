using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evklit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int NOD(int chislo1,int chislo2)
            {
                int r;
                do
                {
                    r = chislo1 % chislo2;
                    chislo1 = chislo2;
                    chislo2 = r;
                }
                while (r != 0);
                return chislo1;
            }
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            label2.Text = NOD(n, m).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int NOD_Izvajdane(int chislo1_izv,int chislo2_izv)
            {
                while (chislo1_izv != chislo2_izv)
                {
                    if (chislo1_izv < chislo2_izv) { int x = chislo1_izv; chislo1_izv = chislo2_izv; chislo2_izv = x; }
                    chislo1_izv = chislo1_izv - chislo2_izv;
                }
                return chislo1_izv;
            }
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            label3.Text = NOD_Izvajdane(a, b).ToString();
        }
    }
}
