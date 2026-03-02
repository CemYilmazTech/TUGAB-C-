int a, b;

while (true)
{
    Console.WriteLine("Enter number a (0-255) or type 'exit' to quit:");
    string inputA = Console.ReadLine().Trim().ToLower();
    if (inputA == "exit") break;
    if (!int.TryParse(inputA, out a) || a < 0 || a > 255)
    {
        Console.WriteLine("Invalid input. Enter a number between 0 and 255.\n");
        continue;
    }

    Console.WriteLine("Enter number b (0-255) or type 'exit' to quit:");
    string inputB = Console.ReadLine().Trim().ToLower();
    if (inputB == "exit") break;
    if (!int.TryParse(inputB, out b) || b < 0 || b > 255)
    {
        Console.WriteLine("Invalid input. Enter a number between 0 and 255.\n");
        continue;
    }

    Console.WriteLine($"\na = {a} → {Convert.ToString(a, 2).PadLeft(8, '0')}");
    Console.WriteLine($"b = {b} → {Convert.ToString(b, 2).PadLeft(8, '0')}");

    int andResult = a & b;
    int orResult = a | b;
    int xorResult = a ^ b;
    int notA = ~a & 0xFF;
    int notB = ~b & 0xFF;

    Console.WriteLine($"\na & b = {andResult} → {Convert.ToString(andResult, 2).PadLeft(8, '0')}");
    Console.WriteLine($"a | b = {orResult} → {Convert.ToString(orResult, 2).PadLeft(8, '0')}");
    Console.WriteLine($"a ^ b = {xorResult} → {Convert.ToString(xorResult, 2).PadLeft(8, '0')}");
    Console.WriteLine($"~a = {notA} → {Convert.ToString(notA, 2).PadLeft(8, '0')}");
    Console.WriteLine($"~b = {notB} → {Convert.ToString(notB, 2).PadLeft(8, '0')}\n");
}