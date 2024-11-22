//1. Четем като вход от конзолата час и минути на изпита и ги преобразуваме в минути
int examHour = int.Parse(Console.ReadLine());
int examMin = int.Parse(Console.ReadLine());
examMin += examHour * 60; //минутите от началото на деня до изпита

//2. Четем като вход от конзолата час и минути на пристигане и ги преобразуваме в минути
int arrivalHour = int.Parse(Console.ReadLine());
int arrivalMin = int.Parse(Console.ReadLine());
arrivalMin += arrivalHour * 60; //минутите от началото на деня до пристигането


//3. Намирмае разликата между времето на пристигане и изпита 
int diffMin = examMin - arrivalMin;

if (diffMin < 0)
{
    Console.WriteLine("Late");

    diffMin = Math.Abs(diffMin);

    if (diffMin < 60)
        Console.WriteLine($"{diffMin} minutes after the start");
    else
        Console.WriteLine($"{diffMin/60}:{diffMin%60:D2} hours after the start");
}
else if (diffMin <= 30)
{
    Console.WriteLine("On time");

    if (diffMin > 0) 
        Console.WriteLine($"{diffMin} minutes before the start");
}
else 
{
    Console.WriteLine("Early");

    if (diffMin < 60)
        Console.WriteLine($"{diffMin} minutes before the start");
    else
        Console.WriteLine($"{diffMin / 60}:{diffMin % 60:D2} hours before the start");
}

