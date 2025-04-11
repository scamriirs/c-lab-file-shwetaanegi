using System;

namespace BoilerMonitoringSystem
{
    // Delegate for alert event
    public delegate void AlertEventHandler(string message);

    class Boiler
    {
        // Event declaration
        public event AlertEventHandler Alert;

        // Safe limits
        private const int MaxTemp = 120;
        private const int MaxPressure = 200;
        private const int MaxWaterLevel = 80;

        // Method to check input values
        public void Monitor(int temp, int pressure, int waterLevel)
        {
            if (temp > MaxTemp)
                Alert?.Invoke($"⚠️ ALERT: Temperature {temp}°C exceeds limit ({MaxTemp}°C)!");

            if (pressure > MaxPressure)
                Alert?.Invoke($"⚠️ ALERT: Pressure {pressure} psi exceeds limit ({MaxPressure} psi)!");

            if (waterLevel > MaxWaterLevel)
                Alert?.Invoke($"⚠️ ALERT: Water Level {waterLevel}% exceeds limit ({MaxWaterLevel}%)!");

            if (temp <= MaxTemp && pressure <= MaxPressure && waterLevel <= MaxWaterLevel)
                Console.WriteLine("✅ All parameters are within safe limits.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Boiler boiler = new Boiler();

            // Subscribe to the Alert event
            boiler.Alert += ShowAlert;

            // Input from user
            Console.Write("Enter Temperature (°C): ");
            int temp = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Pressure (psi): ");
            int pressure = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Water Level (%): ");
            int waterLevel = Convert.ToInt32(Console.ReadLine());

            // Monitor values
            boiler.Monitor(temp, pressure, waterLevel);
        }

        // Event handler method
        static void ShowAlert(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
