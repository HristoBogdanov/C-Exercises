using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planini
{
    public class Reka:Planina
    {
        private string ime_reka;
        private int length;
        private string ime_planina;

        public string Ime_reka
        {
            get { return this.ime_reka; }
            set { this.ime_reka = value; }
        }
        public int Length {
            get { return this.length;}
            set { this.length = value;}
        }
        public string Ime_planina
        {
            get { return this.ime_planina; }
            set { this.ime_planina = value;}
        }
        public Reka(string ime_reka,string ime_planina, int length, string ime, string strana) : base(ime, strana)
        {
            this.Ime_reka = ime_reka;
            this.Length = length;
            this.Ime_planina = ime_planina;
        }
    }
}
