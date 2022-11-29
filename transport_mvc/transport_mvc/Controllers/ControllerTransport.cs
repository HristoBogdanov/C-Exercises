using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using transport_mvc.Views;
using transport_mvc.Models;

namespace transport_mvc.Controllers
{
    public class ControllerTransport
    {
        private Display display;
        private Vehicle vehicle;

        public ControllerTransport()
        {
            display = new Display();
        }

        public void Start()
        {
            if (display.Km < 20) vehicle = new Taxi();
            else if (display.Km >= 20 && display.Km <= 100) vehicle = new Bus();
            else vehicle = new Train();

            decimal Total = vehicle.TotalPrice(display.Km, display.DayorNight);
            PricePreview pricepreview = new PricePreview(Total);
            display.PriceEnd = pricepreview;
            display.Print();

        }


    }
}
