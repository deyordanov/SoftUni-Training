double budget = double.Parse(Console.ReadLine());
string destination = Console.ReadLine();
string season = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double pricePerDay = 0;

if (season == "Winter")
{
    if (destination == "Dubai")
    {
        pricePerDay = 45000 * 0.7;
    }
    else if (destination == "Sofia")
    {
        pricePerDay = 17000 * 1.25;
    }
    else if (destination == "London")
    {
        pricePerDay = 24000;
    }
}
else if (season == "Summer")
{
    if (destination == "Dubai")
    {
        pricePerDay = 40000 * 0.7;
    }
    else if (destination == "Sofia")
    {
        pricePerDay = 12500 * 1.25;
    }
    else if (destination == "London")
    {
        pricePerDay = 20250;
    }
}

double total = days * pricePerDay;

double diff = Math.Abs(budget - total);
if (budget >= total)
{
    Console.WriteLine($"The budget for the movie is enough! We have {diff:F2} leva left!");
}
else
{
    Console.WriteLine($"The director needs {diff:F2} leva more!");
}