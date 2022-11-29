using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_mvc.Models
{
    public abstract class Vehicle
    {
        public decimal DayRate { get; set; }
        public decimal NightRate { get; set; }

        public Vehicle(decimal dayrate,decimal nightrate)
        {
            this.DayRate = dayrate;
            this.NightRate = nightrate;
        }
        public virtual decimal TotalPrice(int km, string dayornight)
        {
            if (dayornight == "day") return DayRate * km;
            else return NightRate * km;
        }
    }
}
