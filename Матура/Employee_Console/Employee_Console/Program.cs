using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double salary;
            string job;
            string area;
            string email;
            int age;
            List<Employee> employees = new List<Employee>();
            string input = Console.ReadLine();

            do
            {
                var pom = input.Split(' ').ToArray();
                name = pom[0];
                salary = int.Parse(pom[1]);
                job = pom[2];
                area = pom[3];
                if (pom[4] != "") email = pom[4];
                else email = "n/a";

                if (pom[5] != "") age = int.Parse(pom[5]);
                else age = -1;
                Employee employee = new Employee(name, salary, job, area, email, age);
                employees.Add(employee);

                input = Console.ReadLine();
            }
            while (input != null);

            foreach (Employee x in employees) Console.WriteLine(x.Print());
        }
    }
}
