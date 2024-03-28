using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int FacultyNumber { get; set; }
}

public class SchoolDatabase
{
    private static SchoolDatabase instance;

    private List<Student> students;

    private SchoolDatabase()
    {
        students = new List<Student>();
        Console.WriteLine("---database connection initialized---");
    }

    public static SchoolDatabase GetInstance()
    {
        if (instance == null)
        {
            instance = new SchoolDatabase();
        }

        return instance;
    }

    public void AddStudent(string name, int facultyNumber)
    {
        Student student = new Student { Name = name, FacultyNumber = facultyNumber };
        students.Add(student);
        Console.WriteLine($"|Student {name} with faculty number {facultyNumber} added to the database");
    }

    public void RemoveStudent(string name)
    {
        Student studentToRemove = students.Find(s => s.Name == name);
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
        SchoolDatabase database = SchoolDatabase.GetInstance();

        database.AddStudent("John Doe", 2109010538);
        database.AddStudent("Jane Smith", 2014016723);

        database.RemoveStudent("Jane Smith");
        database.RemoveStudent("Alice Brown");
    }
}