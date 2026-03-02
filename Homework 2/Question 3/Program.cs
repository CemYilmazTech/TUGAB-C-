using System.Text;

int number;

while (true)
{
    Console.WriteLine("Enter a number to compute its list or type 'exit' to quit:");
    string input = Console.ReadLine().Trim();

    if (input.ToLower() == "exit")
        break;

    while (!int.TryParse(input, out number) || number < 0)
    {
        if (input.ToLower() == "exit")
            return;

        if (!int.TryParse(input, out number))
            Console.WriteLine("Invalid input. Please enter a valid 32-bit integer:");
        else
            Console.WriteLine("List is not defined for negative numbers. Enter a non-negative integer:");

        input = Console.ReadLine().Trim();
    }

    Console.WriteLine($"List of numbers from 1 to {number} (ascending): ");
    for (int i = 1; i <= number; i++)
        Console.Write($"{i} ");

    Console.WriteLine();

    Console.WriteLine($"List of numbers from 1 to {number} (descending): ");
    for (int i = number; i >= 1; i--)
        Console.Write($"{i} ");

    Console.WriteLine();
}