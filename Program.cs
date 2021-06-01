using System;
using EmployeeApp;

Employee emp = new Employee("John", 30, 10_000, "999-99-9999");

emp.ShowData();

Console.WriteLine(emp.GetName());

emp.SetName("John Doe");

Console.WriteLine(emp.GetName());


emp.Name = "John is a really cool guy who know how to code";
Console.WriteLine(emp.GetName());
Console.WriteLine(emp.Name);


emp.SetName("John is a really cool guy who know how to code");

emp.Age = 33;
emp.ShowData();
Console.WriteLine(emp.Pay);

Console.WriteLine(emp.SSN);
