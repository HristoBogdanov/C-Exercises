using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class Car
    {
        private string brand, model;
        private int productionYear;
        public Car(string brand, string model, int productionYear)
        {
            this.brand = brand;
            this.model = model;
            this.productionYear = productionYear;
        }

        public string Brand => this.brand;
        public string Model => this.model;

        public override string ToString()
        {
            return $"{this.brand} -- {this.model} -- {this.productionYear}";
        }
    }
}
