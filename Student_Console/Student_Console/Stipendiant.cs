using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Console
{
    public class Stipendiant : IStudent, IScholorship
    {
        private string name;
        private List<int> ocenki;
        private double income;

        public string Name { get; set; }
        public List<int> Ocenki { get; set; }
        public double Income { get; set; }

        public Stipendiant(string name, List<int> ocenki, double income)
        {
            this.Name = name;
            this.Ocenki = ocenki;
            this.Income = income;
        }

        public double AverageSuccess()
        {
            return Ocenki.Average();
        }

         public bool Approval()
        {
            if (this.AverageSuccess() >= 5.50) return true;
            else if (this.AverageSuccess() >= 4.50 && this.Income <= 680) return true;
            else return false;
        }
        public string KindScholarship()
        {
            string result = "";
            if (this.AverageSuccess() >= 5.50)result= "Стипендия за успех.";
            else if (this.AverageSuccess() >= 4.50 && this.Income <= 680) result= "Социална стипендия.";
            return result;
        }
        public double Suma()
        {
            double result=0;
            if (this.KindScholarship() == "Стипендия за успех.") result = 150;
            else if (this.KindScholarship() == "Социална стипендия.") result = 200;
            else result = 0;
            return result;
        }
        public string Info()
        {
            return $"{this.Name} -- {this.AverageSuccess()} -- {this.Approval()} -- {this.Suma()}";
        }
    }
}
