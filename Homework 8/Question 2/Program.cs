class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number:");
            float number = float.Parse(Console.ReadLine());
            if (number <= 0)
            {
                throw new ArgumentException("Invalid number.");
            }
            float result = (float)Math.Sqrt(number);
            Console.WriteLine($"Square root of {number} is: {result}");
        }
        catch (FormatException caught)
        {
            Console.WriteLine(caught.Message);
        }
        catch (ArgumentException caught)
        {
            Console.WriteLine(caught.Message);
        }
        finally
        {
            Console.WriteLine("End of program");
        }
    }
}