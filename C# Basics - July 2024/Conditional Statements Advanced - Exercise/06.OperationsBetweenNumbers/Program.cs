int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
string operation = Console.ReadLine();

double operationResult = 0;
if ((operation == "/" || operation == "%") && n2 == 0)
{
    Console.WriteLine($"Cannot divide {n1} by zero");
}
else
{
    // We cannot extract constants when we want to use a 'switch' construction!
    // You will find out why in the next modules at SoftUni :)
    switch (operation)
    {
        case "+":
            operationResult = n1 + n2;
            break;

        case "-":
            operationResult = n1 - n2;
            break;

        case "*":
            operationResult = n1 * n2;
            break;

        case "/":
            operationResult = n1 / (double)n2;
            break;

        case "%":
            operationResult = n1 % n2;
            break;
    }

    if (operation == "+" || operation == "-" || operation == "*")
    {
        string evenOrOdd = "";
        if (operationResult % 2 == 0)
        {
            evenOrOdd = "even";
        }
        else
        {
            evenOrOdd = "odd";
        }

        Console.WriteLine($"{n1} {operation} {n2} = {operationResult} - {evenOrOdd}");
    }
    else if (operation == "/")
    {
        Console.WriteLine($"{n1} {operation} {n2} = {operationResult:f2}");
    }
    else if (operation == "%")
    {
        Console.WriteLine($"{n1} {operation} {n2} = {operationResult}");
    }
}