using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uchashti
{
    public class Mater : Student
    {
        private double certificate_grade;
        public double Certificate_grade { get; set; }

        public Mater(double certificate_grade, string name, string surname, string fac_number, string speciality) : base(name, surname, fac_number, speciality)
        {
            this.Certificate_grade = certificate_grade;
        }
        public override string Internship()
        {
            string result;
            if(this.Certificate_grade>5.5) result = "Partner Firm";
            else result = "The student is obligated to choose a location by himself";
            return result;
        }
        public override double Fee(double min_rzapl)
        {
            double result;
            if (this.Certificate_grade > 5.5) result = (min_rzapl / 100) * 45;
            else result = (min_rzapl) * 65;
            return result;
        }
    }
}
