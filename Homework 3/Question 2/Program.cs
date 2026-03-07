int[] array = new int[20];
for (int i = 0; i < array.Length; i++)
{
    array[i] = i * 5;
}

int k = 0;
foreach (int element in array)
{
    Console.WriteLine(string.Format("index {0}: {1}", k, element));
    k++;
}