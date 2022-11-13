using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masivi_gymnastika
{
    public class Participants
    {
        private string name;
        private int number;
        public string Name {
            get { return this.name;}
            set { this.name = value; }
        }
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        
        public string ToString()
        {
            return $"{this.Name} -- {this.Number}";
        }
    }
}
