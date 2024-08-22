const int baseHeight = 5364;
const int peakHeight = 8848;

// We start from '1' since up until now ( for the first day ) we accept Atanas has climbed up to the height of the camp - 5364 meters
int daysClimbed = 1;
int totalMetersClimbed = baseHeight;
bool isPeakReached = false;
string command;
while((command = Console.ReadLine()) != "END" && daysClimbed < 5)
{
    string sleepOrClimb = command;
    if (command == "Yes")
    {
        daysClimbed++;
    }

    int metersClimbed = int.Parse(Console.ReadLine());

    totalMetersClimbed += metersClimbed;

    if (totalMetersClimbed >= peakHeight)
    {
        isPeakReached = true;
        break; // The 'return' keyword can be used here! This way we wouldn't need the boolean variable 'isPeakReached'.
    }
}

if (isPeakReached)
{
    Console.WriteLine($"Goal reached for {daysClimbed} days!");
}
else
{
    Console.WriteLine("Failed!");
    Console.WriteLine(totalMetersClimbed);
}