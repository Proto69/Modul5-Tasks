using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работници
{
    public class ContractEmployee : BaseEmployee
    {
        public string EmployeeTask { get; }
        public string EmployeeDepartment { get; }

        public ContractEmployee(string employeeID, string employeeName, string employeeAddress, string employeeTask, string employeeDepartment) : base(employeeID, employeeName, employeeAddress)
        {
            this.EmployeeTask = employeeTask;
            this.EmployeeDepartment = employeeDepartment;
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Task {this.EmployeeTask} \nDepartment: {this.EmployeeDepartment}");
        }

        public override double CalculateSalary(int workingHours)
        {
            double result = 250 + workingHours * 20.00;
            return result;
        }

        public override string GetDepartemnt()
        {
            return this.EmployeeDepartment;
        }
    }
}
