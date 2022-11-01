using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    public class Fraction
    {
        private int chislitel;
        private int znamenatel;
        public int Chislitel
        {
            get { return this.chislitel; }
            set { this.chislitel = value; }
        }
        public int Znamenatel
        {
            get { return this.znamenatel; }
            set { this.znamenatel = value; }
        }
        

        public int SUM(int m1,int n1)
        {
            int r;
            do
            {
                r = m1 % n1;
                m1 = n1;
                n1 = r;
            } while (r != 0);
            return m1;
            
        }
    }
        
    
}
