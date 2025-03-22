int iterations = int.Parse(Console.ReadLine());

int max = int.MinValue;
int min = int.MaxValue;

for (int i = 0; i < iterations; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (number > max)
    {
        max = number;
    }
    
    if (number < min)
    {
        min = number;
    }
}

Console.WriteLine($"Max number: {max}");
Console.WriteLine($"Min number: {min}");