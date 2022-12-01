using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_in_company
{
    public abstract class BaseEmployee
    {
        private string employeeID;
        private string employeeName;
        private string employeeAdress;
        public string EmployeeID
        { get; set; }
        public string EmployeeName
        { get; set; }
        public string EmployeeAdress
        { get; set; }

        public BaseEmployee(string ID, string name, string adress)
        {
            this.EmployeeID = ID;
            this.EmployeeName = name;
            this.EmployeeAdress = adress;
        }

        public virtual string Print()
        {
            return $"{this.EmployeeName} -- {this.EmployeeID} -- {this.EmployeeAdress}";
        }

        public abstract double CalculateSalary(int workHours);
        public abstract string GetDepartament();
    }
}
