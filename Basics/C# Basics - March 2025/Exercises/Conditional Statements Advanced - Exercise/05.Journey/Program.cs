// Seasons
string winter = "winter";
string summer = "summer";

// Destinations
string bulgaria = "Bulgaria";
string balkans = "Balkans";
string europe = "Europe";

// Locations
string camp = "Camp";
string hotel = "Hotel";

double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

// Here we will not take into consideration the possibility of a negative value
// to be passed for the 'budget' ( explained for 'fishermenCount' in 04. Fishing Boat ).
string destination = "";
string location = "";
double percentageOfBudgetSpent = 1;
if (budget <= 100)
{
    destination = bulgaria;
    if (season == summer)
    {
        percentageOfBudgetSpent = 0.3;
        location = camp;
    }
    else if (season == winter)
    {
        percentageOfBudgetSpent = 0.7;
        location = hotel;
    }
}
else if (budget <= 1000)
{
    destination = balkans;
    if (season == summer)
    {
        percentageOfBudgetSpent = 0.4;
        location = camp;
    }
    else if (season == winter)
    {
        percentageOfBudgetSpent = 0.8;
        location = hotel;
    }
}
else
{
    destination = europe;
    // The reason we add this 'if' check '(season == summer || season == winter)' is because
    // we acknowledge that an invalid value can be passed for the 'season'. Again, this will not
    // happen based on the problem's description, but for practice, we will do it this way. It is
    // good to keep the invalid cases in mind.
    if (season == summer || season == winter)
    {
        percentageOfBudgetSpent = 0.9;
        location = hotel;
    }
}

double moneySpent = budget * percentageOfBudgetSpent;

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{location} - {moneySpent:f2}");