class Person
{
    private string firstName;
    private string lastName;
    private string phoneNumber;
    public Person(string firstName, string lastName, string phoneNumber)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.phoneNumber = phoneNumber;
    }
    public Person()
    {
        this.firstName = "Jane";
        this.lastName = "Doe";
        this.phoneNumber = "000-000-0000";
    }
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }
    public void Display()
    {
        Console.WriteLine($"Name: {firstName} {lastName}, Phone Number: {phoneNumber}");
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Enter the number of people in your phone book: ");
        int n = int.Parse(Console.ReadLine());
        Person[] phoneBook = new Person[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter details for person {i + 1}:");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();
            phoneBook[i] = new Person(firstName, lastName, phoneNumber);
        }
        while (true)
        {
            Console.WriteLine("\nAll contacts:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}. ");
                phoneBook[i].Display();
            }
            Console.WriteLine("\n1. Edit a contact\n2. Search by first name\n0. Exit");
            int action = int.Parse(Console.ReadLine());
            if (action == 1)
            {
                Console.Write($"Select contact to edit (1 to {n}): ");
                int choice = int.Parse(Console.ReadLine());
                if (choice >= 1 && choice <= n)
                {
                    Console.Write("New First Name: ");
                    phoneBook[choice - 1].FirstName = Console.ReadLine();
                    Console.Write("New Last Name: ");
                    phoneBook[choice - 1].LastName = Console.ReadLine();
                    Console.Write("New Phone Number: ");
                    phoneBook[choice - 1].PhoneNumber = Console.ReadLine();
                    Console.WriteLine("Contact updated.");
                }
                else
                    Console.WriteLine("Invalid choice.");
            }
            else if (action == 2)
            {
                Console.Write("Enter first name to search: ");
                string search = Console.ReadLine();
                bool found = false;
                for (int i = 0; i < n; i++)
                {
                    if (phoneBook[i].FirstName.ToLower() == search.ToLower())
                    {
                        phoneBook[i].Display();
                        found = true;
                    }
                }
                if (!found)
                    Console.WriteLine("No contact found with that name.");
            }
            else if (action == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action.");
            }
        }
    }
}