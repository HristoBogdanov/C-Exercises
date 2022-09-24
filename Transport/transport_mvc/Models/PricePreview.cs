using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_mvc.Models
{
    public class PricePreview
    {
        public decimal Price;
        public PricePreview(decimal price)
        {
            this.Price = price;
        }
    }
}
