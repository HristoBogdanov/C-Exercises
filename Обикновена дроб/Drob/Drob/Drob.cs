using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drob
{
    public class Drob
    { 
        private int chislitel;
        private int znamenatel;

        public int Chislitel
        {
            get {
                return this.chislitel;
            }
            set {
                this.chislitel = value;
            }
        }
        public int Znamenatel
        {
            get
            {
                return this.znamenatel;
            }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Знаменателят не може да е 0");
                this.znamenatel = value;
            }
        }
        public int Deliteli(int a , int b)
        {
            List<int> delеnie_chislitel = new List<int>();
            List<int> delenie_znamenatel = new List<int>();
            List<int> deliteli = new List<int>();
            int br = 0;
            for (int i = 2; i <=a; i++)
            {
                if (a % i == 0)
                    delеnie_chislitel.Add(i);
            }
            for (int i = 2; i <= b; i++)
            {
                if (b % i == 0)
                    delenie_znamenatel.Add(i);
            }
            for (int i = 0; i < delеnie_chislitel.Count; i++)
            {
                for (int j = 0; j < delenie_znamenatel.Count; j++)
                {
                    if (delеnie_chislitel[i] == delenie_znamenatel[j])
                    {
                        br++;
                        deliteli.Add(delеnie_chislitel[i]);
                    }
                }
            }
            if (br == 0) return 1;
            else return deliteli[deliteli.Count - 1];
        
    
        }
    }
}
