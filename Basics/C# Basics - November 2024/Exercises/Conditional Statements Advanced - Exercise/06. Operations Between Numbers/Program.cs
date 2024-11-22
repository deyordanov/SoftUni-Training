//1. Четем от конзолата 2 числа и оператор („+“, „-“, „*“, „/“, „%“)
using System.ComponentModel.Design;

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());

//2. Проверяваме дали 
if ( operation == '+' || operation == '-' || operation == '*')
{
    int result = 0;
    switch (operation)
    {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
            break;
        case '*':
            result = num1 * num2;
            break;
    }

    if (result % 2 == 0)
        Console.WriteLine($"{num1} {operation} {num2} = {result} - even");
    else
        Console.WriteLine($"{num1} {operation} {num2} = {result} - odd");
}
else //„/“, „%“
{
    if (num2 == 0)
        Console.WriteLine($"Cannot divide {num1} by zero");
    else if (operation == '/')
        Console.WriteLine($"{num1} / {num2} = {(double)num1 / num2:f2}");
    else // '%'
        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");


}
