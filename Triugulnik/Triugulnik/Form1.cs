using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triugulnik
{
    public partial class Form1 : Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red, 5);
            Point a = new Point(300, 300);
            Point b = new Point(300+200, 300);
            Point c = new Point(300 + (200 / 2), 300 + (int)Math.Sqrt(200 * 200 - 100 * 100));

            g.DrawLine(p, a, b);
            g.DrawLine(p, a, c);
            g.DrawLine(p, b, c);

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
