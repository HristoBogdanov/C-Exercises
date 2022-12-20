using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statichni_chlenove_zad1
{
    public class Produkt
    {
        private string name;
        private string barcode;
        private double price;
        private double quantity;
        public string Name {
            get { return this.name; }
            set { if (string.IsNullOrEmpty(value)) throw new ArgumentException("Невалидни данни");
                else this.name = value;
            }
        }
        public string Barcode
        {
            get { return this.barcode; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Невалидни данни");
                else this.barcode = value;
            }
        }
        public double Price
        {
            get { return this.price; }
            set
            {
                if (value<=0) throw new ArgumentException("Невалидни данни");
                else this.price = value;
            }
        }
        public double Quantity
        {
            get { return this.quantity; }
            set
            {
                if (value<=0) throw new ArgumentException("Невалидни данни");
                else this.quantity = value;
            }
        }
    }
}
