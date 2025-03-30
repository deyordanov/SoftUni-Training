// With the keyword 'const' we can declare that a variable is a constants, its value will NEVER change.
const int stepsGoal = 10000;
//stepsGoal = 2000; -> for example, this will not work, we cannot change a constant's value!

int totalSteps = 0;
string input = "";
while((input = Console.ReadLine()) != "Going home")
{
    int steps = int.Parse(input);
    totalSteps += steps;

    if(totalSteps >= stepsGoal)
    {
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{totalSteps - stepsGoal} steps over the goal!");
        // 'return' is a keyword which stops the WHOLE program, it doesn't simply break the while / for cycle.
        return;
    }

    //if(totalSteps >= stepsGoal)
    //{
    //    break;
    //}
}

int finalSteps = int.Parse(Console.ReadLine());
totalSteps += finalSteps;
//if(totalSteps < stepsGoal)
//{
//    int finalSteps = int.Parse(Console.ReadLine());
//    totalSteps += finalSteps;
//}

if (totalSteps >= stepsGoal)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{totalSteps - stepsGoal} steps over the goal!");
}
else
{
    Console.WriteLine($"{stepsGoal - totalSteps} more steps to reach goal.");
}