double pricePerGpu = 250;

double buget = double.Parse(Console.ReadLine());
int gpus = int.Parse(Console.ReadLine());
int cpus = int.Parse(Console.ReadLine());
int rams = int.Parse(Console.ReadLine());

double gpusPrice = gpus * pricePerGpu;
double cpusPrice = cpus * (gpusPrice * 0.35);
double ramsPrice = rams * (gpusPrice * 0.1);

double totalPrice = gpusPrice + cpusPrice + ramsPrice;

if(gpus > cpus)
{
    totalPrice = totalPrice - (totalPrice * 0.15); // totalPrice = totalPrice * 0.85;
}

double diff = Math.Abs(buget - totalPrice);
if(buget >= totalPrice)
{
    Console.WriteLine($"You have {diff:f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {diff:f2} leva more!");
}