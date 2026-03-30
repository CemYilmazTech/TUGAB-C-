static class Converison
{
    public static string DecimalToBinary(int number)
    {
        if (number == 0) return "0";
        string result = "";
        while (number > 0)
        {
            result = (number % 2) + result;
            number /= 2;
        }
        return result;
    }
    public static string BinaryToDecimal(string binary)
    {
        int result = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[binary.Length - 1 - i] == '1')
            {
                result += (int)Math.Pow(2, i);
            }
        }
        return result.ToString();
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number:");
        int decimalNumber = int.Parse(Console.ReadLine());
        string binaryString = Converison.DecimalToBinary(decimalNumber);
        Console.WriteLine($"Decimal {decimalNumber} to Binary: {binaryString}");
        Console.WriteLine("Enter a binary number:");
        string binaryInput = Console.ReadLine();
        string decimalResult = Converison.BinaryToDecimal(binaryInput);
        Console.WriteLine($"Binary {binaryInput} to Decimal: {decimalResult}");
    }
}