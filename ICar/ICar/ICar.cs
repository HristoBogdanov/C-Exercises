using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICar
{
    interface ICar
    {
        string Model
        {
            get; set;
        }
        string Color
        {
            get; set;
        }
        int Year
        {
            get; set;
        }
        
    }
    public class Seat : ICar
    {
        private string model;
        private string color;
        private int year;
        
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        public String Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public Seat(string model, string color, int year)
        {
            this.Model = model;
            this.Color = color;
            this.Year = year;
        }
        public override string ToString()
        {
            return $"{this.Model} -- {this.Color} -- {this.Year}";
        }
    }
}
