using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== Student Registration Form =====");

        Console.Write("Enter Registration Number: ");
        string regNo = Console.ReadLine();

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        string age = Console.ReadLine();

        Console.Write("Enter Class: ");
        string studentClass = Console.ReadLine();

        Console.Write("Enter Gender (Male/Female/Other): ");
        string gender = Console.ReadLine();

        Console.Write("Enter Address: ");
        string address = Console.ReadLine();

        Console.WriteLine("\n--- Registration Details ---");
        Console.WriteLine($"Registration No: {regNo}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Class: {studentClass}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Address: {address}");

        Console.WriteLine("\n✅ Registration Successful!");
    }
}
