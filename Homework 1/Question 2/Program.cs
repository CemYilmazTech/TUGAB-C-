while (true)
{
    Console.WriteLine("Choose a shape to calculate the area: 1-Square 2-Rectangle 3-Circle 4-Triangle or type 'exit' to quit:");
    string choice = Console.ReadLine().Trim().ToLower();

    if (choice == "exit")
        break;

    while (choice != "1" && choice != "2" && choice != "3" && choice != "4")
    {
        if (choice == "exit")
            return;

        Console.WriteLine("Invalid choice. Enter 1, 2, 3, 4 or 'exit':");
        choice = Console.ReadLine().Trim().ToLower();
    }

    double number1 = 0, number2 = 0;

    switch (choice)
    {
        case "1":
            Console.WriteLine("Enter the side length of the square:");
            string input = Console.ReadLine().Trim();
            while (!double.TryParse(input, out number1) || number1 <= 0)
            {
                if (input.ToLower() == "exit") return;
                Console.WriteLine("Invalid input. Enter a positive number:");
                input = Console.ReadLine().Trim();
            }
            Console.WriteLine($"Area of the square: {number1 * number1:F2}");
            break;

        case "2":
            Console.WriteLine("Enter the length of the rectangle:");
            input = Console.ReadLine().Trim();
            while (!double.TryParse(input, out number1) || number1 <= 0)
            {
                if (input.ToLower() == "exit") return;
                Console.WriteLine("Invalid input. Enter a positive number:");
                input = Console.ReadLine().Trim();
            }

            Console.WriteLine("Enter the width of the rectangle:");
            input = Console.ReadLine().Trim();
            while (!double.TryParse(input, out number2) || number2 <= 0)
            {
                if (input.ToLower() == "exit") return;
                Console.WriteLine("Invalid input. Enter a positive number:");
                input = Console.ReadLine().Trim();
            }

            Console.WriteLine($"Area of the rectangle: {number1 * number2:F2}");
            break;

        case "3":
            Console.WriteLine("Enter the radius of the circle:");
            input = Console.ReadLine().Trim();
            while (!double.TryParse(input, out number1) || number1 <= 0)
            {
                if (input.ToLower() == "exit") return;
                Console.WriteLine("Invalid input. Enter a positive number:");
                input = Console.ReadLine().Trim();
            }
            Console.WriteLine($"Area of the circle: {Math.PI * number1 * number1:F2}");
            break;

        case "4":
            Console.WriteLine("Enter the base of the triangle:");
            input = Console.ReadLine().Trim();
            while (!double.TryParse(input, out number1) || number1 <= 0)
            {
                if (input.ToLower() == "exit") return;
                Console.WriteLine("Invalid input. Enter a positive number:");
                input = Console.ReadLine().Trim();
            }

            Console.WriteLine("Enter the height of the triangle:");
            input = Console.ReadLine().Trim();
            while (!double.TryParse(input, out number2) || number2 <= 0)
            {
                if (input.ToLower() == "exit") return;
                Console.WriteLine("Invalid input. Enter a positive number:");
                input = Console.ReadLine().Trim();
            }

            Console.WriteLine($"Area of the triangle: {0.5 * number1 * number2:F2}");
            break;
    }

    Console.WriteLine();
}