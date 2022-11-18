using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pazaruvane
{
    public class Product
    {
        public string Name { get; set; }
        public double Ammount { get; set; }
        public double Price { get; set; }

        public Product(string name,double ammount,double price)
        {
            this.Name = name;
            this.Price = price;
            this.Ammount = ammount;
        }
    }
}
