﻿#nullable enable warnings

namespace NewStuffInCSharp8
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string? EmployeeJob { get; set; }

        public Employee(int id, string name)
        {
            EmployeeID = id;
            EmployeeName = name;
            EmployeeJob = null;
        }

        public Employee(int id, string name, string job)
        {
            EmployeeID = id;
            EmployeeName = name;
            EmployeeJob = job;
        }
    }

    public class WorkingWithNulls
    {
        public static void Output()
        {
            var jack = new Employee(1, "Jack Wilson");
            Console.WriteLine(CapitalizeJob(jack));
        }

        static string CapitalizeJob(Employee employee) =>
            employee.EmployeeJob?.ToUpper() ?? "No Job";

    }
}
