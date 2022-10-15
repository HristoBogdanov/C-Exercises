using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoparts
{
    class Part
    {
        private string name;
        private string code;
        private PartCategory category;
        private List<Car> supportedCars;
        private double buyPrice;
        private double sellPrice;
        private Manufacturer manufacturer;

        public Part(string name, string code, PartCategory category, double buyPrice, double sellPrice, Manufacturer manufacturer)
        {
            this.name = name;
            this.code = code;
            this.category = category;
            this.buyPrice = buyPrice;
            this.sellPrice = sellPrice;
            this.manufacturer = manufacturer;
            this.supportedCars = new List<Car>();
        }
        public void AddSupportedCar(Car car)
        {
            this.supportedCars.Add(car);
        }
        public override string ToString()
        {
            return $"{this.name} -- {this.code} -- {this.category} -- {this.buyPrice}лв. -- {this.sellPrice}лв. -- {this.manufacturer}";
        }
    }
}
