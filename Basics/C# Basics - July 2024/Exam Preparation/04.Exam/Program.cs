int students = int.Parse(Console.ReadLine());

int firstGroup = 0; // students with grades from 2.00 to 2.99
int secondGroup = 0; // students with grades from 3.00 to 3.99
int thirdGroup = 0; // students with grades from 4.00 to 4.99
int fourthGroup = 0; // students with grades from 5.00 and above

double sumOfGrades = 0;
for (int i = 0; i < students; i++)
{
    double grade = double.Parse(Console.ReadLine());
    sumOfGrades += grade;

    if (grade <= 2.99) firstGroup++;
    else if (grade <= 3.99) secondGroup++;
    else if (grade <= 4.99) thirdGroup++;
    else fourthGroup++;
}

Console.WriteLine($"Top students: {(double)fourthGroup / students:p2}");
Console.WriteLine($"Between 4.00 and 4.99: {(double)thirdGroup / students:p2}");
Console.WriteLine($"Between 3.00 and 3.99: {(double)secondGroup / students:p2}");
Console.WriteLine($"Fail: {(double)firstGroup / students:p2}");
Console.WriteLine($"Average: {(double)sumOfGrades / students:f2}");