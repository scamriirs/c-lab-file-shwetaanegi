//Demonstrate the use of pass by value and pass by reference by writing a program.

using System;

class Program
{
    static void PassByValue(int num)
    {
        num = 100; 
        Console.WriteLine("Inside PassByValue function: " + num);
    }


    static void PassByReference(ref int num)
    {
        num = 200;  
        Console.WriteLine("Inside PassByReference function: " + num);
    }

    static void Main(string[] args)
    {
        
        int a = 10;
        Console.WriteLine("Before PassByValue function: " + a);
        PassByValue(a); 
        Console.WriteLine("After PassByValue function: " + a);  

        Console.WriteLine();  
        int b = 10;
        Console.WriteLine("Before PassByReference function: " + b);
        PassByReference(ref b); 
        Console.WriteLine("After PassByReference function: " + b); 
    }
}
