class Car
{
    private string licensePlate;
    private string colour;
    private string make;
    public string LicensePlate
    {
        get { return licensePlate; }
        set { licensePlate = value; }
    }
    public string Colour
    {
        get { return colour; }
        set { colour = value; }
    }
    public string Make
    {
        get { return make; }
        set { make = value; }
    } 
    public Car(string make, string colour, string licensePlate)
    {
        this.make = make;
        this.colour = colour;
        this.licensePlate = licensePlate;
    }
    public void Display()
    {
        Console.WriteLine($"Car Make: {make}, Colour: {colour}, License Plate: {licensePlate}.");
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of cars in the road trip:");
        int n = int.Parse(Console.ReadLine());
        Car[] cars = new Car[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter details for car {i + 1}:");
            Console.Write("Make: ");
            string make = Console.ReadLine();
            Console.Write("Colour: ");
            string colour = Console.ReadLine();
            Console.Write("License Plate: ");
            string licensePlate = Console.ReadLine();
            cars[i] = new Car(make, colour, licensePlate);
        }
        while (true)
        {
            Console.WriteLine("\nAll cars:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}. ");
                cars[i].Display();
            }
            Console.WriteLine("\n1. Display a car\n2. Edit a car\n0. Exit");
            int action = int.Parse(Console.ReadLine());
            if (action == 1)
            {
                Console.Write($"Select car (1 to {n}): ");
                int choice = int.Parse(Console.ReadLine());
                if (choice >= 1 && choice <= n)
                    cars[choice - 1].Display();
                else
                    Console.WriteLine("Invalid choice.");
            }
            else if (action == 2)
            {
                Console.Write($"Select car to edit (1 to {n}): ");
                int choice = int.Parse(Console.ReadLine());
                if (choice >= 1 && choice <= n)
                {
                    Console.Write("New Make: ");
                    cars[choice - 1].Make = Console.ReadLine();
                    Console.Write("New Colour: ");
                    cars[choice - 1].Colour = Console.ReadLine();
                    Console.Write("New License Plate: ");
                    cars[choice - 1].LicensePlate = Console.ReadLine();
                    Console.WriteLine("Car updated.");
                }
                else
                    Console.WriteLine("Invalid choice.");
            }
            else if (action == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action.");
            }
        }
    }
}