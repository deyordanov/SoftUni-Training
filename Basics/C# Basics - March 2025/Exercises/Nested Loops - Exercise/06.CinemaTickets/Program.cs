int studentTickets = 0;
int standardTickets = 0;
int kidTickets = 0;
string command;
while((command = Console.ReadLine()) != "Finish")
{
    string projectionName = command;
    int freeSeats = int.Parse(Console.ReadLine());
    int currentSeatsTaken = 0;

    string projectionType;
    while(currentSeatsTaken < freeSeats && (projectionType = Console.ReadLine()) != "End")
    {
        currentSeatsTaken++;
        if (projectionType == "student") studentTickets++;
        else if (projectionType == "standard") standardTickets++;
        else if (projectionType == "kid") kidTickets++;
    }

    Console.WriteLine($"{projectionName} - {(double)currentSeatsTaken / freeSeats:p2} full.");
}

int totalTickets = studentTickets + standardTickets + kidTickets;
Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{(double)studentTickets / totalTickets:p2} student tickets.");
Console.WriteLine($"{(double)standardTickets / totalTickets:p2} standard tickets.");
Console.WriteLine($"{(double)kidTickets / totalTickets:p2} kids tickets.");