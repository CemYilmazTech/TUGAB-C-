class Calculator
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return a / b;
    }

    public static double Power(double a, int b)
    {
        double result = 1;
        for (int i = 0; i < b; i++)
        {
            result *= a;
        }
        return result;
    }

    public static double SquareRoot(double a)
    {
        if (a < 0)
        {
            throw new ArgumentException("Cannot take square root of a negative number.");
        }
        return Math.Sqrt(a);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Addition: " + Calculator.Add(5, 3));
        Console.WriteLine("Subtraction: " + Calculator.Subtract(5, 3));
        Console.WriteLine("Multiplication: " + Calculator.Multiply(5, 3));
        Console.WriteLine("Division: " + Calculator.Divide(5, 3));
        Console.WriteLine("Power: " + Calculator.Power(5, 3));
        Console.WriteLine("Square Root: " + Calculator.SquareRoot(25));
    }
}
