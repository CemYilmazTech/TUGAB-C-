class Conversion
{
    public static double MpsToKph(double mps)
    {
        return mps * 3.6;
    }

    public static double KphToMps(double kph)
    {
        return kph / 3.6;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(Conversion.MpsToKph(10));
        Console.WriteLine(Conversion.KphToMps(36));   
    }
}