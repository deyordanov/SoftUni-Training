int numberOfUnsatisfactoryGrades = int.Parse(Console.ReadLine());

int numbersOfProblemsSolved = 0;
int currentNumberOfUnsatisfactoryGrades = 0;
int sumOfGrades = 0;
string lastProblem = "";
string problemName = "";
while((problemName = Console.ReadLine()) != "Enough")
{
    int grade = int.Parse(Console.ReadLine());
    numbersOfProblemsSolved++;
    sumOfGrades += grade;

    lastProblem = problemName;

    if (grade <= 4 && ++currentNumberOfUnsatisfactoryGrades == numberOfUnsatisfactoryGrades)
    {
        break;
    }

    //if (grade <= 4)
    //{
    //    if(currentNumberOfUnsatisfactoryGrades == numberOfUnsatisfactoryGrades)
    //    {
    //        break;
    //    }
    //}
}

if (currentNumberOfUnsatisfactoryGrades == numberOfUnsatisfactoryGrades)
{
    Console.WriteLine($"You need a break, {currentNumberOfUnsatisfactoryGrades} poor grades.");
}
else
{
    Console.WriteLine($"Average score: {1.0 * sumOfGrades / numbersOfProblemsSolved:f2}");
    Console.WriteLine($"Number of problems: {numbersOfProblemsSolved}");
    Console.WriteLine($"Last problem: {lastProblem}");
}