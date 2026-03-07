Console.Write("Enter the number of elements (n): ");
int n = int.Parse(Console.ReadLine() ?? "0");

double[] array = new double[n];

for (int i = 0; i < n; i++)
{
    Console.Write(string.Format("Enter element [{0}]: ", i));
    array[i] = double.Parse(Console.ReadLine() ?? "0");
}

double min = array[0];
double max = array[0];
int minIndex = 0;
int maxIndex = 0;
double sum = 0;

for (int i = 0; i < n; i++)
{
    if (array[i] < min) 
    { 
    min = array[i]; 
    minIndex = i; 
    }
    if (array[i] > max) 
    { 
    max = array[i]; 
    maxIndex = i; 
    }
    sum += array[i];
}

double average = sum / n;

Console.WriteLine("");
Console.WriteLine(string.Format("Minimum value: {0} at index {1}", min, minIndex));
Console.WriteLine(string.Format("Maximum value: {0} at index {1}", max, maxIndex));
Console.WriteLine(string.Format("Sum: {0}", sum));
Console.WriteLine(string.Format("Average: {0}", average));