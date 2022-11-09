using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSI___2019
{
    public class Star
    {
        private string name_star;
        private double length;
        private int type;
        private double mass;
        private string alignment;

        public string Name_star
        {
            get { return this.name_star; }
            set {
                if (value.Length > 20) throw new ArgumentException("Incorrect data!");
                else this.name_star = value;
            }
        }
        public double Length
        {
            get { return this.length; }
            set {
                if (value < 0) throw new ArgumentException("Incorrect data!");
                else this.length = value;
            }
        }

        public int Type
        {
            get { return this.type; }
            set {
                if (value < 0 || value > 9) throw new ArgumentException("Incorrect data!");
                else this.type = value;
            }
        }

        public double Mass
        {
            get { return this.mass; }
            set
            {
                if (value < 0) throw new ArgumentException("Incorrect data!");
                else this.mass = value;
            }
        }
        
        public string Alignment
        {
            get { return this.alignment; }
            set {
                if (value.Length > 30) throw new ArgumentException("Incorrect data!");
                else this.alignment = value;
            }
        }

        public Star(string name_star,double length,int type,double mass,string alignment)
        {
            this.Name_star = name_star;
            this.Length = length;
            this.Type = type;
            this.Mass = mass;
            this.Alignment = alignment;
        }
        public string Type_string()
        {
            string result;
            int type_pom = this.Type;
            switch (type_pom)
            {
                case 1: result = "хипергигант";
                    break;
                case 2:
                    result = "свръхгигант";
                    break;
                case 3:
                    result = "ярък гигант";
                    break;
                case 4:
                    result = "гигант";
                    break;
                case 5:
                    result = "субгигант";
                    break;
                case 6:
                    result = "джудже";
                    break;
                case 7:
                    result = "субджудже";
                    break;
                case 8:
                    result = "червено джудже";
                    break;
                case 9:
                    result = "кафяво джудже";
                    break;
            }
        }
        public override string ToString()
        {
            return $"{this.Name_star}, {this.Length} св.г., {this.Type_string()}, {this.Mass} сл.м., {this.Alignment}";
        }
    }
}
