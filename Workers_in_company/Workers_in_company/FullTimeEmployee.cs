using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_in_company
{
    public class FullTimeEmployee : BaseEmployee
    {
        private int workingHours;
        private string employeePosition, employeeDepartament;
        public string EmployeePosition { get; set; }
        public string EmployeeDepartament { get; set; }
        public int WorkingHours

        {
            get { return this.workingHours; }
            set { this.workingHours = value; }
        }
        public FullTimeEmployee(string id, string name, string adress, string position, string departament) : base(id, name, adress)
        {
            this.EmployeeDepartament = departament;
            this.EmployeePosition = position;
        }

        public override string Print()
        {
            return $"{base.Print()}{Environment.NewLine}{this.EmployeePosition}{Environment.NewLine}{this.EmployeeDepartament} \n";
        }

        public override double CalculateSalary(int workHours)
        {
            this.WorkingHours = workHours;
            return 250 + workHours * 10.80;
        }
        public override string GetDepartament()
        {
            return this.EmployeeDepartament;
        }
        
    }
}
