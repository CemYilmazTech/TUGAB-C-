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

        int[,] matrix = new int[2, size/2];
        int[] row0 = new int[size / 2];
        int[] row1 = new int[size / 2];
        Array.Copy(numbers, 0, row0, 0, size / 2);
        Array.Copy(numbers, size / 2, row1, 0, size / 2);

        for (int i = 0; i < size / 2; i++)
        {
            matrix[0, i] = row0[i];
            matrix[1, i] = row1[i];
        }

        Console.WriteLine("1D array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("2D array:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < size / 2; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}