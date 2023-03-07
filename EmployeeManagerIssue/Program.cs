// See https://aka.ms/new-console-template for more information
using EmployeeManagerIssue;

Console.WriteLine("Hello, World!");

Manager manager = new Manager { Name = "Nick" };
Employee employee = new Employee { Name = "John" };

PrintMethod.PrintEmployeeName(manager);
PrintMethod.PrintEmployeeName(employee);
