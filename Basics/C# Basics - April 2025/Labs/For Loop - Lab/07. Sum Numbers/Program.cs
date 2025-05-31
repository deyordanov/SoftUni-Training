int iterations = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = 0; i < iterations; i++)
{
    int number = int.Parse(Console.ReadLine());
    sum += number;
}

Console.WriteLine(sum);