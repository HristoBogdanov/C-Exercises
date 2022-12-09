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
    public partial class Form4 : Form
    {
        public static int s4 = 0;
        Form5 f5 = new Form5();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                s4 = s4 + 10;
            f5.Show();
            this.Hide();
        }
    }
}
