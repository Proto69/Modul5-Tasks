using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работници
{
    public abstract class BaseEmployee
    {
        public string EmployeeID { get; }
        public string EmployeeName { get; }
        public string EmployeeAddress { get; }

        public BaseEmployee(string employeeID, string employeeName, string employeeAddress)
        {
            this.EmployeeID = employeeID;
            this.EmployeeName = employeeName;
            this.EmployeeAddress = employeeAddress;
        }

        public void Show()
        {
            Console.WriteLine($"ID: {this.EmployeeID} \nName: {this.EmployeeName} \nAddress: {this.EmployeeAddress}");
        }
        public abstract double CalculateSalary(int workingHours);
        public abstract string GetDepartemnt();
    }
}
