using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
   public interface Person
    {
        string Name
        { get; set; }
        string LastName
        { get; set; }
        int BirthDate
        { get; set; }

        
    }
    public class Student : Person
    {
        private string name;
        private string lastname;
        private int birthDate;
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value;}
        }
        public string LastName
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }
        public int BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }
        public Student(string name, string lastname, int birthDate)
        {
            this.Name = name;
            this.LastName = lastname;
            this.BirthDate = birthDate;
        }
        public string Age()
        {
            return (2021 - BirthDate).ToString();
        }
        public string IsHeStudent()
        {
            int Age = 2021 - BirthDate;
            if (Age >= 7 && Age <= 19) return "Ученик";
            else return "Не е ученик";
        }
        public string ToString()
        {
            return $"{this.Name} {this.LastName} - {this.BirthDate}г. - {this.Age()} години - {this.IsHeStudent()}";
        }
    }
}
