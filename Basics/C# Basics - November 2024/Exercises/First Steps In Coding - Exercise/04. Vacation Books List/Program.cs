
int pages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int time = pages / pagesPerHour;
int hoursPerDay = time / days;

Console.WriteLine(hoursPerDay);