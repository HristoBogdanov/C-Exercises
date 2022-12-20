using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statichni_chlenove_zad1
{
    static class Magazin
    {
        private static List<Produkt> produkti = new List<Produkt>();
        public static void Add(string name, string barcode, double price, double quantity)
        {
            Produkt produkt = new Produkt();
            produkt.Barcode = barcode;
            produkt.Name = name;
            produkt.Price = price;
            produkt.Quantity = quantity;
            Magazin.produkti.Add(produkt);

        }
        public static void Load(string barcode, double quantity)
        {
            int br = 0;

            foreach (Produkt x in produkti)
            {
                if (barcode == x.Barcode) { x.Quantity = x.Quantity + quantity; br++; }
            }
            if(br==0) MessageBox.Show("Няма такъв продукт");
        }
        public static void SellProduct(string barcode, double quantity)
        {
            int br = 0;
            
            



        }
        public static string Print(string name, string barcode, double price, double quantity)
        {
            Produkt produkt = new Produkt();
            produkt.Barcode = barcode;
            produkt.Name = name;
            produkt.Price = price;
            produkt.Quantity = quantity;
            return $"{produkt.Name} - {produkt.Barcode} - {produkt.Price} - {produkt.Quantity}";
        }
        public static void SortByName(ListBox lista)
        {
            Magazin.produkti = Magazin.produkti.OrderBy(x => x.Name).ToList();
            foreach (Produkt x in produkti)
            {
                if (x.Quantity != 0) lista.Items.Add(x.Name + "<->" + x.Barcode);
            }
        }
        public static void OrderByUnavailable(ListBox listu)
        {
            Magazin.produkti = Magazin.produkti.OrderBy(x => x.Name).ToList();
            foreach (Produkt x in produkti)
            {
                if (x.Quantity == 0) listu.Items.Add(x.Name + "->" + x.Barcode + "<->" + x.Quantity);
            }
        }
        public static void OrderByDescending(ListBox listd)
        {
            Magazin.produkti = Magazin.produkti.OrderBy(x => x.Name).ToList();
            foreach(Produkt x in produkti)
            {
                listd.Items.Add(x.Name + "<->" + x.Barcode + "<->" + x.Quantity);
            }
        }
        public static double Calculate()
        {
            double sum = 0;
            foreach (Produkt x in produkti)
            {
                sum = sum + x.Price * x.Quantity;
            }
            return sum;
        }
    }
}
    

