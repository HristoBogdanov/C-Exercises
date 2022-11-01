using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Color
{

    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2.BackColor = Color.Red;
            form2.pictureBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form2.BackColor = Color.Green;
            form2.pictureBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form2.BackColor = Color.Blue;
            form2.pictureBox1.Visible = true;
            form2.pictureBox1.Image = Image.FromFile("2.jpg");
        }
    }
}
