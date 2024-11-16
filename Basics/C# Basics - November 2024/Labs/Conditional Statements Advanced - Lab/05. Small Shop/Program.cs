string product = Console.ReadLine();
string city = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double price = 0;
if (city == "Sofia")
{
    if (product == "coffee")
    {
        price = 0.50;
    }
    else if (product == "water")
    {
        price = 0.80;
    }
    else if (product == "beer")
    {
        price = 1.20;
    }
    else if (product == "sweets")
    {
        price = 1.45;
    }
    else if (product == "peanuts")
    {
        price = 1.60;
    }
}
else if (city == "Plovdiv")
{
    if (product == "coffee")
    {
        price = 0.40;
    }
    else if (product == "water")
    {
        price = 0.70;
    }
    else if (product == "beer")
    {
        price = 1.15;
    }
    else if (product == "sweets")
    {
        price = 1.30;
    }
    else if (product == "peanuts")
    {
        price = 1.50;
    }
}
else if (city == "Varna")
{
    if (product == "coffee")
    {
        price = 0.45;
    }
    else if (product == "water")
    {
        price = 0.70;
    }
    else if (product == "beer")
    {
        price = 1.10;
    }
    else if (product == "sweets")
    {
        price = 1.35;
    }
    else if (product == "peanuts")
    {
        price = 1.55;
    }
}

double finalPrice = quantity * price;

Console.WriteLine(finalPrice);