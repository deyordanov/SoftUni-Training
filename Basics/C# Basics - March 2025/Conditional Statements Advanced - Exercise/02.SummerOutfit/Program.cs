// Times of the day
string morning = "Morning";
string afternoon = "Afternoon";
string evening = "Evening";

// Outfits
string sweatshirt = "Sweatshirt";
string shirt = "Shirt";
string tShirt = "T-Shirt";
string swimSuit = "Swim Suit";

// Shoes
string sneakers = "Sneakers";
string moccasins = "Moccasins";
string sandals = "Sandals";
string barefoot = "Barefoot";

int degrees = int.Parse(Console.ReadLine());
string timeOfTheDay = Console.ReadLine();

string outfit = "";
string shoes = "";
if (degrees >= 10 && degrees <= 18)
{
    if (timeOfTheDay == morning)
    {
        outfit = sweatshirt;
        shoes = sneakers;
    }
    else if (timeOfTheDay == afternoon || timeOfTheDay == evening)
    {
        outfit = shirt;
        shoes = moccasins;
    }
}
else if (degrees > 18 && degrees <= 24)
{
    if (timeOfTheDay == morning || timeOfTheDay == evening)
    {
        outfit = shirt;
        shoes = moccasins;
    }
    else if (timeOfTheDay == afternoon)
    {
        outfit = tShirt;
        shoes = sandals;
    }
}
else if (degrees >= 25)
{
    if (timeOfTheDay == morning)
    {
        outfit = tShirt;
        shoes = sandals;
    }
    else if (timeOfTheDay == afternoon)
    {
        outfit = swimSuit;
        shoes = barefoot;
    }
    else if (timeOfTheDay == evening)
    {
        outfit = shirt;
        shoes = moccasins;
    }
}

Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");