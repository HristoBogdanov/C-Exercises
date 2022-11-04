using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IContainer container = new ACMEContainer();
            ACMEContainer container1 = new ACMEContainer();
            container.setContainerID(1001);
            container1.setContainerID(1002);
            label1.Text = container.GetContainerID().ToString();
            label2.Text = container1.GetContainerID().ToString();

        }
    }
}
