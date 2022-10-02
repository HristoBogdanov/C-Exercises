using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visual_abstract_buildings
{
    public class Hotel: City
    {
        private string name;
        private int floors;

        public string Name { get; set; }
        public int Floors { get; set; }

        public Hotel(string name,int floors,string building_city,int stars,int rooms):base(building_city,stars,rooms)
        {
            this.Name = name;
            this.Floors = floors;
        }
        public override double RentRoom(double minrz)
        {
            double result = 0;
            if (Floors > 3 && Stars > 3) result = 0.15 * minrz + Stars * 1.20;
            else if (Stars < 3 && Floors > 3) result = 0.15 * minrz;
            else if (Stars > 3 && Floors < 3) result = 0.10 * minrz;
            return result;
        }
    }
}
