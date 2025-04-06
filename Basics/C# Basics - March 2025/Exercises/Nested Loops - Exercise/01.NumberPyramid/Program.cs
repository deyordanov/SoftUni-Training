int n = int.Parse(Console.ReadLine());

// 3. The same soltuion without the 'return' keyword:
int number = 1;
bool isBigger = false;
for(int row = 1; row <= n; row++)
{
    for(int col = 1; col <= row; col++)
    {
        if(number > n)
        {
            isBigger = true;
            break;
        }

        Console.Write($"{number++} ");
    }

    if(isBigger)
    {
        break;
    }

    Console.WriteLine();
}

// 2. A solution using the 'return' keyword:
//int number = 1;
//for(int row = 1; row <= n; row++)
//{
//    for(int col = 1; col <= row; col++)
//    {
//        if (number > n)
//        {
//            return;
//        }

//        Console.Write($"{number++} ");
//    }
//    Console.WriteLine();
//}

// 1. The "cleanest" solution:
//int row = 1;
//int col = 1;

//for(int i = 1; i <= n; i++)
//{
//    Console.Write($"{i} ");

//    if(col == row)
//    {
//        col = 1;
//        row++;
//        Console.WriteLine();
//    }
//    else
//    {
//        col++;
//    }
//}

