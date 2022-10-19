using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    public class Card
    {
        private string name;
        private string autor;
        private int br;

        public string Name
        {
            get {
                return this.name;
            }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("NO!");
                this.name = value;
            }
        }
        public string Autor {

            get {
                return this.autor;
            }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("NO!");
                this.autor = value;

            }
        }
        public int Br {
            get {
                return this.br;

            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("NO!");
                this.br = value;

            }
        }
        public string Print()
        {
            return $"{this.Name} - {this.Autor} - {this.Br}";
        }


    }
}
