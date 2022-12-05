using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koren
{
    public partial class Form1 : Form
    {
        List<int> cifri_na_kvadrat = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int chislo = int.Parse(textBox1.Text);
            int kvadrat = chislo * chislo;
            cifri_na_kvadrat.Clear();
            do
            {
                int x = kvadrat % 10;
                kvadrat = kvadrat / 10;
                cifri_na_kvadrat.Add(x);
            } while (kvadrat > 0);
            for (int i = 0; i <= cifri_na_kvadrat.Count - 1; i++)                
            {
                
                if (cifri_na_kvadrat.Contains(chislo))  label2.Text = "Числото се съдържа в записа на квадрата си";
                else label2.Text = "Числото не се съдържа в записа на квадрата си";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {  }
    }
}
