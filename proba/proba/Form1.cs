using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int x = r.Next(1,100);
            if (x > 10 && x <= 50 && x % 2 == 0)
            {
                listBox1.Items.Add(x);
                listBox1.Items.Add("Valid");
            }

            else
            {
                listBox1.Items.Add(x);
                listBox1.Items.Add("Invalid");
            }
            }
        }
    }

