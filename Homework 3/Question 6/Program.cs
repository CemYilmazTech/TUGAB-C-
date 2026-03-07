using System;

string[] stations = { "Novo Selo", "Vidin", "Lom", "Oryahovo", "Montana", "Vratsa", "Knezha", "Lovech", "Pleven" };
int[] temperatures = { 8, 8, 8, 8, 15, 14, 8, 10, 13 };

int minTemp = 99999;
int maxTemp = -99999;

foreach (int temp in temperatures)
{
    if (temp < minTemp) minTemp = temp;
    if (temp > maxTemp) maxTemp = temp;
}

int index = 0;
bool first = true;
Console.Write(string.Format("Minimum temperature {0}C at station(s): ", minTemp));
foreach (int temp in temperatures)
{
    if (temp == minTemp)
    {
        if (!first) Console.Write(", ");
        Console.Write(stations[index]);
        first = false;
    }
    index++;
}

index = 0;
first = true;
Console.WriteLine("");
Console.Write(string.Format("Maximum temperature {0}C at station(s): ", maxTemp));
foreach (int temp in temperatures)
{
    if (temp == maxTemp)
    {
        if (!first) Console.Write(", ");
        Console.Write(stations[index]);
        first = false;
    }
    index++;
}

Console.WriteLine("");
Console.WriteLine(string.Format("Temperature difference: {0}C", maxTemp - minTemp));