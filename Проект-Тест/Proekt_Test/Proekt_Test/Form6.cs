using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt_Test
{
    public partial class Form6 : Form
    {
        public static int sum = 0;
        public Form6()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form6.sum = Form5.s5 + Form4.s4 + Form3.s3 + Form2.s2 + Form1.s;
            label1.Text = "Брой точки" + " " + sum.ToString();

            if (Form6.sum <= 10)
                label2.Text = "Твоята оценка е : Слаб 2";

            if (Form6.sum >10 && Form6.sum<=20)
                label2.Text = "Твоята оценка е : Среден 3";

            if (Form6.sum > 20 && Form6.sum <= 30)
                label2.Text = "Твоята оценка е : Добър 4";

            if (Form6.sum >30 && Form6.sum<=40)
                label2.Text = "Твоята оценка е : Мн.Добър 5";

            if (Form6.sum >40)
                label2.Text = "Твоята оценка е : Отличен 6";
        }
    }
}
