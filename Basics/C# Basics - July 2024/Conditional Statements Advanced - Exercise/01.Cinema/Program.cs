int premiereTicketPrice = 12;
double normalTicketPrice = 7.5;
int discountTicketPrice = 5;

string projectionType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

double ticketPrice;
switch (projectionType)
{
    case "Premiere":
        ticketPrice = premiereTicketPrice;
        break;

    case "Normal":
        ticketPrice = normalTicketPrice;
        break;

    case "Discount":
        ticketPrice = discountTicketPrice;
        break;

    default:
        ticketPrice = 0;
        break;
}

// if (projectionType == "Premiere")
// {
//     ticketPrice = premiereTicketPrice;
// }
// else if (projectionType == "Normal")
// {
//     ticketPrice = normalTicketPrice;
// }
// else if (projectionType == "Discount")
// {
//     ticketPrice = discountTicketPrice;
// }

int seats = rows * cols;
double profit = seats * ticketPrice;

Console.WriteLine($"{profit:f2} leva");