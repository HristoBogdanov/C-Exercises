using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Console
{
    public class Employee
    {
        private string name_e;
        private double salary;
        private string job;
        private string area;
        private string email;
        private int age;

        public string Name_e
        {
            get { return this.name_e; }
            set { if (value == null) throw new ArgumentException("Invalid input");
                else this.name_e = value;
            }
        }

        public double Salary
        {
            get { return this.salary; }
            set {
                if (value == 0) throw new ArgumentException("Invalid input");
                else this.salary = value;
            }
        }

        public string Job
        {
            get { return this.job; }
            set
            {
                if (value == null) throw new ArgumentException("Invalid input");
                else this.job = value;
            }
        }

        public string Area
        {
            get { return this.area; }
            set {
                if (value == null) throw new ArgumentException("Invalid input");
                else this.area = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Employee(string name_e,double salary,string job,string area,string email,int age)
        {
            this.Name_e = name_e;
            this.Salary = salary;
            this.Job = job;
            this.Area = area;
            this.Email = email;
            this.Age = age;
        }
        public string Print()
        {
            return $"{this.Name_e} -- {this.Salary} -- {this.Email} -- {this.Age}";
        }
    }
}
