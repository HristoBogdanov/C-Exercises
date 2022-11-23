using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Rectangle_console;


namespace Rectangle_Visual
{
    public partial class Form1 : Form
    {
        StreamReader f = new StreamReader("strani.txt");
        StreamWriter resf = new StreamWriter("result.txt");
        List<Rectangle1> rectangles = new List<Rectangle1>();
        List<Rectangle1> copyrectangles = new List<Rectangle1>();
        Rectangle1 rectangle;
        string st;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (f)
            {
                st = f.ReadLine();
                while (st != null)
                {
                    var pom = st.Split(' ').Select(double.Parse).ToList();
                    rectangle = new Rectangle1(pom[0], pom[1]);
                    rectangles.Add(rectangle);
                    st = f.ReadLine();
                }
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Rectangle1 x in rectangles)
            {
                listBox1.Items.Add(Math.Round(x.getRectangleArea(), 2));
            }
            foreach (Rectangle1 x in rectangles)
            {
                Rectangle1 r = new Rectangle1(x);
                copyrectangles.Add(r);
            }

            using (resf)
            {
                foreach (Rectangle1 x in copyrectangles)
                {
                    resf.WriteLine(Math.Round(x.getRectangleArea(), 2));
                }
            }
        }
    }
}
