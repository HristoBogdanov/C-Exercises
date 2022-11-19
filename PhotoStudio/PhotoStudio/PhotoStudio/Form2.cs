using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio
{
    public partial class Form2 : Form
    {
        public double suma = 0;
        public double broi = 0;
        public double a = 0;
        public double b = 0;
        public double c = 0;
        public double d = 0;
        public double a1 = 0;
        public double b1 = 0;
        public double c1= 0;
        public double d1 = 0;
        Form3 f3 = new Form3();

        public Form2()
            
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                a = int.Parse(textBox1.Text);
                a1 = a * 0.19;
            }
            if (checkBox2.Checked == true) 
            {
                b = int.Parse(textBox2.Text);
                b1 = b * 0.24;
            }
            if (checkBox3.Checked == true) 
            {
                c = int.Parse(textBox3.Text);
                c1 = c * 0.35;
            }
            if (checkBox4.Checked == true) 
            {
                d = int.Parse(textBox4.Text);
                d1 = d * 0.55;
            }
            suma = a1 + b1 + c1 + d1;
            broi = a + b + c + d;
            f3.Show();
            if (broi >= 41 && broi <= 80)
            {
                suma = suma * 0.95;
                f3.radioButton1.Checked = true;
                f3.label1.Text = "Брой поръчани снимки:" + broi.ToString();
                f3.label2.Text = "Дължима сума:" + suma.ToString();
            }

            if (broi >= 81 && broi <= 110)
            {
                suma = suma * 0.90;
                f3.radioButton2.Checked = true;
                f3.label1.Text = "Брой поръчани снимки:" + broi.ToString();
                f3.label2.Text = "Дължима сума:" + suma.ToString();
            }

            if (broi >= 111 && broi <= 150)
            {
                suma = suma * 0.85;
                f3.radioButton3.Checked = true;
                f3.label1.Text = "Брой поръчани снимки:" + broi.ToString();
                f3.label2.Text = "Дължима сума:" + suma.ToString();
            }

            if (broi >= 151)
            {
                suma = suma * 0.80;
                f3.radioButton4.Checked = true;
                f3.label1.Text = "Брой поръчани снимки:" + broi.ToString();
                f3.label2.Text = "Дължима сума:" + suma.ToString();
            }

        }

        
                

            

        

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
