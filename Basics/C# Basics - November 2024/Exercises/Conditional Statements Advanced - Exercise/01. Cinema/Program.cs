//1. Четем входни данни: тип билети (string), редове и колони в залата (int)
string ticketsType = Console.ReadLine();
int row = int.Parse(Console.ReadLine());    
int col = int.Parse(Console.ReadLine());

//2. Намираме местата в залата (редове * колони)
double income = row * col;

//3. намираме какъв е типа на прожекцията и какъв е прихода (цената на билета * местата в залата):
if (ticketsType == "Premiere")
    income *= 12.00;
else if (ticketsType == "Normal")
    income *= 7.50;
else
    income *= 5.00;


/*switch (ticketsType)
{
    case "Premiere":
        income *= 12.00;
        break;
    case "Normal":
        income *= 7.50;
        break;
    case "Discount":
        income *= 5.00;
        break;
}
*/

//4. Отпечатваме резултата:
//Console.WriteLine("{0:f2} leva", income);
Console.WriteLine($"{income:f2} leva");