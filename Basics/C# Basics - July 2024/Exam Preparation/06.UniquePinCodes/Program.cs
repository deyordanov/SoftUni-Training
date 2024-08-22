int firstBoundary = int.Parse(Console.ReadLine());
int secondBoundary = int.Parse(Console.ReadLine());
int thirdBoundary = int.Parse(Console.ReadLine());

// We know that the first number has to be even, so then we can start from 2 and set a step of 2 for the 'for' loop ( i += 2 ).
// This way 'i' will always be an even number ( 2, 4, 6, 8, 10, 12, 14, 16, 18, 20.... )
for (int i = 2; i <= firstBoundary; i += 2)
{
    for (int j = 2; j <= secondBoundary; j++)
    {
        // Use the algorithm we learned in our exercise lectures for determining whether a number is prime or not
        bool isPrime = true;
        for (int x = 2; x <= Math.Sqrt(j); x++)
        {
            if (j % x == 0) isPrime = false;
        }

        if (isPrime)
        {
            for (int k = 2; k <= thirdBoundary; k += 2)
            {
                Console.WriteLine($"{i}{j}{k}");
            }
        }
    }
}

//for (int i = 1; i <= firstBoundary; i++)
//{
//    // The first number must be EVEN
//    if (i % 2 == 0)
//    {
//        // We can start from '2' since we know that '0' and '1' are neither prime nor composite numbers
//        for (int j = 2; j <= secondBoundary; j++)
//        {
//            bool isPrime = true;
//            // We use the algorithm for determining whether a number is prime or not
//            for (int x = 2; x <= Math.Sqrt(j); x++)
//            {
//                if (j % x == 0) isPrime = false;
//            }

//            // The second number must be PRIME
//            if (isPrime)
//            {
//                for (int k = 1; k <= thirdBoundary; k++)
//                {
//                    // The third number must be EVEN
//                    if (k % 2 == 0)
//                    {
//                        Console.WriteLine($"{i}{j}{k}");
//                    }
//                }
//            }
//        }
//    }
//}