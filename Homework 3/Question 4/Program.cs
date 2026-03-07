Console.Write("Enter the number of elements (n): ");
int n = int.Parse(Console.ReadLine() ?? "0");

double[] array = new double[n];
for (int i = 0; i < n; i++)
{
    Console.Write(string.Format("Enter element [{0}]: ", i));
    array[i] = double.Parse(Console.ReadLine() ?? "0");
}

int count = 0;
foreach (double element in array)
{
    if (element > 0) count++;
}

double[] positiveArray = new double[count];
int k = 0;
foreach (double element in array)
{
    if (element > 0)
    {
        positiveArray[k] = element;
        k++;
    }
}
Console.WriteLine("");
Console.WriteLine("Original array:");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(string.Format("array[{0}] = {1}", i, array[i]));
}
Console.WriteLine("");
Console.WriteLine("Positive elements array:");
if (count == 0)
{
    Console.WriteLine("No positive elements found.");
} else
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(string.Format("positiveArray[{0}] = {1}", i, positiveArray[i]));
    }
}