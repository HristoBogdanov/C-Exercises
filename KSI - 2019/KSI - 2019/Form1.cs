using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSI___2019
{
    public partial class Form1 : Form
    {
        List<Star> stars = new List<Star>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name_star = textBox1.Text;
            double razstoqnie = double.Parse(textBox2.Text);
            int type = int.Parse(textBox3.Text);
            double mass = double.Parse(textBox4.Text);
            string suzvezdie = textBox5.Text;

            Star star = new Star(name_star, razstoqnie, type, mass, suzvezdie);
            stars.Add(star);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sorted_stars = stars.OrderBy(x => x.Length);

            foreach (Star x in sorted_stars) listBox1.Items.Add(x.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sorted_stars_2 = stars.OrderBy(x => x.Alignment).OrderByDescending(x => x.Mass);

            foreach (Star x in sorted_stars_2) listBox2.Items.Add(x.ToString());
        }
    }
}
