using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuri1
{
    public partial class Form1 : Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 5);
            Brush bb = new SolidBrush(Color.Green);
            g.DrawRectangle(p, 0, 0, 200, 300);
            g.DrawEllipse(p, 50, 50,200, 400);
            g.FillRectangle(bb, 200, 200, 100, 100);
            g.FillEllipse(bb, 100, 100, 100, 100);
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
