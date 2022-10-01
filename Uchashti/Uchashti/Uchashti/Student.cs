using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uchashti
{
    public abstract class Student
    {
        private string name;
        private string surname;
        private string fac_number;
        private string speciality;

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fac_number { get; set; }
        public string Speciality { get; set; }

        public Student(string name, string surname, string fac_number, string speciality)
        {
            this.Name = name;
            this.Surname = surname;
            this.Fac_number = fac_number;
            this.Speciality = speciality;
        }

        public abstract string Internship();
        public abstract double Fee(double min_rzapl);
    }
}
