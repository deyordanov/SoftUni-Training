double budget = double.Parse(Console.ReadLine());
int nights = int.Parse(Console.ReadLine());
double pricePerNight = double.Parse(Console.ReadLine());
double extraExpenses = int.Parse(Console.ReadLine());

if (nights > 7)
{
    pricePerNight *= 0.95;
}

double priceForAllNights = nights * pricePerNight;
double expenses = (extraExpenses / 100) * budget;
double total = priceForAllNights + expenses;

double diff = Math.Abs(budget - total);
if (budget >= total)
{
    Console.WriteLine($"Ivanovi will be left with {diff:F2} leva after vacation.");
}
else
{
    Console.WriteLine($"{diff:F2} leva needed.");
}