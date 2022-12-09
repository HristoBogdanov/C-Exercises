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
    public partial class Form3 : Form
    {
        public static int s3 = 0;
        Form4 f4 = new Form4();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                s3 = s3 + 10;
            f4.Show();
            this.Hide();
        }
    }
}
