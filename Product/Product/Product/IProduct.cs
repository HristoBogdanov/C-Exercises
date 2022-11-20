using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public enum product_group {
        bread,
        sweets,
        cans,
        dairy,
        meat
    }
    enum currency {
        kg,
        liters,
        amount
    }
    interface IProduct
    {
        int Price{get;set;}
        int Price_DDS { get; set; }
        int Price_Customer { get; set; }
        int Profit();
            
    }
    class Product : IProduct
    {
        private string name;
        private int amount;
        private int price;
        private int price_dds;
        private int price_customer;
        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
        public int Price{
            get { return this.price; }
            set { this.price = value; }
        }
        public int Price_DDS
        {
            get { return this.price_dds; }
            set { this.price_dds = value; }
        }
        public int Price_Customer
        {
            get { return this.price_customer; }
            set { this.price_customer = value; }
        }
        public int Profit()
        { return ( this.Price_Customer - this.Price_Customer)*this.Amount; } 
        public Product(string name,int amount,int price,int price_dds,int price_customer, product_group p, currency c)
        {
            this.Name = name;
            this.Amount = amount;
            this.Price = price;
            this.Price_DDS = price_dds;
            this.Price_Customer = price_customer;
        }
        public string ToString()
        {
            return $"{this.Name} -- {this.Amount} -- {this.Price} лв. -- {this.Price_DDS} лв. -- {this.Price_Customer} лв.";
        }
        public string ProfitString()
        {
            return $"{this.Name} -- {this.Profit()} лв. печалба";
        }
    }
}
