double chickenMenuPrice = 10.35;
double fishMenuPrice = 12.40;
double vegeterianMenuPrice = 8.15;
double orderPrice = 2.50;

int chickenMenuCount = int.Parse(Console.ReadLine());
int fishMenuCount = int.Parse(Console.ReadLine());
int vegeterianMenuCount = int.Parse(Console.ReadLine());

double chickenMenusPrice = chickenMenuCount * chickenMenuPrice;
double fishMenusPrice = fishMenuCount * fishMenuPrice;
double vegeterianMenusPrice = vegeterianMenuCount * vegeterianMenuPrice;
double totalMenusPrice = chickenMenusPrice + fishMenusPrice + vegeterianMenusPrice;
double dessertsPrice = totalMenusPrice * 0.2;
double totalOrderPrice = totalMenusPrice + dessertsPrice + orderPrice;

Console.WriteLine(totalOrderPrice);