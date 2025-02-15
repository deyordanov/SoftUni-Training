int number = int.Parse(Console.ReadLine());

bool isValid = number >= 100 && number <= 200 || number == 0;

if (!isValid)
{
    Console.WriteLine("invalid");
}