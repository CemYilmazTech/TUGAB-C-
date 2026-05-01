class Person
{
    private string name;
    private string egn;

    public Person(string name, string egn)
    {
        this.name = name;
        this.egn = egn;
    }

    public string Egn
    {
        get { return egn; }
    }

    public virtual void Input()
    {
        Console.WriteLine("Enter name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter EGN:");
        egn = Console.ReadLine();
    }

    public virtual void Output()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"EGN: {egn}");
    }

}

class Student : Person
{
    private string major;
    private int year;
    private int facultyNumber;

    public Student(string name, string egn, string major, int year, int facultyNumber) : base(name, egn)
    {
        this.major = major;
        this.year = year;
        this.facultyNumber = facultyNumber;
    }

    public override void Input() 
    {
        base.Input();
        Console.WriteLine("Enter major:");
        major = Console.ReadLine();
        Console.WriteLine("Enter year:");
        year = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter faculty number:");
        facultyNumber = int.Parse(Console.ReadLine());
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($"Major: {major}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Faculty Number: {facultyNumber}");
    }
}

class Program
{
    static void Main()
    {
        Person[] people = new Person[3];
        for (int i = 0; i < people.Length; i++)
        {
            people[i] = new Person("", "");
            people[i].Input();
        }

        Student[] students = new Student[3];
        for (int i = 0; i < students.Length; i++)
        {
            students[i] = new Student("", "", "", 0, 0);
            students[i].Input();
        }
        Console.WriteLine("People in both lists:");
        foreach (Person p in people)
        {
            foreach (Student s in students)
            {
                if (p.Egn == s.Egn)
                {
                    p.Output();
                }
            }
        }
    }
}