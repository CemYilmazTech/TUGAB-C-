using System;

class SpeedConverter
{
    static void Main()
    {
        double speedKmh;
        const double kmhToMs = 1000.0 / 3600.0; // Conversion factor from km/h to m/s

        while (true)
        {
            Console.WriteLine("Enter the speed in km/h for conversion to m/s or type 'exit' to quit:");
            string input = Console.ReadLine().Trim();

            if (input.ToLower() == "exit")
                break;

            while (!double.TryParse(input, out speedKmh) || speedKmh < 0)
            {
                if (input.ToLower() == "exit")
                    return;

                if (!double.TryParse(input, out speedKmh))
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                else if (speedKmh < 0)
                    Console.WriteLine("Speed cannot be negative. Enter a non-negative number:");

                input = Console.ReadLine().Trim();
            }

            double speedMs = speedKmh * kmhToMs;
            Console.WriteLine($"{speedKmh} km/h = {speedMs:F2} m/s\n");
        }
    }
}