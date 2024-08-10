int n = int.Parse(Console.ReadLine());

double totalGrades = 0;
int presentationsCount = 0;
string command;
while((command = Console.ReadLine()) != "Finish")
{
    double currentGrade = 0;
    string presentationName = command;
    presentationsCount++;
    for(int i = 1; i <= n; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        currentGrade += grade;
        totalGrades += grade;
    }

    Console.WriteLine($"{presentationName} - {currentGrade / n:f2}.");
}

Console.WriteLine($"Student's final assessment is {totalGrades / (n * presentationsCount):f2}.");