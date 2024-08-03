int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int cakeSize = width * height;

int totalPiecesTaken = 0;
string input = "";
while((input = Console.ReadLine()) != "STOP")
{
    int piecesOfCakeTaken = int.Parse(input);
    totalPiecesTaken += piecesOfCakeTaken;

    if(totalPiecesTaken > cakeSize)
    {
        Console.WriteLine($"No more cake left! You need {totalPiecesTaken - cakeSize} pieces more.");
        return;
    }
}

Console.WriteLine($"{cakeSize - totalPiecesTaken} pieces are left.");