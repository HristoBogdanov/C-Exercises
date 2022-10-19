using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    class Shop
    {
        private string name;
        private List<Part> parts;

        public string Name => this.name;
        public List<Part> Parts => this.parts;

        public Shop(string name)
        {
            this.name = name;
            this.parts = new List<Part>();
        }

        public void AddPart(Part part)
        {
            this.parts.Add(part);
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
