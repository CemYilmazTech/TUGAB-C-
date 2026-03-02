int number;
long factorial;

while (true)
{
    Console.WriteLine("Enter a number to compute its factorial (0-19) or type 'exit' to quit:");
    string input = Console.ReadLine().Trim();

    if (input.ToLower() == "exit")
        break;

    while (!int.TryParse(input, out number) || number < 0 || number > 19)
    {
        if (input.ToLower() == "exit")
            return;

        if (!int.TryParse(input, out number))
            Console.WriteLine("Invalid input. Please enter a valid 32-bit integer:");
        else if (number < 0)
            Console.WriteLine("Factorial is not defined for negative numbers. Enter a non-negative integer:");
        else
            Console.WriteLine("Factorial will overflow for numbers larger than 19. Enter a number less than or equal to 19:");

        input = Console.ReadLine().Trim();
    }

    factorial = 1;
    for (int i = 2; i <= number; i++)
        factorial *= i;

    Console.WriteLine($"Factorial of {number} is {factorial}\n");
}