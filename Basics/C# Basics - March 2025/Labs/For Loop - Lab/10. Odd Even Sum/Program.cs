int iterations = int.Parse(Console.ReadLine());

int evenSum = 0;
int oddSum = 0;
for (int i = 0; i < iterations; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (i % 2 == 0)
    {
        evenSum += number;
    }
    else
    {
        oddSum += number;
    }
}

if (oddSum == evenSum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {evenSum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
}