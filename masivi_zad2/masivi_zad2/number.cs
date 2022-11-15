using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivi_zad2
{
    public class number
    {
       public int Stoinost { get; set; }

        public number(int stoinost)
        {
            this.Stoinost = stoinost;
        }

        public int GetSum(int sum)
        {
            int stoinost = this.Stoinost;
            do
            {
                sum+=  stoinost % 10;
                stoinost = stoinost / 10;
            } while (stoinost != 0);
            return sum;
        }
    }
}
