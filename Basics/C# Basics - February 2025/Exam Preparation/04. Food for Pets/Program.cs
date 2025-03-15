int days = int.Parse(Console.ReadLine());
double totalFood = double.Parse(Console.ReadLine());

double eatenBiscuits = 0;
double eatenDogFood = 0;
double eatenCatFood = 0;
for (int day = 1; day <= days; day++)
{
    double dogFood = double.Parse(Console.ReadLine());
    double catFood = double.Parse(Console.ReadLine());

    eatenDogFood += dogFood;
    eatenCatFood += catFood;

    if (day % 3 == 0)
    {
        eatenBiscuits += (dogFood + catFood) * 0.1;
    }
}

double foodEaten = eatenDogFood + eatenCatFood;
double totalFoodEatenInPercentage = foodEaten / totalFood * 100;
double eatenCatFoodInPercentage = eatenCatFood / foodEaten * 100;
double eatenDogFoodInPercentage = eatenDogFood / foodEaten * 100;

Console.WriteLine($"Total eaten biscuits: {Math.Round(eatenBiscuits)}gr.");
Console.WriteLine($"{totalFoodEatenInPercentage:F2}% of the food has been eaten.");
Console.WriteLine($"{eatenDogFoodInPercentage:F2}% eaten from the dog.");
Console.WriteLine($"{eatenCatFoodInPercentage:F2}% eaten from the cat.");