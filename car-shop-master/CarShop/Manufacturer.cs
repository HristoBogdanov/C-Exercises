using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class Manufacturer
    {
        private string name, country, adress, phoneNumber, fax;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Manufacturer(string name, string country, string adress, string phoneNumber, string fax)
        { 
            this.name = name;
            this.country = country;
            this.adress = adress;
            this.phoneNumber = phoneNumber;
            this.fax = fax;
        }

        public override string ToString()
        {
            return $"{this.name} -- {this.country} -- {this.adress} -- {this.phoneNumber} -- {this.fax}";
        }
    }
}
