using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabotnik
{
    public class Rabotnik
    {
        public string ime;
        public string rabota;
        public double hours;
        public int pari;

        public double zaplata() {
            return hours * pari;
        }
        public double Hours {
            get
            {
                return this.hours;

            }
            set {
                if (hours < 0)
                    throw new ArgumentException("Часовете не могат да бъдат отрицателно число");
                this.hours = value;
            }
        }
        public int Pari {
            get {
                return this.pari;
            }
            set {
                if (pari < 10)
                    throw new ArgumentException("Заплащането не може да бъде по-малко от 10лв.");
                this.pari = value;
            }
        }
        public string Print() {
            return $"{this.ime} - {this.rabota} - {zaplata()}";
        }
    }
}
