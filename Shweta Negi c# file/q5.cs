//Write a program to demonstrate the use of various arithmetic, unary, logical, bit-wise, assignment and conditional operators.

using System;

class Program
{
    static void Main()
    {
        int a = 10, b = 5;
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine($"a = {a}, b = {b}");
        Console.WriteLine($"a + b = {a + b}");
        Console.WriteLine($"a - b = {a - b}");
        Console.WriteLine($"a * b = {a * b}");  
        Console.WriteLine($"a / b = {a / b}"); 
        Console.WriteLine($"a % b = {a % b}");  
        Console.WriteLine($"a ^ b = {Math.Pow(a, b)}");  
 
        Console.WriteLine("\nUnary Operators:");
        int x = -a;  
        Console.WriteLine($"Negation of a = {x}");
        int y = +b;  
        Console.WriteLine($"Unary plus of b = {y}");
        bool z = !(a > b);  
        Console.WriteLine($"Logical NOT of (a > b) = {z}");

        Console.WriteLine("\nLogical Operators:");
        bool p = true, q = false;
        Console.WriteLine($"p = {p}, q = {q}");
        Console.WriteLine($"p && q = {p && q}");
        Console.WriteLine($"p || q = {p || q}"); 
        Console.WriteLine($"!p = {!p}");         

        Console.WriteLine("\nBitwise Operators:");
        int m = 5, n = 3; 
        Console.WriteLine($"m = {m}, n = {n}");
        Console.WriteLine($"m & n = {m & n}");  
        Console.WriteLine($"m | n = {m | n}"); 
        Console.WriteLine($"m ^ n = {m ^ n}"); 
        Console.WriteLine($"~m = {~m}");       
        Console.WriteLine($"m << 1 = {m << 1}"); 
        Console.WriteLine($"m >> 1 = {m >> 1}");  

        Console.WriteLine("\nAssignment Operators:");
        int c = 7;
        Console.WriteLine($"Initial c = {c}");
        c += 2;  
        Console.WriteLine($"c += 2  ->  c = {c}");
        c -= 3; 
        Console.WriteLine($"c -= 3  ->  c = {c}");
        c *= 2;  
        Console.WriteLine($"c *= 2  ->  c = {c}");
        c /= 4;  
        Console.WriteLine($"c /= 4  ->  c = {c}");
        c %= 3;  
        Console.WriteLine($"c %= 3  ->  c = {c}");
        c &= 2;  
        Console.WriteLine($"c &= 2  ->  c = {c}");
        c |= 3;  
        Console.WriteLine($"c |= 3  ->  c = {c}");
        c ^= 1;  
        Console.WriteLine($"c ^= 1  ->  c = {c}");

        Console.WriteLine("\nConditional (Ternary) Operator:");
        int age = 20;
        Console.WriteLine($"age = {age}");
        string status = (age >= 18) ? "Adult" : "Minor";
        Console.WriteLine($"Status: {status}");
    }
}
