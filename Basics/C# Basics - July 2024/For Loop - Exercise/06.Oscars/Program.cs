double nominationPoints = 1250.5;

string actor = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int judges = int.Parse(Console.ReadLine());

for (int i = 0; i < judges && points <= nominationPoints; i++)
{
    string judge = Console.ReadLine();
    double judgePoints = double.Parse(Console.ReadLine());

    points += judge.Length * judgePoints / 2;
}

if (points > nominationPoints)
{
    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points:f1}!");
}
else
{
    Console.WriteLine($"Sorry, {actor} you need {nominationPoints - points:f1} more!");
}
