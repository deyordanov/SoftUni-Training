int upperBound = int.Parse(Console.ReadLine());

//int currentNumber = 1;

//while (currentNumber <= upperBound)
//{
//    Console.WriteLine(currentNumber);
//    currentNumber = currentNumber * 2 + 1;
//}

for (int currentNumber = 1; currentNumber <= upperBound; currentNumber = currentNumber * 2 + 1)
{
    Console.WriteLine(currentNumber);
}