int lowerBound = int.Parse(Console.ReadLine());
int upperBound = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());

int combinations = 0;
bool isValidCombinationFound = false;
for (int i = lowerBound; i <= upperBound; i++)
{
    for (int j = lowerBound; j <= upperBound; j++)
    {
        combinations++;

        if (i + j == magicNumber)
        {
            isValidCombinationFound = true;
            Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNumber})");
            break;
        }
    }

    if (isValidCombinationFound)
    {
        break;
    }
}

if (!isValidCombinationFound)
{
    Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
}