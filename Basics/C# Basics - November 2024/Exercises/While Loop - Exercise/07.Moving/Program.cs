int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int roomVolume = width * length * height;

string input = "";
while((input = Console.ReadLine()) != "Done")
{
    int boxesVolume = int.Parse(input);
    roomVolume -= boxesVolume;

    if(roomVolume < 0)
    {
        Console.WriteLine($"No more free space! You need {Math.Abs(roomVolume)} Cubic meters more.");
        return;
    }
}

Console.WriteLine($"{roomVolume} Cubic meters left.");