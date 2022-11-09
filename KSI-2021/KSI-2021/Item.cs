using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSI_2021
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Type { get; set; }

        public Item(int id,string name,double price,int quantity,int type)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Type = type;
        }
        public string Print()
        {
            string unicode = $"{this.ID}{this.Name[0]}{this.Name[1]}{this.Type}";
            return $"{this.ID}, {this.Name}, {this.Price}лв., {this.Quantity} броя, {this.Type} тип, {unicode}";
        }
        public double Total_price()
        {
            return this.Price* this.Quantity;
        }
    }
}
