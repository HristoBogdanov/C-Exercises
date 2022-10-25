using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citizen
{
    interface IPerson
    {
        string Name
        { get; set; }
        int Age
        { get; set; }
       
    }
    public class Citizen : IPerson
    {
        private string name;
        private int age;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public Citizen(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }
        public override string ToString()
        {
            return $"{this.Name}  -- {this.Age}";
        }
    }
}
