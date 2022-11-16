using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matura_zadacha
{
    public class Car
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public int Millage { get; set; }
        public double Value { get; set; }

        public Car(string brand,int year,int millage,double value)
        {
            this.Brand = brand;
            this.Year = year;
            this.Millage = millage;
            this.Value = value;
        }

        public virtual double Price()
        {
            int years = 2022 - this.Year;
            double result;
            if (years <= 3) result = this.Value * 0.8;
            else if (years > 3 && years <= 6) result = this.Value * 0.6;
            else result = this.Value * 0.3;

            return result;
        }
        public override string ToString()
        {
            return $"{this.Brand}: {this.Millage}km, {this.Price():f2}";
        }
    }
}
