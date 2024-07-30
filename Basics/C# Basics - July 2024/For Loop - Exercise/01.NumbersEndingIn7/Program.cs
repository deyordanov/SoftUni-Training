// 2. Optimized, we make 100 loops
for (int i = 7; i <= 997; i += 10)
{
    if (i % 10 == 7)
    {
        Console.WriteLine(i);
    }
}

// 1. Not optimized, we make 1000 loops
// for (int i = 1; i <= 1000; i++)
// {
//     if (i % 10 == 7)
//     {
//         Console.WriteLine(i);
//     }
// }