int age = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

int sum = 0;
int giftedMoney = 10;
for (int i = 1; i <= age; i++)
{
    if (i % 2 != 0)
    {
        sum += toyPrice;
    }
    else
    {
        sum += giftedMoney - 1;
        giftedMoney += 10;
    }
}

double diff = Math.Abs(sum - washingMachinePrice);
string formattedDiff = diff.ToString("f2");
if (sum >= washingMachinePrice)
{
    Console.WriteLine($"Yes! {formattedDiff}");
}
else
{
    Console.WriteLine($"No! {formattedDiff}");
}