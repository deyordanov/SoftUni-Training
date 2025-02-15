int hour = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

bool isHourValid = hour >= 10 && hour <= 18;
if (isHourValid && 
    (day == "Monday" ||
    day == "Tuesday" ||
    day == "Wednesday" ||
    day == "Thursday" ||
    day == "Friday" ||
    day == "Saturday"))
{
    Console.WriteLine("open");
}
else
{
    Console.WriteLine("closed");
}