//1. Четем входните данни: Вид цветя, количество, бюджет
string type = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double price = 0.0;

switch (type)
{
	case "Roses":
        price = quantity * 5;
        if (quantity > 80) price -= price * 0.10;
        break;
    case "Dahlias":
        price = quantity * 3.8;
        if (quantity > 90) price -= price * 0.15;
        break;
    case "Tulips":
        price = quantity * 2.8;
        if (quantity > 80) price -= price * 0.15;
        break;
    case "Narcissus":
        price = quantity * 3;
        if (quantity < 120) price += price * 0.15;
        break;
    case "Gladiolus":
        price = quantity * 2.5;
        if (quantity < 80) price += price * 0.20;
        break;
}


if (budget >= price)
    Console.WriteLine($"Hey, you have a great garden with {quantity} {type} and {budget-price:f2} leva left.");
else
    Console.WriteLine($"Not enough money, you need {price-budget:f2} leva more.");


