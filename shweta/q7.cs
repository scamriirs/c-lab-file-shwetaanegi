//write the program to implement recursion
using System;

class Program
{
    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number to find its factorial: ");
        int number = int.Parse(Console.ReadLine());

        int result = Factorial(number);

        Console.WriteLine($"The factorial of {number} is {result}");
    }
}
