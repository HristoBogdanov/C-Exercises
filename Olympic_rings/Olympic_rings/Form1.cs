using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olympic_rings
{
    public partial class Form1 : Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen lb= new Pen(Color.LightBlue, 5);
            Pen y = new Pen(Color.Yellow, 5);
            Pen b = new Pen(Color.Black, 5);
            Pen gr = new Pen(Color.Green, 5);
            Pen r = new Pen(Color.Red, 5);
            g.DrawEllipse(lb, 0, 0, 100, 100);
            g.DrawEllipse(y, 50, 60, 100, 100);
            g.DrawEllipse(b,110, 0, 100, 100);
            g.DrawEllipse(gr, 160, 60, 100, 100);
            g.DrawEllipse(r, 220, 0, 100, 100);
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
