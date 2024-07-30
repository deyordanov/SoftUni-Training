int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

int volume = length * width * height;
double volumeInLiters = volume * 0.001;
double percentageOfVolumeNotTakenByWater = percentage * 0.01;
double volumeInLitersNotTakenByWater = volumeInLiters * percentageOfVolumeNotTakenByWater;
double volumeTakenByWater = volumeInLiters - volumeInLitersNotTakenByWater;

Console.WriteLine(volumeTakenByWater);