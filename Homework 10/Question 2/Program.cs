class Tree
{
    private string name;
    private string climateZone;
    private string altitudeRange;
    public Tree(string name, string climateZone, string altitudeRange)
    {
        this.name = name;
        this.climateZone = climateZone;
        this.altitudeRange = altitudeRange;
    }

    public virtual void Input()
    {
        Console.WriteLine("Enter tree name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter climate zone:");
        climateZone = Console.ReadLine();
        Console.WriteLine("Enter altitude range:");
        altitudeRange = Console.ReadLine();
    }

    public virtual void Output()
    {
        Console.WriteLine($"Tree Name: {name}");
        Console.WriteLine($"Climate Zone: {climateZone}");
        Console.WriteLine($"Altitude Range: {altitudeRange}");
    }
}

class ConiferousTree : Tree
{
    private string coneShape;
    private int needleCount;
    public ConiferousTree(string name, string climateZone, string altitudeRange, string coneShape, int needleCount) : base(name, climateZone, altitudeRange)
    {
        this.coneShape = coneShape;
        this.needleCount = needleCount;
    }
    public override void Input()
    {
        base.Input();
        Console.WriteLine("Enter cone shape:");
        coneShape = Console.ReadLine();
        Console.WriteLine("Enter needle count:");
        needleCount = int.Parse(Console.ReadLine());
    }
    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Cone Shape: {coneShape}");
        Console.WriteLine($"Needle Count: {needleCount}");
    }
}

class DeciduousTree : Tree
{
    private string leafShape;
    private string fruitType;
    public DeciduousTree(string name, string climateZone, string altitudeRange, string leafShape, string fruitType) : base(name, climateZone, altitudeRange)
    {
        this.leafShape = leafShape;
        this.fruitType = fruitType;
    }
    public override void Input()
    {
        base.Input();
        Console.WriteLine("Enter leaf shape:");
        leafShape = Console.ReadLine();
        Console.WriteLine("Enter fruit type:");
        fruitType = Console.ReadLine();
    }
    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Leaf Shape: {leafShape}");
        Console.WriteLine($"Fruit Type: {fruitType}");
    }
}

class Program
{
    static void Main()
    {
        DeciduousTree[] deciduous = new DeciduousTree[3];
        deciduous[0] = new DeciduousTree("Beech", "Temperate", "1000-1800m", "Oval", "Nut");
        deciduous[1] = new DeciduousTree("Hornbeam", "Temperate", "0-1000m", "Oval", "Nut");
        deciduous[2] = new DeciduousTree("Oak", "Temperate", "0-1200m", "Lobed", "Acorn");

        ConiferousTree[] coniferous = new ConiferousTree[5];
        coniferous[0] = new ConiferousTree("White Pine", "Temperate", "700-2000m", "Cylindrical", 5);
        coniferous[1] = new ConiferousTree("Black Pine", "Temperate", "0-1800m", "Conical", 2);
        coniferous[2] = new ConiferousTree("Spruce", "Subalpine", "1000-2200m", "Cylindrical", 4);
        coniferous[3] = new ConiferousTree("Fir", "Subalpine", "800-2000m", "Cylindrical", 2);
        coniferous[4] = new ConiferousTree("Bosnian Pine", "Subalpine", "1000-2500m", "Oval", 5);

        foreach (DeciduousTree t in deciduous)
        {
            t.Output();
        }
        foreach (ConiferousTree t in coniferous)
        {
          t.Output();   
        }
    }
}