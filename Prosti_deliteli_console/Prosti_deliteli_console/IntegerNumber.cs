using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prosti_deliteli_console
{
    class IntegerNumber
    {
        private int stoinost;
        public int Stoinost
        {
            get { return this.stoinost; }
            set { this.stoinost = value; }
        }
        public IntegerNumber(int a)
        {
            Stoinost = a;
        }

        public string Razlagane()
        {
            
            int pom = this.stoinost;
            List<int> result = new List<int>();
            for (int i = 2; i <=pom; i++)
            {
                while (pom % i == 0)
                {
                    pom = pom / 2;
                    result.Add(i);
                }
               
            }
            string st = string.Join(" ", result);
            return st;
        }
    }
}
