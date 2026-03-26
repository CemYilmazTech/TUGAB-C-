class Rectangle
 {
    private double height, width;//полета
    public void Input() //метод
    {
        Console.Write("Height=");
        height = Double.Parse(Console.ReadLine());
        Console.Write("Width=");
        width = Double.Parse(Console.ReadLine());
    }
    public void Output() //метод
    {
        Console.WriteLine("Height: {0} Width: {1} ", 
        height, width);
    }
    public double Area() //метод
    {
        return height * width;
    }
 }

 class Circle
 {
    private double radius;
    public void Input()
    {
        Console.Write("Radius=");
        radius = Double.Parse(Console.ReadLine());
    }
    public void Output()
    {
        Console.WriteLine("Radius: {0} ", radius);
    }
    public double Area()
    {
        return Math.PI * radius * radius;
    }
 }

 class Triangle
{
    private double height;
    private double baseValue;
    public void Input()
    {
        Console.Write("Base=");
        baseValue = Double.Parse(Console.ReadLine());
        Console.Write("Height=");
        height = Double.Parse(Console.ReadLine());
    }
    public void Output()
    {
        Console.WriteLine("Base: {0} Height: {1} ", baseValue, height);
    }
    public double Area()
    {
        return 0.5 * baseValue * height;
    }
}

class Program
    {
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Circle");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            int choice = Int32.Parse(Console.ReadLine());

            if (choice == 0) break;

            switch (choice)
            {
                case 1:
                    Rectangle rect = new Rectangle();
                    rect.Input();
                    rect.Output();
                    Console.WriteLine($"Area: {rect.Area():F2}");
                    break;

                case 2:
                    Circle circle = new Circle();
                    circle.Input();
                    circle.Output();
                    Console.WriteLine($"Area: {circle.Area():F2}");
                    break;

                case 3:
                    Triangle triangle = new Triangle();
                    triangle.Input();
                    triangle.Output();
                    Console.WriteLine($"Area: {triangle.Area():F2}");
                    break;

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
