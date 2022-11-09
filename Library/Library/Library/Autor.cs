using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Autor
    {
        private string name;
        private string lastname;
        private int birth_year;
        private string death_year;
        private List<Book> books;

        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Birth_year { get; set; }
        public string Death_year { get; set; }
        public List<Book> Books  { get; set; }
        public Autor(string name, string lastname, int birth_year, string death_year)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Birth_year = birth_year;
            this.Death_year = death_year;
            
        }
        public string AliveorDeath()
        {
            if (this.Death_year=="") return "-";
            else return this.Death_year;
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
    }
}
