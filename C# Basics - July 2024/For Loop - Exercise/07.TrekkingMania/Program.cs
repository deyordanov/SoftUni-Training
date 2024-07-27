int groups = int.Parse(Console.ReadLine());

int m1 = 0, m2 = 0, m3 = 0, m4 = 0, m5 = 0;
for (int i = 0; i < groups; i++)
{
    int climbersCount = int.Parse(Console.ReadLine());

    if (climbersCount <= 5) m1 += climbersCount;
    else if (climbersCount <= 12) m2 += climbersCount;
    else if (climbersCount <= 25) m3 += climbersCount;
    else if (climbersCount <= 40) m4 += climbersCount;
    else m5 += climbersCount;
}

int totalNumberOfClimbers = m1 + m2 + m3 + m4 + m5;

double p1 = 100.0 * m1 / totalNumberOfClimbers;
double p2 = 100.0 * m2 / totalNumberOfClimbers;
double p3 = 100.0 * m3 / totalNumberOfClimbers;
double p4 = 100.0 * m4 / totalNumberOfClimbers;
double p5 = 100.0 * m5 / totalNumberOfClimbers;

Console.WriteLine($"{p1:f2}%");
Console.WriteLine($"{p2:f2}%");
Console.WriteLine($"{p3:f2}%");
Console.WriteLine($"{p4:f2}%");
Console.WriteLine($"{p5:f2}%");