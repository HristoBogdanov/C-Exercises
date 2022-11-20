using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prosti_chisla
{
    public partial class Form1 : Form
    {
        List<int> prosti = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chislo1 = int.Parse(textBox1.Text);
            int chislo2 = int.Parse(textBox2.Text);

            for (int i = chislo1; i < chislo2; i++)
            {

                bool isPrime = true;
                for (int j = 2; j < Math.Sqrt(i); j++)              
                if (i % j == 0)
                    {                       
                        isPrime = false;
                        break;
                    }
                if (isPrime)
                    prosti.Add(i);
            }

            foreach (int x in prosti) listBox1.Items.Add(x);
        }
    }
}
