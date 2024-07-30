int examHour = int.Parse(Console.ReadLine());
int examMinute = int.Parse(Console.ReadLine());
int hour = int.Parse(Console.ReadLine());
int minute = int.Parse(Console.ReadLine());

int examMinutes = examHour * 60 + examMinute;
int minutes = hour * 60 + minute;

int differenceInMinutes = examMinutes - minutes;

string verdict = "";
if (differenceInMinutes < 0)
{
    Console.WriteLine("Late");
    verdict = "after the start";
}
else if (differenceInMinutes <= 30)
{
    Console.WriteLine("On Time");
    verdict = "before the start";
}
else
{
    Console.WriteLine("Early");
    verdict = "before the start";
}

if (differenceInMinutes != 0)
{
    int absoluteDifferenceInMinutes = Math.Abs(differenceInMinutes);
    if (absoluteDifferenceInMinutes < 60)
    {
        Console.WriteLine($"{absoluteDifferenceInMinutes} minutes {verdict}");
    }
    else
    {
        int verdictHours = absoluteDifferenceInMinutes / 60;
        int verdictMinutes = absoluteDifferenceInMinutes % 60;
        if (verdictMinutes < 10)
        {
            Console.WriteLine($"{verdictHours}:0{verdictMinutes} hours {verdict}");
        }
        else
        {
            Console.WriteLine($"{verdictHours}:{verdictMinutes} hours {verdict}");
        }
    }
}