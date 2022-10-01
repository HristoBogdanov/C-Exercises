using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uchashti
{
    public class Bachelor:Student
    {
        private double grade_last_year;

        public double Grade_last_year { get; set; }

        public Bachelor(double grade_last_year, string name, string surname, string fac_number, string speciality) : base(name, surname, fac_number, speciality)
        {
            this.Grade_last_year = grade_last_year;
        }
        public override string Internship()
        {
            string result;
            if (this.Grade_last_year > 5) result = "Personal assistant of the proffessor";
            else result = "Internship in the educational department";
            return result;
        }
        public override double Fee(double min_rzapl)
        {
            double result;
            if (this.Grade_last_year > 5) result = (min_rzapl / 100) * 20;
            else result = (min_rzapl / 100) * 30;
            return result;
        }
    }
}
