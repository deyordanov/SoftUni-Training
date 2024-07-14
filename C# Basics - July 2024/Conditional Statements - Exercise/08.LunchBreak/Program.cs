string tvShowName = Console.ReadLine();
int episodeDuration = int.Parse(Console.ReadLine());
int breakDuration = int.Parse(Console.ReadLine());

double lunchDuration = breakDuration * 0.125; // lunchDuration = breakDuration * (1 / 8.0);
double relaxDuration = breakDuration * 0.25; // relaxDuration = breakDuration * (1 / 4.0);
double timeLeft = breakDuration - (lunchDuration + relaxDuration);

double diff = Math.Ceiling(Math.Abs(timeLeft - episodeDuration));
if(timeLeft >= episodeDuration)
{
    Console.WriteLine($"You have enough time to watch {tvShowName} and left with {diff} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {tvShowName}, you need {diff} more minutes.");
}