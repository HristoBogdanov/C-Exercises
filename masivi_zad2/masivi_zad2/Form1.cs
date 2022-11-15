using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace masivi_zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("input.txt", Encoding.UTF8);
            List<number> numbers = new List<number>();
            string input = reader.ReadLine();

            var pom = input.Split(' ').ToList();
            
            for(int i=0;i<pom.Count;i++)
            {
                number n = new number(int.Parse(pom[i]));
                numbers.Add(n);
            }
            
            for(int i=0;i<numbers.Count;i++)
            {
                for(int j=0;j<numbers.Count-1;j++)
                {
                    if (numbers[j].GetSum(0) < numbers[j + 1].GetSum(0))
                    {
                        int pomm = numbers[j].Stoinost;
                        numbers[j].Stoinost = numbers[j + 1].Stoinost;
                        numbers[j+1].Stoinost=pomm;
                    }
                }
            }
            foreach (number x in numbers) listBox1.Items.Add(x.Stoinost);
            
        }
    }
}
