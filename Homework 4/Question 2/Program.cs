class CartesianCoordinates
{
    private double x;
    private double y;

    public void Input()
    {
        Console.Write("X=");
        x = Double.Parse(Console.ReadLine());
        Console.Write("Y=");
        y = Double.Parse(Console.ReadLine());
    }

    public void Output()
    {
        Console.WriteLine("X: {0} Y: {1}", x, y);
    }

    public void Rotation(double angleDegrees)
    {
        double angleRadians = angleDegrees * Math.PI / 180;
        double newX = x * Math.Cos(angleRadians) - y * Math.Sin(angleRadians);
        double newY = x * Math.Sin(angleRadians) + y * Math.Cos(angleRadians);
        x = newX;
        y = newY;
        Console.WriteLine($"Coordinates after rotation by {angleDegrees} degrees:");
        Output();
    }

    public void Translation(double deltaX, double deltaY)
    {
        x += deltaX;
        y += deltaY;
        Console.WriteLine($"Coordinates after translation by ({deltaX}, {deltaY}):");
        Output();
    }

    public void Scaling(double kx, double ky)
    {
        x *= kx;
        y *= ky;
        Console.WriteLine($"Coordinates after scaling by kx={kx}, ky={ky}:");
        Output();
    }
}

class Program
{
    static void Main()
    {
        CartesianCoordinates[] points = new CartesianCoordinates[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nEnter coordinates for point {i + 1}:");
            points[i] = new CartesianCoordinates();
            points[i].Input();
        }

        while (true)
        {
            Console.WriteLine("Select a point 1, 2, or 3, or 0 to exit:");
            string pointChoice = Console.ReadLine().Trim();

            if (pointChoice == "0") break;

            if (pointChoice != "1" && pointChoice != "2" && pointChoice != "3")
            {
                Console.WriteLine("Invalid point selection. Please try again.");
                continue;
            }

            CartesianCoordinates point = points[Int32.Parse(pointChoice) - 1];
            Console.WriteLine("Current coordinates:");
            point.Output();

            Console.WriteLine("1. Rotation");
            Console.WriteLine("2. Translation");
            Console.WriteLine("3. Scaling");
            Console.Write("Choose a transformation: ");
            string choice = Console.ReadLine().Trim();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter rotation angle in degrees: ");
                    double angle = Double.Parse(Console.ReadLine());
                    point.Rotation(angle);
                    break;
                case "2":
                    Console.Write("Enter translation delta X: ");
                    double deltaX = Double.Parse(Console.ReadLine());
                    Console.Write("Enter translation delta Y: ");
                    double deltaY = Double.Parse(Console.ReadLine());
                    point.Translation(deltaX, deltaY);
                    break;
                case "3":
                    Console.Write("Enter scale factor kx: ");
                    double kx = Double.Parse(Console.ReadLine());
                    Console.Write("Enter scale factor ky: ");
                    double ky = Double.Parse(Console.ReadLine());
                    point.Scaling(kx, ky);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}