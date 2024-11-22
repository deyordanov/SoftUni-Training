//1. Четем вход от конзолата: бюджет, сезон и брой рибари 
int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermen = int.Parse(Console.ReadLine());

double price = 0.0;

//2. Проверяваме кой е сезона, за да начислим наем ("Spring", "Summer", "Autumn", "Winter")
switch (season)
{
	case "Spring":
        price = 3000;
		break;
    case "Summer":
    case "Autumn":
        price = 4200;
        break;
    case "Winter":
        price = 2600;
        break;
}

//3. Проверяваме колко голяма е групата и начисляваме съответните проверки: 
if (fishermen <= 6) price -= price * 0.10;
else if (fishermen <= 11) price -= price * 0.15;
else price -= price * 0.25;

//4. Проверяваме дали има допълнително 5% отстъпка => ако са четен брой освен ако не е есен
if (fishermen % 2 == 0 && season != "Autumn")
    price -= price * 0.05;

//5. Проверяваме дали бюджетът им е достатъчен
if (budget >= price)
    Console.WriteLine($"Yes! You have {budget-price:f2} leva left.");
else
    Console.WriteLine($"Not enough money! You need {price-budget:f2} leva.");


