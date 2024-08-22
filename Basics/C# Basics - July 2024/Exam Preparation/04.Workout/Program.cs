int days = int.Parse(Console.ReadLine());
double km = double.Parse(Console.ReadLine());

double totalKm = km;
for (int i = 1; i <= days; i++)
{
    double percentage = double.Parse(Console.ReadLine());

    km += km * (percentage / 100);

    totalKm += km;
}

if (totalKm >= 1000)
{
    Console.WriteLine($"You've done a great job running {Math.Ceiling(totalKm - 1000)} more kilometers!");
}
else
{
    Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - totalKm)} more kilometers");
}