using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    public enum PartCategory
    {
        Engine,
        Tires,
        Exhaust,
        Suspention,
        Brake
    }
    class Part
    {
        private string name, code;
        private PartCategory category;
        private List<Car> supportedCars;
        private double buyPrice, sellPrice;
        private Manufacturer manufacturer;

        public string Name => this.name;
        public string Code => this.code;
        public List<Car> SupportedCars => this.supportedCars;
        public Manufacturer Manufacturer
        {
            get => this.manufacturer;
            set { this.manufacturer = value; }
        }

        public Part(string name, double buyPrice, double sellPrice, Manufacturer manufacturer, string code, PartCategory category)
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
           string result = $"Part: {this.name}\n- Code: {this.code}\n- Category: {this.category}\n- Buy Price: {this.buyPrice}\n- Sell Price: {this.sellPrice}\n- Manufactorer: {this.manufacturer}\n";
            result += $"---Supported Car---";
            foreach (var car in this.supportedCars)
            {
                result += $"{car}\n";
            }
            return result; }
    }
}
