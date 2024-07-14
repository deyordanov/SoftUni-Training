int firstTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int totalSeconds = firstTime + secondTime + thirdTime;
int minutes = totalSeconds / 60;
int seconds = totalSeconds % 60;

// Concatenation
// Console.WriteLine(minutes + ":" + seconds);

// Interpolation
if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}