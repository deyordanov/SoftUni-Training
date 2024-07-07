int pageCount = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int daysCount = int.Parse(Console.ReadLine());

int timeToReadTheBook = pageCount / pagesPerHour;
int hoursPerDay = timeToReadTheBook / daysCount;

Console.WriteLine(hoursPerDay);