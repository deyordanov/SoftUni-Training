int n = int.Parse(Console.ReadLine());

int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0;
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (number < 200) c1++;
    else if (number < 400) c2++;
    else if (number < 600) c3++;
    else if (number < 800) c4++;
    else c5++;
}

// double p1 = c1 / (double)n * 100;
// double p1 = 100.0 * c1 / (n * 1.0) * 100;
double p1 = 100.0 * c1 / n;
double p2 = 100.0 * c2 / n;
double p3 = 100.0 * c3 / n;
double p4 = 100.0 * c4 / n;
double p5 = 100.0 * c5 / n;

Console.WriteLine($"{p1:f2}%");
Console.WriteLine($"{p2:f2}%");
Console.WriteLine($"{p3:f2}%");
Console.WriteLine($"{p4:f2}%");
Console.WriteLine($"{p5:f2}%");
