double excursionPrice = double.Parse(Console.ReadLine());
double availableMoney = double.Parse(Console.ReadLine());

int moneySpentInARow = 0;
int days = 0;
bool isMoneySaved = true;
while(availableMoney < excursionPrice)
{
    string action = Console.ReadLine();
    double money = double.Parse(Console.ReadLine());
    days++;

    if(action == "save")
    {
        availableMoney += money;
        moneySpentInARow = 0;
    }
    else if(action == "spend")
    {
        availableMoney = availableMoney - money < 0 ? 0 : availableMoney - money;

        // The above expression is called a Ternary Operator, it is the equievelent of this if-else check:
        // The '?' character is the same as 'if(...)'.
        // The ':' charachter is the same as 'else'.
        //if(availableMoney - money < 0)
        //{
        //    availableMoney = 0;
        //}
        //else
        //{
        //    availableMoney = availableMoney - money;
        //}

        if(++moneySpentInARow == 5)
        {
            isMoneySaved = false;
            break;
        }
    }
}

if(isMoneySaved)
{
    Console.WriteLine($"You saved the money for {days} days.");
}
else
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(days);
}