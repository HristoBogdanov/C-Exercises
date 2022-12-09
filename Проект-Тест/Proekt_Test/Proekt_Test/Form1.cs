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
    public partial class Form1 : Form
    {
        public static int s = 0;
        Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
                s = s + 10;
            f2.Show();
            this.Hide();
        }
    }
}
