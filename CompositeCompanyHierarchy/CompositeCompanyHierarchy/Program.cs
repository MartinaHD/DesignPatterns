using System;
using System.Collections.Generic;
using System.ComponentModel;

public abstract class EmployeeComponent
{
    protected readonly List<EmployeeComponent> _employees = new List<EmployeeComponent>();

    public abstract void DisplayDetails(int depth);

    public void Add(EmployeeComponent employee)
    {
        _employees.Add(employee);
    }

    public void Remove(EmployeeComponent employee)
    {
        _employees.Remove(employee);
    }
}

public class Department : EmployeeComponent
{
    private readonly string name;

    public Department(string name)
    {
        this.name = name;
    }

    public override void DisplayDetails(int depth)
    {
        Console.WriteLine(new String(' ', depth) + $"Department: {name} with employees: ");
        Console.WriteLine("----------------------------------------------"); 
        foreach (EmployeeComponent employee in _employees) 
        { 
            employee.DisplayDetails(depth + 2); 
        } 
        Console.WriteLine("\n"); }
}

public class Employee : EmployeeComponent
{
    private readonly string name;
    private readonly string position;
    public Employee(string name, string position)
    {
        this.name = name;
        this.position = position;
    }

    public override void DisplayDetails(int depth)
    {
        Console.WriteLine(new String(' ', depth) + $"Employee: {name}, Position: {position}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeComponent empl1 = new Employee("John Doe", "Developer");
        EmployeeComponent empl2 = new Employee("Jane Smith", "Manager");

        Department development = new Department("Development");
        development.Add(empl1);
        development.Add(empl2);

        //development.Remove(empl1);

        EmployeeComponent empl3 = new Employee("Alice Johnson", "Tester");

        Department testing = new Department("Testing");
        testing.Add(empl3);

        Department company = new Department("Company");
        company.Add(development);
        company.Add(testing);

        company.DisplayDetails(1);
    }
}