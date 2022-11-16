using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivi_zad5
{
    public class River
    {
        public string Name { get; set; }
        public int Length { get; set; }

        public River(string name,int length)
        {
            this.Name = name;
            this.Length = length;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Length}";
        }
    }
}
