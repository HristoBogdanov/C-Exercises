using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rectangle_console
{
    public class Rectangle1
    {
        private double width;
        private double height;

        public Rectangle1(double w,double h)
        {
            width = w;
            height = h;
        }

        public double getRectangleArea()
        {
            return width * height;
        }

        public Rectangle1(Rectangle1 R)
        {
            width = R.width;
            height = R.height;
        }
    }
}
