string[,] months = new string[12, 2]
{
    { "January",   "31" },
    { "February",  "28" },
    { "March",     "31" },
    { "April",     "30" },
    { "May",       "31" },
    { "June",      "30" },
    { "July",      "31" },
    { "August",    "31" },
    { "September", "30" },
    { "October",   "31" },
    { "November",  "30" },
    { "December",  "31" }
};

for (int i = 0; i < 12; i++)
{
    Console.WriteLine(string.Format("{0} has {1} days", months[i, 0], months[i, 1]));
}