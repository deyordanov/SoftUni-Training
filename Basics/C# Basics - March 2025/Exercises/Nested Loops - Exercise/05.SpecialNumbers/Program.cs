int n = int.Parse(Console.ReadLine());

for(int n1 = 1; n1 <= 9; n1++)
{
    if (n % n1 != 0) continue;
    for(int n2 = 1; n2 <= 9; n2++)
    {
        if (n % n2 != 0) continue;
        for (int n3 = 1; n3 <= 9; n3++)
        {
            if (n % n3 != 0) continue;
            for (int n4 =1; n4 <= 9; n4++)
            {
                if (n % n4 != 0) continue;

                Console.Write($"{n1}{n2}{n3}{n4} ");

                //if(n % n1 == 0 &&
                //   n % n2 == 0 &&
                //   n % n3 == 0 &&
                //   n % n4 == 0)
                // {
                //     Console.Write($"{n1}{n2}{n3}{n4} ");
                // }
            }
        }
    }
}

//for(int i = 1111; i <= 9999; i++)
//{
//    bool isSpecial = true;
//    int number = i;
//    while(number != 0)
//    {
//        int lastDigit = number % 10;

//        if (lastDigit == 0 || n % lastDigit != 0)
//        {
//            isSpecial = false;
//            break;
//        }

//        number /= 10;
//    }

//    if (isSpecial)
//    {
//        Console.Write($"{i} ");
//    }
//}