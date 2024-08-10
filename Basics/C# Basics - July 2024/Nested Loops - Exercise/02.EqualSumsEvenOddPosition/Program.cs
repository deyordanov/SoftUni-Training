int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());

for(int i = first; i <= second; i++)
{
    // 654321 -> lastDigit = 1;
    // 654321 -> newNumber = 65432;
    // 65432 -> lastDigit = 2 -> 6543
    // 6543 -> lastDigit = 3 -> 654
    // 654 -> lastDigit = 4 -> 65
    // 65 -> lastDigit = 5 -> 6
    // 6 -> lastDigit = 6 -> 0

    int evenSum = 0;
    int oddSum = 0;
    int number = i;
    //int position = 0;
    bool isEven = true;
    while (number != 0)
    {
        int lastDigit = number % 10;
        //if (position % 2 == 0)
        if(isEven)
        {
            evenSum += lastDigit;
        }
        else
        {
            oddSum += lastDigit;
        }

        //position++;
        isEven = !isEven;
        number /= 10;
    }

    if (evenSum == oddSum)
    {
        Console.Write($"{i} ");
    }
}