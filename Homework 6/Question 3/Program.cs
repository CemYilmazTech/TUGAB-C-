class Student
{
    private static int studentCount = 2;
    private string[] Names;
    private string facultyNumber;
    private int year;
    private string specialty;

    private static Dictionary<string, string[]> externalDB = new Dictionary<string, string[]>()
    {
        { "SU000001", new string[] { "Cem", "", "Yilmaz", "2" } },
        { "SU000002", new string[] { "Guner", "", "Yilmaz", "4" } }
    };

    public Student(string firstName, string middleName, string lastName, string specialty)
    {
        Names = new string[3];
        Names[0] = firstName;
        Names[1] = middleName;
        Names[2] = lastName;
        studentCount++;
        this.specialty = specialty;
        this.facultyNumber = $"SU{studentCount:000000}";
        this.year = 1;
    }

    public Student(string facultyNumber, string specialty)
    {
        Names = new string[3];
        this.facultyNumber = facultyNumber;
        this.specialty = specialty;

        if (externalDB.ContainsKey(facultyNumber))
        {
            string[] data = externalDB[facultyNumber];
            Names[0] = data[0];
            Names[1] = data[1];
            Names[2] = data[2];
            this.year = int.Parse(data[3]);
        }
        else
        {
            Names[0] = "Unknown";
            Names[1] = "Unknown";
            Names[2] = "Unknown";
            this.year = 0;
        }
    }

    public string Name()
    {
        return $"{Names[0]} {Names[1]} {Names[2]}";
    }

    public string Info()
    {
        return $"Student: {Name()}, Faculty Number: {facultyNumber}, Specialty: {specialty}, Year: {year}";
    }

    public void Edit(string firstName, string middleName, string lastName, string facultyNumber, string specialty, int year)
    {
        Names[0] = firstName;
        Names[1] = middleName;
        Names[2] = lastName;
        this.facultyNumber = facultyNumber;
        this.specialty = specialty;
        this.year = year;
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("A", "B", "C", "Computer Science");
        Console.WriteLine(student1.Info());

        Student student2 = new Student("SU000002", "Mathematics");
        Console.WriteLine(student2.Info());

        student2.Edit("D", "E", "F", "SU000002", "Physics", 3);
        Console.WriteLine(student2.Info());
    }
}