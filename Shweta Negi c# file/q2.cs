
//QUESTION2 Write program to show the use of various data types availabe in c#
using System;
class Program
{
    static void Main()
    {
        int age = 25; 
        float weight = 70.5f; 
        double height = 5.9; 
        decimal price = 199.99m; 
        bool isActive = true;
        char grade = 'A'; 

        string name = "DEV VERMA"; 
        object obj = "Hello"; 

        Console.WriteLine("Integer : " + age);
        Console.WriteLine("Float : " + weight);
        Console.WriteLine("Double : " + height);
        Console.WriteLine("Decimal : " + price);
        Console.WriteLine("Boolean : " + isActive);
        Console.WriteLine("Character : " + grade);
        Console.WriteLine("String : " + name);
        Console.WriteLine("Object: " + obj);
    }
}