
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSI_2017_2
{
    public class Worker
    {
        private string name_worker;
        private string egn;
        private string name_worker_latin;
        private string country;
        private string city;
        private string postcode;

        public string Name_worker
        {
            get { return this.name_worker; }
            set {
                if (value.Length > 50) throw new ArgumentException("Incorrect data!");
                else this.name_worker = value;
            }
        }

        public string EGN
        {
            get { return this.egn; }
            set {
                if (value.Length > 15) throw new ArgumentException("Incorrect data!");
                else this.egn = value;
            }
        }

        public string Name_worker_latin
        {
            get { return this.name_worker_latin; }
            set {
                if (value.Length > 50) throw new ArgumentException("Incorrect data!");
                else this.name_worker_latin = value;
            }
        }

        public string Country
        {
            get { return this.country; }
            set {
                if (value.Length > 30) throw new ArgumentException("Incorrect data!");
                else this.country = value;
            }
        }

        public string City
        {
            get { return this.city; }
            set {
                if (value.Length > 30) throw new ArgumentException("Incorrect data!");
                else this.city = value;
            }
        }

        public string Postcode
        {
            get { return this.postcode; }
            set {
                if (value.Length > 30) throw new ArgumentException("Incorrect data!");
                else this.postcode = value;
            }
        }

        public Worker(string name,string egn,string name_latin,string country,string city, string postcode)
        {
            this.Name_worker = name;
            this.EGN = egn;
            this.Name_worker_latin = name_latin;
            this.Country = country;
            this.City = city;
            this.Postcode = postcode;
        }
        public Worker(string name,string egn,string name_latin,string country)
        {
            this.Name_worker = name;
            this.EGN = egn;
            this.Name_worker_latin = name_latin;
            this.Country = country;
        }

        public Worker(string name, string egn, string country)
        {
            this.Name_worker = name;
            this.EGN = egn;
            this.Country = country;
        }

        public override string ToString()
        {
            return $"{this.Name_worker}, {this.EGN}, {this.Name_worker_latin}, {this.Country}, {this.City}, {this.Postcode}";
        }
        public string Print_post()
        {
            string result = "";
            if (this.Name_worker_latin != "")
            {
                var names = this.Name_worker_latin.Split(' ').ToArray();
                if (names.Length == 1) result = $"{names[0]}@nncomputers.com";
                else if (names.Length == 2) result = $"{names[1]}_{names[0]}@nncomputers.com";
                else if (names.Length == 3) result = $"{names[2]}_{names[0]}_{names[1].First()}@nncomputers.com";

            }
            else result = "Missing data";

            return result;
        }
    }
}
