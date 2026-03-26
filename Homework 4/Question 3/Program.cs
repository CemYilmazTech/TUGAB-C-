class Student
{
    private string firstName;
    private string middleName;
    private string lastName;
    private string facultyNo;
    private double GPA;

    public void Input()
    {
        Console.Write("First Name: ");
        firstName = Console.ReadLine().Trim();
        Console.Write("Middle Name: ");
        middleName = Console.ReadLine().Trim();
        Console.Write("Last Name: ");
        lastName = Console.ReadLine().Trim();
        Console.Write("Faculty Number: ");
        facultyNo = Console.ReadLine().Trim();
        Console.Write("GPA: ");
        while (!double.TryParse(Console.ReadLine(), out GPA) || GPA < 0 || GPA > 6)
        {
            Console.Write("Invalid input. Enter a GPA between 0 and 6: ");
        }
    }

    public void Output()
    {
        Console.WriteLine($"Name: {ReturnFullName()}");
        Console.WriteLine($"Faculty Number: {facultyNo}");
        Console.WriteLine($"GPA: {GPA}");
    }

    public string ReturnFullName()
    {
        return $"{firstName} {middleName} {lastName}";
    }

    public bool IsExcellent()
    {
        return GPA >= 5.50 && GPA <= 6.00;
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nEnter information for student {i + 1}:");
            students[i] = new Student();
            students[i].Input();
        }

        Console.WriteLine("\n");
        bool anyExcellent = false;
        for (int i = 0; i < 3; i++)
        {
            if (students[i].IsExcellent())
            {
                Console.WriteLine(students[i].ReturnFullName());
                anyExcellent = true;
            }
        }

        if (!anyExcellent)
            Console.WriteLine("No students with excellent GPA.");
    }
}