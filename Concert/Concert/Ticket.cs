using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concert
{
   public class Ticket
    {
        private int number;
        private char sector;
        public int Number { get { return this.number; }

            set { this.number = value; }
        }
        public char Sector
        {
            get { return this.sector; }
            set { this.sector = value; }
        }
        public Ticket(int number, char sector)

        {
            this.Number=number;
            this.Sector = sector;
        }
    }
}
