using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visual_abstract_buildings
{
    public class Business_building: City
    {
        private string name;
        private int rent_rooms;


        public string Name { get; set; }
        public int Rent_rooms { get; set; }

        public Business_building(string name, int rent_rooms, string building_city, int stars, int rooms) : base(building_city, stars, rooms)
        {
            this.Name = name;
            this.Rent_rooms = rent_rooms;
        }

        public override double RentRoom(double minrz)
        {
            double result = 0;
            if (Stars == 1) result = 0.1 * minrz;
            else if (Stars == 2) result = 0.2 * minrz;
            else if (Stars == 3) result = 0.3 * minrz;
            else if (Stars == 4) result = 0.35 * minrz;
            else if (Stars == 5) result = 0.4 * minrz;
            return result;
        }
    }
}
