int yearlyTax = int.Parse(Console.ReadLine());

double sneakersPrice = yearlyTax - (yearlyTax * 0.4);
double outfitPrice = sneakersPrice - (sneakersPrice * 0.2);
double ballPrice = outfitPrice * 0.25;
double accessoriesPrice = ballPrice * 0.2;
double totalPrice = yearlyTax + sneakersPrice + outfitPrice + ballPrice + accessoriesPrice;

Console.WriteLine(totalPrice);