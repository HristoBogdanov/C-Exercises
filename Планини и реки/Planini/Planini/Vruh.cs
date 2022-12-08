using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planini
{
    public class Vruh:Planina
    {
        private string name_vruh;
        private int visochina;
        private string ime_planina;
        public string Name_vruh
        {
            get { return this.name_vruh; }
            set { this.name_vruh = value; }
        }
        public int Visochina
        {
            get { return this.visochina; }
            set { this.visochina = value; }
        }
        public string Ime_planina
        {
            get { return this.ime_planina; }
            set { this.ime_planina = value;}
        }
        public Vruh(string name_vruh, int visochina,string ime_planina, string ime, string strana) : base(ime, strana)
        {
            this.Name_vruh = name_vruh;
            this.Visochina = visochina;
            this.Ime_planina = ime_planina;
        }
      
    }
}
