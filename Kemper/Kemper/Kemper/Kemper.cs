using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kemper
{
    public class Kemper
    {
        private string ime;
        private string mqsto;
        private int dni;

        public string Ime
        {
            get { return this.ime; }
            set { if(value=="") throw new ArgumentException ("Невалидни данни");
                else this.ime=value;
            }
        }
        public string Mqsto
        {
            get { return this.mqsto; }
            set { this.mqsto=value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { if (value <= 0) throw new ArgumentException("Невалидни данни");
                else this.dni=value;
            }
        }
        public Kemper(string ime, string mqsto, int dni)
        {
            this.Ime = ime;
            this.Mqsto = mqsto;
            this.Dni = dni;
        }
        public string Print()
        {
            return $"{this.Ime} - {this.Mqsto} - {this.Dni} дни";
        }
    }
}
