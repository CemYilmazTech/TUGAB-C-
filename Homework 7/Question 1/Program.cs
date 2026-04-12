class Rectangle
{
    private double length;
    private double width;

    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public double Area
    {
        get { return length * width; }
    }

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public void SetWidth(double width) { this.width = width; }
    public void SetLength(double length) { this.length = length; }

    public void Display()
    {
        Console.WriteLine($"Length: {length}, Width: {width}.");
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect1 = new Rectangle(0, 0);
        rect1.SetLength(5);
        rect1.SetWidth(3);
        Rectangle rect2 = new Rectangle(0, 0);
        rect2.SetLength(10);
        rect2.SetWidth(4);
        Rectangle rect3 = new Rectangle(0, 0);
        rect3.SetLength(2);
        rect3.SetWidth(2);

        if (rect1.Area > rect2.Area && rect1.Area > rect3.Area)
            Console.WriteLine("Rectangle 1 has the largest area.");
        else if (rect2.Area > rect1.Area && rect2.Area > rect3.Area)
            Console.WriteLine("Rectangle 2 has the largest area.");
        else
            Console.WriteLine("Rectangle 3 has the largest area.");

        Rectangle rect11 = new Rectangle(5, 3);
        Rectangle rect22 = new Rectangle(10, 4);
        Rectangle rect33 = new Rectangle(2, 2);

        if (rect11.Area > rect22.Area && rect11.Area > rect33.Area)
            Console.WriteLine("Rectangle 11 has the largest area.");
        else if (rect22.Area > rect11.Area && rect22.Area > rect33.Area)
            Console.WriteLine("Rectangle 22 has the largest area.");
        else
            Console.WriteLine("Rectangle 33 has the largest area.");
    }
}