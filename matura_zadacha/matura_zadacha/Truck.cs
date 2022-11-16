using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matura_zadacha
{
    public class Truck:Car
    {
        public double Tonnage { get; set; }

        public Truck(string brand, int year, int millage, double value, double tonnage) :base(brand,year,millage,value)
        {
            this.Tonnage = tonnage;
        }

        public override double Price()
        {
            double result;
            int years = 2022 - this.Year;

            if (years <= 5) result = this.Value;
            else if (years > 5 && this.Tonnage <= 5) result = this.Value * 0.3;
            else if (years > 5 && this.Tonnage > 5 && this.Tonnage <= 10) result = this.Value * 0.6;
            else result = this.Value * 0.8;

            return result;
        }
        public override string ToString()
        {
            return $"{this.Brand}: {this.Millage}km, {this.Price():f2}";
        }
    }
}
