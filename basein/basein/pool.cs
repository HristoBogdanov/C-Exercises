using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basein
{
    public class pool
    {
        private double r;
        private double h;

        public double R
        {
            get { return this.r; }
            set { this.r = value; }
        }

        public double H
        {
            get { return this.h; }
            set { this.h = value; }
        }


        public pool(double r,double h)
        {
            this.R = r;
            this.H = h;
        }
        public double V()
        {
            return Math.PI * this.R * this.R * this.H;
        }
        public double Price_water(double price, double tax)
        {
            return this.V() * price * (1 + tax / 100);
        }
    }
}
