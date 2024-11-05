int checkenQuantity = int.Parse(Console.ReadLine());
int fishQuantity = int.Parse(Console.ReadLine());
int veganQuantity = int.Parse(Console.ReadLine());

double menuPrice = checkenQuantity * 10.35 
                + fishQuantity * 12.40 
                + veganQuantity * 8.15;

double desserPrice = menuPrice * 0.2; //20% => 20/100 => 0.2
double totalPrice = menuPrice + desserPrice + 2.5;

Console.WriteLine(totalPrice);