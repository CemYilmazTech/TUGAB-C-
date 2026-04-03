class Time
{
    private double seconds;
    private double minutes;
    private double hours;

    // Only one constructor with 3 parameters (as required by the task)
    public Time(double hours, double minutes, double seconds)
    {
        this.hours = hours;
        this.minutes = minutes;
        this.seconds = seconds;
    }

    public string ShowTime()
    {
        return $"{hours:00}:{minutes:00}:{seconds:00}";
    }

    public void SetTime(double hours, double minutes, double seconds)
    {
        this.hours = hours;
        this.minutes = minutes;
        this.seconds = seconds;
    }

    public void AdjustHours(int offset)
    {
        hours += offset;
        if (hours >= 24) hours -= 24;
        if (hours < 0)   hours += 24;
    }
}

class Program
{
    static void PrintAllTimes(Time sofia, Time prague, Time london, Time moscow, Time beijing)
    {
        Console.WriteLine($"  Sofia:   {sofia.ShowTime()}");
        Console.WriteLine($"  Prague:  {prague.ShowTime()}");
        Console.WriteLine($"  London:  {london.ShowTime()}");
        Console.WriteLine($"  Moscow:  {moscow.ShowTime()}");
        Console.WriteLine($"  Beijing: {beijing.ShowTime()}");
    }

    static void Main()
    {

        Time Sofia   = new Time(12, 0, 0);
        Time Prague  = new Time(11, 0, 0);
        Time London  = new Time(10, 0, 0);
        Time Moscow  = new Time(13, 0, 0);
        Time Beijing = new Time(18, 0, 0);

        Console.WriteLine("WINTER TIME:");
        Console.WriteLine("");
        PrintAllTimes(Sofia, Prague, London, Moscow, Beijing);
        Sofia.AdjustHours(+1);
        Prague.AdjustHours(+1);
        London.AdjustHours(+1);

        Console.WriteLine("SUMMER TIME:");
        Console.WriteLine("");
        PrintAllTimes(Sofia, Prague, London, Moscow, Beijing);
        Sofia.AdjustHours(-1);
        Prague.AdjustHours(-1);
        London.AdjustHours(-1);

        Console.WriteLine("WINTER TIME:");
        PrintAllTimes(Sofia, Prague, London, Moscow, Beijing);
    }
}