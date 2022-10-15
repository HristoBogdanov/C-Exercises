using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoparts
{
    public enum PartCategory
    {
        Engine,
        Tires,
        Exhaust,
        Suspention,
        Break

    }
    class Manufacturer
    {
        private string name;
        private string country;
        private string adress;
        private string PhoneNumber;
        private string fax;

        public Manufacturer(string name, string country, string adress, string PhoneNumber,string fax)
        {
            this.name = name;
            this.country = country;
            this.adress = adress;
            this.PhoneNumber = PhoneNumber;
            this.fax = fax;
        }

        public override string ToString()
        {
            return $"{this.name} -- {this.country} -- {this.adress} -- {this.PhoneNumber} -- {this.fax}";
        }

        

    }
}
