int n = int.Parse(Console.ReadLine());

int sum = 0;
int maxNumber = int.MinValue;
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (number > maxNumber)
    {
        maxNumber = number;
    }

    sum += number;
}

int sumOfNumbersWithoutMax = sum - maxNumber;
if (sumOfNumbersWithoutMax == maxNumber)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {maxNumber}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(maxNumber - sumOfNumbersWithoutMax)}");
}