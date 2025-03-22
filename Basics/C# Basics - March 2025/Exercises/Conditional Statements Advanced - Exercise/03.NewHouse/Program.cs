double pricePerRose = 5;
double pricePerDahlia = 3.8;
double pricePerTulip = 2.8;
double pricePerNarcissus = 3;
double pricePerGladiolus = 2.5;

string roses = "Roses";
string dahlias = "Dahlias";
string tulips = "Tulips";
string narcissus = "Narcissus";
string gladiolus = "Gladiolus";

string flowerType = Console.ReadLine();
int flowersCount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double flowerPrice = 0;
double discount = 1;
if (flowerType == roses)
{
    flowerPrice = pricePerRose;
    if (flowersCount > 80)
    {
        discount = 0.9;
    }
}
else if (flowerType == dahlias)
{
    flowerPrice = pricePerDahlia;
    if (flowersCount > 90)
    {
        discount = 0.85;
    }
}
else if (flowerType == tulips)
{
    flowerPrice = pricePerTulip;
    if (flowersCount > 80)
    {
        discount = 0.85;
    }
}
else if (flowerType == narcissus)
{
    flowerPrice = pricePerNarcissus;
    if (flowersCount < 120)
    {
        discount = 1.15;
    }
}
else if (flowerType == gladiolus)
{
    flowerPrice = pricePerGladiolus;
    if (flowersCount < 80)
    {
        discount = 1.2;
    }
}

double totalPrice = flowerPrice * flowersCount * discount;

double diff = Math.Abs(totalPrice - budget);
if (budget >= totalPrice)
{
    Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowerType} and {diff:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {diff:f2} leva more.");
}