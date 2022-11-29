using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using transport_mvc.Models;

namespace transport_mvc.Views
{
    class Display
    {
        public int Km { get; set; }
        public string DayorNight { get; set; }

        public PricePreview PriceEnd;
        public void GetValues()
        {
            this.Km = int.Parse(Console.ReadLine());
            this.DayorNight = Console.ReadLine();
        }
        public Display()
        {
            GetValues();
        }
        public void Print()
        {
            Console.WriteLine(PriceEnd.Price);
        }
    }
}
