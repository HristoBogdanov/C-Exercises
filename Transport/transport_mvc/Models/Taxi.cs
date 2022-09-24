using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_mvc.Models
{
    public class Taxi:Vehicle
    {
        private const decimal startrate = 0.90M;
        private const decimal dayrate = 0.99M;
        private const decimal nightrate = 1.20M;

        public Taxi() : base(dayrate,nightrate)
        {

        }

        public override decimal TotalPrice(int km, string dayornight)
        {
            return base.TotalPrice(km, dayornight)+startrate;
        }
    }
}
