using System;
using System.Collections.Generic;

class Student
{
    public string RegistrationNumber { get; set; }
    public int Age { get; set; }
    public string Class { get; set; }
    public string FullName { get; set; }
    public string Gender { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Reg No: {RegistrationNumber}, Name: {FullName}, Age: {Age}, Class: {Class}, Gender: {Gender}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { RegistrationNumber = "REG001", FullName = "Alice Johnson", Age = 14, Class = "8A", Gender = "Female" },
            new Student { RegistrationNumber = "REG002", FullName = "Bob Smith", Age = 15, Class = "9B", Gender = "Male" },
            new Student { RegistrationNumber = "REG003", FullName = "Carol Davis", Age = 14, Class = "8A", Gender = "Female" },
            new Student { RegistrationNumber = "REG004", FullName = "David Lee", Age = 16, Class = "10C", Gender = "Male" },
            new Student { RegistrationNumber = "REG005", FullName = "Eva Brown", Age = 13, Class = "7B", Gender = "Female" },
            new Student { RegistrationNumber = "REG006", FullName = "Frank Miller", Age = 15, Class = "9A", Gender = "Male" },
            new Student { RegistrationNumber = "REG007", FullName = "Grace Wilson", Age = 14, Class = "8B", Gender = "Female" },
            new Student { RegistrationNumber = "REG008", FullName = "Henry Moore", Age = 16, Class = "10A", Gender = "Male" },
            new Student { RegistrationNumber = "REG009", FullName = "Ivy Taylor", Age = 13, Class = "7C", Gender = "Female" },
            new Student { RegistrationNumber = "REG010", FullName = "Jack Anderson", Age = 15, Class = "9C", Gender = "Male" }
        };

        Console.WriteLine("Student Database:\n");
        foreach (var student in students)
        {
            student.DisplayInfo();
        }

        Console.ReadLine(); 
    }
}
