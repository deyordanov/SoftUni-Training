
int volume = int.Parse(Console.ReadLine())
            * int.Parse(Console.ReadLine())
            * int.Parse(Console.ReadLine());

double volumeInLiters = volume * 0.001;

double occupiedSpace = double.Parse(Console.ReadLine())/100;

double requiredLiters = volumeInLiters - volumeInLiters * occupiedSpace;

Console.WriteLine(requiredLiters);