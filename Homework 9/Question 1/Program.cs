class Student
{
    private float gpa;
    private string firstname;
    private string middlename;
    private string lastname;

    public float GPA
    {
        get { return gpa; }
        set { gpa = value; }
    }

    public string FirstName
    {
        get { return firstname; }
        set { firstname = value; }
    }

    public string MiddleName
    {
        get { return middlename; }
        set { middlename = value; }
    }

    public string LastName
    {
        get { return lastname; }
        set { lastname = value; }
    }

    public string FullName
    {
        get { return $"{firstname} {middlename} {lastname}"; }
    }

    public bool ExcellentGPA
    {
        get { return gpa >= 5.5 && gpa <= 6.0; }
    }

    public void Input()
        {
            Console.WriteLine("Enter first name:");
            firstname = Console.ReadLine();
            Console.WriteLine("Enter middle name:");
            middlename = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            lastname = Console.ReadLine();
            Console.WriteLine("Enter GPA:");
            gpa = float.Parse(Console.ReadLine());
        }

    public void Output()
    {
        Console.WriteLine($"Name: {FullName}, GPA: {gpa}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of students:");
        int studentCount = int.Parse(Console.ReadLine());
        Student[] students = new Student[studentCount];
        for (int i = 0; i < studentCount; i++)
        {
            students[i] = new Student();
            Console.WriteLine($"Enter details for student {i + 1}:");
            students[i].Input();
        }

        for (int i = 0; i < studentCount; i++)
        {
            if (students[i].ExcellentGPA)
            {
                students[i].Output();
            }
        }
        float sum = 0;
        for (int i = 0; i < studentCount; i++)
        {
            sum += students[i].GPA;
        }
        Console.WriteLine($"Average GPA: {sum / studentCount}");
    }
}