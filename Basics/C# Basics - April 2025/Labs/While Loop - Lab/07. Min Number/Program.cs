string input = Console.ReadLine();

int minNumber = int.MaxValue;

while (input != "Stop")
{
    int currentNumber = int.Parse(input);

    if (currentNumber < minNumber)
    {
        minNumber = currentNumber;
    }

    input = Console.ReadLine();
}

Console.WriteLine(minNumber);