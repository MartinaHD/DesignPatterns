using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }

    public int FacultyNumber { get; set; }
}

public class SchoolDatabase
{
    private static SchoolDatabase schoolDatabaseInstance;

    private readonly List<Student> students;

    private SchoolDatabase()
    {
        students = new List<Student>();
        Console.WriteLine("---database connection initialized---");
    }

    public static SchoolDatabase GetInstance()
    {
        schoolDatabaseInstance ??= new SchoolDatabase();

        return schoolDatabaseInstance;
    }

    public void AddStudent(string name, int facultyNumber)
    {
        Student student = new Student { Name = name, FacultyNumber = facultyNumber };
        students.Add(student);
        Console.WriteLine($"|Student {name} with faculty number {facultyNumber} added to the database");
    }

    public void RemoveStudent(string name)
    {
        Student studentToRemove = students.FirstOrDefault(s => s.Name == name);

        if (studentToRemove != null)
        {
            students.Remove(studentToRemove);
            Console.WriteLine($"|Student {name} removed from the database");
        }
        else
        {
            Console.WriteLine($"|Student {name} not found in the database");
        }
    }
}

public class SchoolManagementSystem
{
    public static void Main()
    {
        SchoolDatabase schoolDatabase = SchoolDatabase.GetInstance();

        schoolDatabase.AddStudent("John Doe", 2109010538);
        schoolDatabase.AddStudent("Jane Smith", 2014016723);

        schoolDatabase.RemoveStudent("Jane Smith");
        schoolDatabase.RemoveStudent("Alice Brown");
    }
}