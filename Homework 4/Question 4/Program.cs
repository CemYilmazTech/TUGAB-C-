class Point
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
        Console.WriteLine($"X: {x}, Y: {y}");
    }

    public double GetX() { return x; }
    public double GetY() { return y; }
}

class Rectangle
{
    private double x0, y0;
    private double height, width;

    public void Input()
    {
        Console.Write("(Top-left corner) X0=");
        x0 = Double.Parse(Console.ReadLine());
        Console.Write("(Top-left corner) Y0=");
        y0 = Double.Parse(Console.ReadLine());
        Console.Write("Height=");
        height = Double.Parse(Console.ReadLine());
        Console.Write("Width=");
        width = Double.Parse(Console.ReadLine());
    }

    public void Output()
    {
        Console.WriteLine($"Top-left: ({x0}, {y0}), Height: {height}, Width: {width}");
    }
    public bool PointInRectangle(Point a)
    {
        return a.GetX() >= x0 && a.GetX() <= (x0 + width) && a.GetY() >= y0 && a.GetY() <= (y0 + height);
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n0. Exit");
            Console.WriteLine("Enter the number of points (or 0 to exit):");
            int numPoints = 0;
            while (!int.TryParse(Console.ReadLine(), out numPoints) || numPoints < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer:");
            }

            if (numPoints == 0) break;

            // Sub-task b: several Point objects
            Point[] points = new Point[numPoints];
            for (int i = 0; i < numPoints; i++)
            {
                Console.WriteLine($"\nEnter coordinates for point {i + 1}:");
                points[i] = new Point();
                points[i].Input();
            }

            Console.WriteLine("\nEnter the details of the rectangle:");
            Rectangle rect = new Rectangle();
            rect.Input();
            rect.Output();

            Console.WriteLine("\nResults:");
            bool anyInside = false;
            for (int i = 0; i < numPoints; i++)
            {
                if (rect.PointInRectangle(points[i]))
                {
                    Console.WriteLine($"Point {i + 1} is inside the rectangle.");
                    anyInside = true;
                }
                else
                {
                    Console.WriteLine($"Point {i + 1} is outside the rectangle.");
                }
            }

            if (!anyInside)
                Console.WriteLine("No points are inside the rectangle.");
        }
    }
}