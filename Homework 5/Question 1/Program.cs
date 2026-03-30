class Point
{
    private int x, y;

    public void Input()
    {
        Console.Write("X=");
        string temp = Console.ReadLine();
        x = Int32.Parse(temp);
        Console.Write("Y=");
        temp = Console.ReadLine();
        y = Int32.Parse(temp);
    }

    public void Input(int newX, int newY)
    {
        x = newX;
        y = newY;
    }

    public void Output()
    {
        Console.WriteLine("( {0}, {1} )", x, y);
    }

    public static double Distance(Point a, Point b) // static method
    {
        int dx, dy;
        dx = a.x - b.x;
        dy = a.y - b.y;
        double l = Math.Sqrt(dx * dx + dy * dy);
        return l;
    }

    public double Distance(Point other)
    {
        int dx = this.x - other.x;
        int dy = this.y - other.y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point();
        Point p2 = new Point();
        Point p3 = new Point();

        p1.Input(1, 1);
        p2.Input();
        p3.Input();

        Console.WriteLine("Distance p1-p2: " + Point.Distance(p1, p2));
        Console.WriteLine("Distance p1-p3: " + p1.Distance(p3));
        Console.WriteLine("Distance p2-p3: " + Point.Distance(p2, p3));
    }
}