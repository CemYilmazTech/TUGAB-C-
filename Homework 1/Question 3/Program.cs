while (true)
{
    Console.WriteLine("Choose conversion type: 1 - Celsius to Fahrenheit 2 - Fahrenheit to Celsius, or type 'exit' to quit:");
    string choice = Console.ReadLine().Trim().ToLower();

    if (choice == "exit")
        break;

    while (choice != "1" && choice != "2")
    {
        if (choice == "exit")
            return;

        Console.WriteLine("Invalid choice. Enter 1, 2 or 'exit':");
        choice = Console.ReadLine().Trim().ToLower();
    }

    double tempInput;
    Console.WriteLine("Enter the temperature to convert:");
    string tempStr = Console.ReadLine().Trim();

    while (!double.TryParse(tempStr, out tempInput))
    {
        if (tempStr.ToLower() == "exit")
            return;

        Console.WriteLine("Invalid number. Please enter a valid temperature:");
        tempStr = Console.ReadLine().Trim();
    }

    double result;
    if (choice == "1")
    {
        result = tempInput * 1.8 + 32;
        Console.WriteLine($"{tempInput}°C = {result:F2}°F");
    }
    else
    {
        result = (tempInput - 32) / 1.8;
        Console.WriteLine($"{tempInput}°F = {result:F2}°C");
    }

    Console.WriteLine();
}