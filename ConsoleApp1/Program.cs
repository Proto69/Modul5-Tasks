using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    public class Solution
    {

        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            Dictionary<string, int> dict = new();
            for (int i = 0; i < employees.Count; i++)
            {
                if (!dict.ContainsKey(employees[i].Company))
                {
                    List<Employee> list = new() { employees[i] };
                    for (int j = 0; j < employees.Count; j++)
                    {
                        if (employees[j].Company == list[0].Company)
                        {
                            list.Add(employees[j]);
                        }
                    }
                    double sum = 0;
                    double n = 0;
                    foreach (var item in list)
                    {
                        sum += item.Age;
                        n++;
                    }
                    double a = sum / n;
                    int b = (int)Math.Round(a);
                    dict.Add(list[0].Company, b);
                }
            }
            dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            return dict;
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            Dictionary<string, int> dict = new();
            for (int i = 0; i < employees.Count; i++)
            {
                if (!dict.ContainsKey(employees[i].Company))
                {
                    List<Employee> list = new() { employees[i] };
                    for (int j = 0; j < employees.Count; j++)
                    {
                        if (employees[j].Company == list[0].Company)
                        {
                            list.Add(employees[j]);
                        }
                    }
                    int b = list.Count - 1;
                    dict.Add(list[0].Company, b);
                }
            }
            dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            return dict;
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            Dictionary<string, Employee> dict = new();
            for (int i = 0; i < employees.Count; i++)
            {
                if (!dict.ContainsKey(employees[i].Company))
                {
                    List<Employee> list = new() { employees[i] };
                    for (int j = 0; j < employees.Count; j++)
                    {
                        if (employees[j].Company == list[0].Company)
                        {
                            list.Add(employees[j]);
                        }
                    }
                    int maxAge = 0;
                    Employee maxEmployee = employees[0];
                    foreach (var item in list)
                    {
                        if (item.Age > maxAge)
                        {
                            maxAge = item.Age;
                            maxEmployee = item;
                        }
                    }
                    dict.Add(list[0].Company, maxEmployee);
                }
            }
            dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            return dict;
        }

        public static void Main()
        {
            int countOfEmployees = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();

            for (int i = 0; i < countOfEmployees; i++)
            {
                string str = Console.ReadLine();
                string[] strArr = str.Split(' ');
                employees.Add(new Employee(strArr[0], strArr[1], int.Parse(strArr[3]), strArr[2]));
            }

            foreach (var emp in AverageAgeForEachCompany(employees))
            {
                Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in CountOfEmployeesForEachCompany(employees))
            {
                Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in OldestAgeForEachCompany(employees))
            {
                Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
            }
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }

        public Employee(string f, string l, int a, string c)
        {
            this.FirstName = f;
            this.LastName = l;
            this.Age = a;
            this.Company = c;
        }
    }
}