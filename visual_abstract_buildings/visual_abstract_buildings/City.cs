using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visual_abstract_buildings
{
    public abstract class City
    {
        private string building_city;
        private int stars;
        private int rooms;

        public string Building_city { get; set; }
        public int Stars { get; set; }
        public int Rooms { get; set; }

        public City(string building_city, int stars, int rooms)
        {
            this.Building_city = building_city;
            this.Stars = stars;
            this.Rooms = rooms;
        }
        public abstract double RentRoom(double minrz);
         
        
    }
}
