using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работници
{
    public class FullTimeEmployee : BaseEmployee
    {
        public string EmployeePosition { get; }
        public string EmployeeDepartment { get; }

        public FullTimeEmployee(string employeeID, string employeeName, string employeeAddress, string employeePosition, string employeeDepartment) : base(employeeID, employeeName, employeeAddress)
        {
            this.EmployeePosition = employeePosition;
            this.EmployeeDepartment = employeeDepartment;
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Position: {this.EmployeePosition} \nDepartment: {this.EmployeeDepartment}");
        }

        public override double CalculateSalary(int workingHours)
        {
            double result = 250 + workingHours * 10.80;    
            return result;
        }

        public override string GetDepartemnt()
        {
            return this.EmployeeDepartment;
        }
    }
}
