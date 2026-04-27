class Program
{
    static void Main()
    {
        int a = 0, b = 0;
        try
        {
            Console.WriteLine("Enter first number:");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b = Int32.Parse(Console.ReadLine());
            float c = (float)Math.Round((double)a / b);
            Console.WriteLine($"Result of {a} / {b} is: {c}");
        }
        catch (OverflowException caught)
        {
            Console.WriteLine(caught.Message);
        }
        catch (FormatException caught)
        {
            Console.WriteLine(caught.Message);
        }
        catch (ArgumentNullException caught)
        {
            Console.WriteLine(caught.Message);
        } 
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}