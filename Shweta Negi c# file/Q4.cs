QUESTION write a program to understand the use of library function
using System;

class Program
{
    static void Main()
    {
        double number1 = 9;
        double number2 = 16;
        double sqrt1 = Math.Sqrt(number1);  
        double sqrt2 = Math.Sqrt(number2);  
        double powerResult = Math.Pow(number1, 2); 
        Console.WriteLine($"Square root of {number1} is: {sqrt1}");
        Console.WriteLine($"Square root of {number2} is: {sqrt2}");
        Console.WriteLine($"{number1} raised to the power of 2 is: {powerResult}");

        DateTime currentDateTime = DateTime.Now;  
        DateTime specificDate = new DateTime(2025, 12, 25);  
        TimeSpan difference = specificDate - currentDateTime; 

        Console.WriteLine("\nCurrent Date and Time: " + currentDateTime);
        Console.WriteLine("Specific Date (2025-12-25): " + specificDate);
        Console.WriteLine("Difference between the specific date and now: " + difference.Days + " days");


        string text = "Hello, C# World!";
        string upperText = text.ToUpper();  
        string lowerText = text.ToLower();  
        bool containsWord = text.Contains("C#");  
        Console.WriteLine("\nOriginal Text: " + text);
        Console.WriteLine("Text in Uppercase: " + upperText);
        Console.WriteLine("Text in Lowercase: " + lowerText);
        Console.WriteLine("Does the text contain 'C#'? " + containsWord);

        
        string numberStr = "1234";
        int convertedNumber = Convert.ToInt32(numberStr);  

        Console.WriteLine("\nConverted string '1234' to integer: " + convertedNumber);

        // Random Library Function
        Random rand = new Random();
        int randomNumber = rand.Next(1, 101);  // Generates a random number between 1 and 100

        Console.WriteLine("\nRandom number between 1 and 100: " + randomNumber);
    }
}
