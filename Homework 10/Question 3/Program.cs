class Point
{
    protected int x, y;

    public Point()
    {
        x = y = 0;
    }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public virtual void Output()
    {
        Console.WriteLine($"Point coordinates: ({x}, {y})");
    }
}

class Circle : Point
{
    protected int radius;

    public Circle() : base()
    {
        radius = 0;
    }

    public Circle(int x, int y, int radius) : base(x, y)
    {
        this.radius = radius;
    }

    public void Area()
    {
        double area = Math.PI * radius * radius;
        Console.WriteLine($"Area of the circle: {area}");
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Circle radius: {radius}");
    }
}

class Cone : Circle
{
    private int height;

    public Cone() : base()
    {
        height = 0;
    }

    public Cone(int x, int y, int radius, int height) : base(x, y, radius)
    {
        this.height = height;
    }

    public void Volume()
    {
        double volume = (1.0 / 3.0) * Math.PI * radius * radius * height;
        Console.WriteLine($"Volume of the cone: {volume}");
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Height: {height}");
    }
}

class Cylinder : Circle
{
    private int height;

    public Cylinder() : base()
    {
        height = 0;
    }

    public Cylinder(int x, int y, int radius, int height) : base(x, y, radius)
    {
        this.height = height;
    }

    public void Volume()
    {
        double volume = Math.PI * radius * radius * height;
        Console.WriteLine($"Volume of the cylinder: {volume}");
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Height: {height}");
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point();
        Point p2 = new Point(3, 4);
        Console.WriteLine("Point p1:");
        p1.Output();
        Console.WriteLine("Point p2:");
        p2.Output();

        Circle c1 = new Circle();
        Circle c2 = new Circle(1, 2, 5);
        Console.WriteLine("Circle c1:");
        c1.Output(); 
        c1.Area();
        Console.WriteLine("Circle c2:");
        c2.Output(); 
        c2.Area();

        Cone co1 = new Cone();
        Cone co2 = new Cone(1, 2, 5, 10);
        Console.WriteLine("Cone co1:");
        co1.Output(); 
        co1.Volume();
        Console.WriteLine("Cone co2:");
        co2.Output(); 
        co2.Volume();

        Cylinder cy1 = new Cylinder();
        Cylinder cy2 = new Cylinder(1, 2, 5, 10);
        Console.WriteLine("Cylinder cy1:");
        cy1.Output(); 
        cy1.Volume();
        Console.WriteLine("Cylinder cy2:");
        cy2.Output(); 
        cy2.Volume();
    }
}