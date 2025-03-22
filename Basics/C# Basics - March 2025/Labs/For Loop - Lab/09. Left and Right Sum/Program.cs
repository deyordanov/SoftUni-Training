int iterations = int.Parse(Console.ReadLine());

int leftSum = 0;
for (int i = 0; i < iterations; i++)
{
    int number = int.Parse(Console.ReadLine());
    leftSum += number;
}

int rightSum = 0;
for (int i = 0; i < iterations; i++)
{
    int number = int.Parse(Console.ReadLine());
    rightSum += number;
}

if (leftSum == rightSum)
{
    Console.WriteLine($"Yes, sum = {leftSum}");
}
else
{
    Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
}