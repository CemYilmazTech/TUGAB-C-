Console.Write("Hello ");
Console.WriteLine("World!");

Console.Write("Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!");

Console.Write("Enter a single character: ");
int charCode = Console.Read();
char character = (char)charCode;
Console.WriteLine($"\nYou typed: {character}");

Console.WriteLine("\nPress Enter to exit.");
Console.ReadLine();