double depositSum = double.Parse(Console.ReadLine());
int depositTerm = int.Parse(Console.ReadLine());
double annualIntrestRate = double.Parse(Console.ReadLine());

// сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
double sum = depositSum + depositTerm * ((depositSum * annualIntrestRate * 0.01) / 12);

Console.WriteLine(sum);