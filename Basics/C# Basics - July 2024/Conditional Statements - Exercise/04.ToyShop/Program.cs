// Constants
double pricePerPuzzle = 2.60;
double pricePerDoll = 3;
double pricePerBear = 4.10;
double pricePerMinion = 8.20;
double pricePerTruck = 2;

// Input
double excursionPrice = double.Parse(Console.ReadLine());
int puzzles = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

// Calculations
int toysCount = puzzles + dolls + bears + minions + trucks;
double totalPrice = puzzles * pricePerPuzzle + dolls * pricePerDoll + bears * pricePerBear + minions * pricePerMinion + trucks * pricePerTruck;

if (toysCount >= 50)
{
    totalPrice = totalPrice - (totalPrice * 0.25); // totalPrice = totalPrice * 0.75;
}

double rent = totalPrice * 0.1;
totalPrice = totalPrice - rent;

// Output
double diff = Math.Abs(totalPrice - excursionPrice);
if (totalPrice >= excursionPrice)
{
    Console.WriteLine($"Yes! {diff:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {diff:f2} lv needed.");
}