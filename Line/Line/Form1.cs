using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Line
{
    public partial class Form1 : Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Random r = new Random();
          
           
            Graphics G = e.Graphics;
            G.Clear(Color.Azure);
            
            for (int i = 0; i < 100000000; i++)
            {
                Pen p = new Pen(Color.FromArgb(r.Next(1, 256), r.Next(1, 256), r.Next(1, 256)), 5);
                Point a = new Point(r.Next(0, 500), r.Next(0, 500));
                Point b = new Point(r.Next(0, 500), r.Next(0, 500));
                G.DrawLine(p, a, b);
                System.Threading.Thread.Sleep(1);
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
