int upperBound = int.Parse(Console.ReadLine());

int sum = 0;
while (sum < upperBound)
{
    int number = int.Parse(Console.ReadLine());
    sum += number;
}

Console.WriteLine(sum);