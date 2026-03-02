int side1, side2, side3;

while (true)
{
    Console.WriteLine("Enter the length of the first side or type 'exit' to quit:");
    string input1 = Console.ReadLine().Trim();
    if (input1.ToLower() == "exit") break;

    Console.WriteLine("Enter the length of the second side:");
    string input2 = Console.ReadLine().Trim();
    if (input2.ToLower() == "exit") break;

    Console.WriteLine("Enter the length of the third side:");
    string input3 = Console.ReadLine().Trim();
    if (input3.ToLower() == "exit") break;

    if (!int.TryParse(input1, out side1) || side1 <= 0)
    {
        Console.WriteLine("Invalid input for the first side. Please enter a positive integer.\n");
        continue;
    }
    if (!int.TryParse(input2, out side2) || side2 <= 0)
    {
        Console.WriteLine("Invalid input for the second side. Please enter a positive integer.\n");
        continue;
    }
    if (!int.TryParse(input3, out side3) || side3 <= 0)
    {
        Console.WriteLine("Invalid input for the third side. Please enter a positive integer.\n");
        continue;
    }

    if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
    {
        Console.WriteLine("The given sides can form a triangle.");

        // Determine type
        if (side1 == side2 && side2 == side3)
            Console.WriteLine("It is an equilateral triangle.\n");
        else if (side1 == side2 || side1 == side3 || side2 == side3)
            Console.WriteLine("It is an isosceles triangle.\n");
        else
            Console.WriteLine("It is a scalene triangle.\n");
    }
    else
    {
        Console.WriteLine("The given sides cannot form a triangle.\n");
    }
}