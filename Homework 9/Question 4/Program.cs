class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the array:");
        int size = int.Parse(Console.ReadLine());
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter number {i + 1}:");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int sum = numbers.Sum();
        Console.WriteLine($"Sum of the array elements: {sum}");
        double average = numbers.Average();
        Console.WriteLine($"Average of the array elements: {average}");
        int minimum = numbers.Min();
        Console.WriteLine($"Minimum element in the array: {minimum}");
        int maximum = numbers.Max();
        Console.WriteLine($"Maximum element in the array: {maximum}");
        int[] sortedNumbers = (int[])numbers.Clone();
        Array.Sort(sortedNumbers);
        Console.WriteLine("Sorted array:");
        foreach (int number in sortedNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine("");
        Console.WriteLine("Original array:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}