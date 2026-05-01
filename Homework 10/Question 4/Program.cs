class SoftDrink
{
    protected double price;
    protected double sugarPercentage;
    protected string placeOfProduction;

    public SoftDrink(double price, double sugarPercentage, string placeOfProduction)
    {
        this.price = price;
        this.sugarPercentage = sugarPercentage;
        this.placeOfProduction = placeOfProduction;
    }

    public virtual void Input()
    {
        Console.WriteLine("Enter price:");
        price = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter sugar percentage:");
        sugarPercentage = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter place of production:");
        placeOfProduction = Console.ReadLine();
    }

    public virtual void Output()
    {
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Sugar Percentage: {sugarPercentage}");
        Console.WriteLine($"Place of Production: {placeOfProduction}");
    }
}

class CocaCola : SoftDrink
{
    private double caffeinePercentage;

    public CocaCola(double price, double sugarPercentage, string placeOfProduction, double caffeinePercentage) : base(price, sugarPercentage, placeOfProduction)
    {
        this.caffeinePercentage = caffeinePercentage;
    }

    public override void Input()
    {
        base.Input();
        Console.WriteLine("Enter caffeine percentage:");
        caffeinePercentage = double.Parse(Console.ReadLine());
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Caffeine Percentage: {caffeinePercentage}");
    }
}

class CocaColaZero : CocaCola
{
    public CocaColaZero(double price, string placeOfProduction, double caffeinePercentage) : base(price, 0, placeOfProduction, caffeinePercentage)
    {
    }

    public override void Input()
    {
        base.Input();
        sugarPercentage = 0;
    }

    public override void Output()
    {
        base.Output();
    }
}

class Fanta : SoftDrink
{
    private double fruitJuicePercentage;

    public Fanta(double price, double sugarPercentage, string placeOfProduction, double fruitJuicePercentage) : base(price, sugarPercentage, placeOfProduction)
    {
        this.fruitJuicePercentage = fruitJuicePercentage;
    }

    public override void Input()
    {
        base.Input();
        Console.WriteLine("Enter fruit juice percentage:");
        fruitJuicePercentage = double.Parse(Console.ReadLine());
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Fruit Juice Percentage: {fruitJuicePercentage}");
    }
}

class FantaLemon : Fanta
{
    public FantaLemon(double price, double sugarPercentage, string placeOfProduction, double fruitJuicePercentage) : base(price, sugarPercentage, placeOfProduction, fruitJuicePercentage)
    {
    }
}

class FantaOrange : Fanta
{
    public FantaOrange(double price, double sugarPercentage, string placeOfProduction, double fruitJuicePercentage) : base(price, sugarPercentage, placeOfProduction, fruitJuicePercentage)
    {
    }
}

class Sprite : SoftDrink
{
    private double lemonPercentage;
    public Sprite(double price, double sugarPercentage, string placeOfProduction, double lemonPercentage) : base(price, sugarPercentage, placeOfProduction)
    {
        this.lemonPercentage = lemonPercentage;
    }

    public override void Input()
    {
        base.Input();
        Console.WriteLine("Enter lemon percentage:");
        lemonPercentage = double.Parse(Console.ReadLine());
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Lemon Percentage: {lemonPercentage}");
    }
}

class Program
{
    static void Main()
    {
        CocaCola cola = new CocaCola(1.50, 10.6, "USA", 0.034);
        CocaColaZero colaZero = new CocaColaZero(1.50, "USA", 0.034);
        FantaLemon fantaLemon = new FantaLemon(1.20, 11.0, "Germany", 5.0);
        FantaOrange fantaOrange = new FantaOrange(1.20, 11.0, "Germany", 6.0);
        Sprite sprite = new Sprite(1.30, 9.0, "USA", 3.5);

        cola.Output();
        colaZero.Output();
        fantaLemon.Output();
        fantaOrange.Output();
        sprite.Output();
    }
}