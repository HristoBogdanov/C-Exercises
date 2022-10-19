using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Br_na_proizvedenie
{
    
    public class NumbersMultiplay
    {
        List<int> cifri_na_chislo = new List<int>();
        private int cifri;
        public int Cifri
        {
            get { return this.cifri; }
            set { this.cifri = value; }
        }
        public NumbersMultiplay(string cifri)
        {
            this.cifri = Cifri;
        }
        public List<int> GetResult()
        {
            do
            {
                int p = 0;
                p = Cifri % 10;
                cifri_na_chislo.Add(p);
                Cifri = Cifri / 10;
            } while (Cifri > 0);
            return cifri_na_chislo;
        }

    }
}
