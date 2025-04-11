using System;

class Car
{
    // Fields of the class
    public string Make;
    public string Model;
    public int Year;

    // Constructor that initializes the fields
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        Console.WriteLine("A new car object has been created!");
    }

    // Method to display the car details
    public void DisplayDetails()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a new object of class Car, which will call the constructor
        Car myCar = new Car("Toyota", "Corolla", 2020);

        // Display the details of the car
        myCar.DisplayDetails();

        // Another example: creating another car object
        Car anotherCar = new Car("Honda", "Civic", 2022);
        anotherCar.DisplayDetails();
    }
}
