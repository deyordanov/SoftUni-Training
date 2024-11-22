//1. Чедтем входните данни от конзолата: темп., време от денонощието
int degrees = int.Parse(Console.ReadLine());
string dayTime = Console.ReadLine();

//2. Създаваме променливи, в които да пазим облеклото и обувките
string outfit = string.Empty;
string shoes = string.Empty;

//3. Правим външна проверка за време от денонощието: "Morning", "Afternoon", "Evening"
if (dayTime == "Morning")
{
    // => ако имаме Morning: проверяваме колко са градусите
    if (degrees >= 10 && degrees <= 18)
    {
        outfit = "Sweatshirt";
        shoes = "Sneakers";
    }
    else if (degrees <= 24)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (degrees >= 25)
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
}
else if (dayTime == "Afternoon")
{
    if (degrees >= 10 && degrees <= 18)
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (degrees <= 24)
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else if (degrees >= 25)
    {
        outfit = "Swim Suit";
        shoes = "Barefoot";
    }
}
else if (dayTime == "Evening")//Evening
{
    outfit = "Shirt";
    shoes = "Moccasins";
}

//4. Отпечатваме резултата на конзолата
Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");

