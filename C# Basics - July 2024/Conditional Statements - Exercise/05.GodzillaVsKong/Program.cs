double budget = double.Parse(Console.ReadLine());
int extras = int.Parse(Console.ReadLine());
double pricePerOutfit = double.Parse(Console.ReadLine());

double decor = budget * 0.1;
double outfitsPrice = extras * pricePerOutfit;
if (extras > 150)
{
    outfitsPrice = outfitsPrice - (outfitsPrice * 0.1); // outfitsPrice = outfitsPrice * 0.9;
}

double totalPrice = decor + outfitsPrice;

double diff = Math.Abs(budget - totalPrice);
if (budget < totalPrice)
{
    Console.WriteLine($"Not enough money!");
    Console.WriteLine($"Wingard needs {budget - totalPrice:f2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {diff:f2} leva left.");
}