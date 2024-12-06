string destination = Console.ReadLine();
while (destination != "End")
{
    double moneyToSave = double.Parse(Console.ReadLine());
    while (moneyToSave > 0)
    {
        double money = double.Parse(Console.ReadLine());
        moneyToSave -= money;
    }

    Console.WriteLine($"Going to {destination}!");
    destination = Console.ReadLine();
}