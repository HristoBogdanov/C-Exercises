using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public enum Janr
    {
        Kriminalen,
        Treilur,
        Poeziq,
        Fantastika,
        Detski,
        Prikliuchenski
    }
    public class Book
    {
        private string name;
        private Janr janr;
        private string kat_nomer;

        public string Name { get; set; }
        public Janr Janr { get; set; }
        public string Kat_nomer { get; set; }
        public Book(string name, Janr janr, string kat_nomer)
            {
            this.Name = name;
            this.Janr = janr;
            this.Kat_nomer = kat_nomer;
            }         
    }
}
