Console.Write("Enter the number of elements (n): ");
int n = int.Parse(Console.ReadLine() ?? "0");

double[] array = new double[n];

for (int i = 0; i < n; i++)
{
    Console.Write(string.Format("Enter element [{0}]: ", i));
    array[i] = double.Parse(Console.ReadLine() ?? "0");
}

Console.WriteLine("\nElements with even indices:");
for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(string.Format("array[{0}] = {1}", i, array[i]));
    }
}

Console.WriteLine("\nElements with odd indices:");
for (int i = 0; i < n; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(string.Format("array[{0}] = {1}", i, array[i]));
    }
}