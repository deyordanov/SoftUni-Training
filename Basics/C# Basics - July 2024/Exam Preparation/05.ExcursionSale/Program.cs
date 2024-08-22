// Constants
const int seaExcursionPrice = 680;
const int mountainExcursionPrice = 499;

const string sea = "sea";
const string mountain = "mountain";

int availableSeaExcursions = int.Parse(Console.ReadLine());
int availableMountainExcursions = int.Parse(Console.ReadLine());

int profit = 0;
bool areAllExcursionsSold = false;
string command;
// We will run the 'while' loop until we get the "Stop" command or we have no available exursions left.
while((command = Console.ReadLine()) != "Stop")
{
    string excursion = command;
    if (excursion == sea && availableSeaExcursions > 0)
    {
        profit += seaExcursionPrice;
        availableSeaExcursions--;
    }
    else if (excursion == mountain && availableMountainExcursions > 0)
    {
        profit += mountainExcursionPrice;
        availableMountainExcursions--;
    }

    if (availableSeaExcursions == 0 && availableMountainExcursions == 0)
    {
        areAllExcursionsSold = true;
        break;
    }
}

if (areAllExcursionsSold)
{
    Console.WriteLine("Good job! Everything is sold.");
}

Console.WriteLine($"Profit: {profit} leva.");