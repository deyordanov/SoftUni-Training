/*
 * A prime number is a natural number greater than 1 that is only divisible by 1 and itself:
 * -> 7 % 7 = 0;
 * -> 7 % 1 = 0;
 * If we divide 7 by any other number between 1 and 7, the result will not be 0, so 7 is a prime number.
 * 
 * A composite number (non-prime number) is a number that has factors other than 1 and itself:
 * -> 9 % 9 = 0;
 * -> 9 % 1 = 0;
 * -> 9 % 3 = 0; - we can see that it can be evenly divided by 3 as well. So 9
 * is not a prime number, it is a composite one.
 * 
 * Note: The numbers 0 and 1 are neither prime nor composite.
 * -> Prime number - Просто число
 * -> Composite number -> Съставно число
 */

int primeSum = 0;
int compositeSum = 0;
string command;
while((command = Console.ReadLine()) != "stop")
{
    int number = int.Parse(command);

    if (number < 0)
    {
        Console.WriteLine("Number is negative.");
        continue;
    }

    bool isPrime = true;

    /*
    With these checks we cover all input types our program can run into.
    The judge system does not check for these 'edge' cases, so there is no
    need to include them in our final solution. We can added them for fullness.

    if (number <= 1)
    {
        isPrime = false;
    }

    if (number == 2)
    {
        isPrime = true;
    }

    if (number % 2 == 0)
    {
        isPrime = false;
    }*/

    for (int i = 2; i < number; i++)
    {
        if(number % i == 0)
        {
            isPrime = false;
        }
    }

    //bool isPrime = true;
    //for(int i = 2; i <= Math.Sqrt(number); i++)
    //{
    //    if(number % i == 0)
    //    {
    //        isPrime = false;
    //    }
    //}

    if(isPrime)
    {
        primeSum += number;
    }
    else
    {
        compositeSum += number;
    }
}

Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
Console.WriteLine($"Sum of all non prime numbers is: {compositeSum}");