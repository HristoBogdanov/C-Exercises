using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cargo
    {
        private string name_cargo;
        private double weight;

        public Cargo(string name_cargo, double weight)
        {
            this.name_cargo = name_cargo;
            this.weight = weight;
        }
        public string Name_cargo
        {
            get
            {
                return this.name_cargo;
            }
            
        }
        public double Weight
        {
            get { return this.weight; }
        }
    }
}
