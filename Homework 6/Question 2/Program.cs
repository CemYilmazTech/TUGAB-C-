class Rectangle
{
    double width;
    double height;

    public Rectangle()
    {
        width = 1.0;
        height = 1.0;
    }
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double Area()
    {
        return width * height;
    }
}

class Circle
{
    double radius;

    public Circle()
    {
        radius = 1.0;
    }
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double Area()
    {
        return Math.PI * radius * radius;
    }
}

class Triangle
{
    double baseLength;
    double height;

    public Triangle()
    {
        baseLength = 1.0;
        height = 1.0;
    }
    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public double Area()
    {
        return 0.5 * baseLength * height;
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle();
        Circle circle = new Circle();
        Triangle triangle = new Triangle();
        Console.WriteLine($"Default Rectangle Area: {rect.Area():F2}");
        Console.WriteLine($"Default Circle Area: {circle.Area():F2}");
        Console.WriteLine($"Default Triangle Area: {triangle.Area():F2}");
        Console.WriteLine();
        Rectangle rect2     = new Rectangle(4.0, 5.0);
        Circle    circle2   = new Circle(3.0);
        Triangle  triangle2 = new Triangle(6.0, 4.0);
        Console.WriteLine($"Custom Rectangle Area: {rect2.Area():F2}");
        Console.WriteLine($"Custom Circle Area: {circle2.Area():F2}");
        Console.WriteLine($"Custom Triangle Area: {triangle2.Area():F2}");
    }
}
