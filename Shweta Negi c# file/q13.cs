using System;

class AdmissionEnquiry
{
    // Fields
    public string FullName;
    public int Age;
    public string CourseInterested;
    public string ContactNumber;
    public string Email;

    // Method to take user input
    public void FillForm()
    {
        Console.WriteLine("=== Admission Enquiry Form ===");

        Console.Write("Enter your full name: ");
        FullName = Console.ReadLine();

        Console.Write("Enter your age: ");
        Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter course you are interested in: ");
        CourseInterested = Console.ReadLine();

        Console.Write("Enter your contact number: ");
        ContactNumber = Console.ReadLine();

        Console.Write("Enter your email address: ");
        Email = Console.ReadLine();
    }

    // Method to display the enquiry summary
    public void DisplaySummary()
    {
        Console.WriteLine("\n=== Enquiry Summary ===");
        Console.WriteLine($"Name            : {FullName}");
        Console.WriteLine($"Age             : {Age}");
        Console.WriteLine($"Interested Course: {CourseInterested}");
        Console.WriteLine($"Contact Number  : {ContactNumber}");
        Console.WriteLine($"Email           : {Email}");
        Console.WriteLine("=============================");
    }
}

class Program
{
    static void Main(string[] args)
    {
        AdmissionEnquiry enquiry = new AdmissionEnquiry();
        enquiry.FillForm();
        enquiry.DisplaySummary();
    }
}