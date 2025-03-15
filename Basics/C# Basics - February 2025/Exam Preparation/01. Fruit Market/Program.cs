double strawberryPrice = double.Parse(Console.ReadLine());
double bananasInKg = double.Parse(Console.ReadLine());
double orangesInKg = double.Parse(Console.ReadLine());
double raspberriesInKg = double.Parse(Console.ReadLine());
double strawberriesInKg = double.Parse(Console.ReadLine());

double raspberriesPrice = strawberryPrice * 0.5;
double orangesPrice = raspberriesPrice * 0.6;
double bananasPrice = raspberriesPrice * 0.2;

double totalStrawberriesPrice = strawberryPrice * strawberriesInKg;
double totalRaspberriesPrice = raspberriesPrice * raspberriesInKg;
double totalOrangesPrice = orangesPrice * orangesInKg;
double totalBananasPrice = bananasPrice * bananasInKg;

double total = totalStrawberriesPrice + totalRaspberriesPrice + totalOrangesPrice + totalBananasPrice;

Console.WriteLine($"{total:F2}");