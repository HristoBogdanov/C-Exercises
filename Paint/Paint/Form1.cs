using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Random r = new Random();


            Graphics g = e.Graphics;

            for (int i = 1; i < 1000000; i++)
            {
                g.Clear(Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256)));
                System.Threading.Thread.Sleep(300);
            }
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
