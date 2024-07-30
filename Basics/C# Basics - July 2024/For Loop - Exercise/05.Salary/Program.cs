int n = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

int fine = 0;
for (int i = 0; i < n && fine < salary; i++)
{
    string website = Console.ReadLine();

    if (website == "Facebook")
    {
        fine += 150;
    }
    else if (website == "Instagram")
    {
        fine += 100;
    }
    else if (website == "Reddit")
    {
        fine += 50;
    }
}

if (fine >= salary)
{
    Console.WriteLine("You have lost your salary.");
}
else
{
    Console.WriteLine(salary - fine);
}