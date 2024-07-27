int tournaments = int.Parse(Console.ReadLine());
int initialPoints = int.Parse(Console.ReadLine());

int currentSeasonPoints = 0;
int tournamentsWon = 0;
for (int i = 0; i < tournaments; i++)
{
    string placement = Console.ReadLine();
    if (placement == "W")
    {
        currentSeasonPoints += 2000;
        tournamentsWon++;
    }
    else if (placement == "F")
    {
        currentSeasonPoints += 1200;
    }
    else if (placement == "SF")
    {
        currentSeasonPoints += 720;
    }
}

Console.WriteLine($"Final points: {initialPoints + currentSeasonPoints}");
Console.WriteLine($"Average points: {currentSeasonPoints / tournaments}");
Console.WriteLine($"{100.0 * tournamentsWon / tournaments:f2}%");