string input = Console.ReadLine();

double balance = 0;
while (input != "NoMoreMoney")
{
    double number = double.Parse(input);

    if (number < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    Console.WriteLine($"Increase: {number:F2}");
    balance += number;

    input = Console.ReadLine();
}

Console.WriteLine($"Total: {balance:F2}");