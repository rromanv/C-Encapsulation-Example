using System;

namespace EmployeeApp
{
  class Employee
  {
    private string _empName;

    public string GetName() => _empName;

    public void SetName(string newName) => Name = newName;

    public string Name
    {
      get { return _empName; }
      set
      {
        if (value.Length > 15)
        {
          Console.WriteLine("Error! Name length exceeds 15 characters!");
        }
        else
        {
          _empName = value;
        }

      }
    }
    private int _empAge;
    public int Age
    {
      get => _empAge;
      set => _empAge = value;
    }

    public double Pay { get; set; }

    private string _empSSN;
    public string SSN
    {
      get => _empSSN;
      private set => _empSSN = value;
    }

    public Employee() { }

    public Employee(string name, int age, double pay, string ssn)
    {
      _empName = name;
      _empAge = age;
      Pay = pay;
      SSN = ssn;
    }

    public void ShowData()
    {
      Console.WriteLine("Employee Name: {0}", _empName);
      Console.WriteLine("Employee Age: {0}", _empAge);
      Console.WriteLine("Employee Pay: {0}", Pay);
    }
  }
}