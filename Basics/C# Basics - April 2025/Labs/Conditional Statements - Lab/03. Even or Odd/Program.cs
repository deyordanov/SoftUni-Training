int number = int.Parse(Console.ReadLine());

bool isEven = number % 2 == 0;

if (isEven)
{
    Console.WriteLine("even");
}
else
{
    Console.WriteLine("odd");
}