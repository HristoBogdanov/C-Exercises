using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rectangle_console
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("strani.txt");
            StreamWriter resf = new StreamWriter("result.txt");
            List<Rectangle1> rectangles = new List<Rectangle1>();
            List<Rectangle1> copyrectangles = new List<Rectangle1>();
            Rectangle1 rectangle;
            string st;

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
            foreach (Rectangle1 x in rectangles)
                Console.WriteLine(Math.Round(x.getRectangleArea(),2));

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
