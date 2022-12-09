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
    public partial class Form5 : Form
    {
        public static int s5 = 0;
        Form6 f6 = new Form6();
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                s5 = s5 + 10;
            f6.Show();
            this.Hide();
        }
    }
}
