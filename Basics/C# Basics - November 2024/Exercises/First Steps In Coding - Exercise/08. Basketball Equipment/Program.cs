int taxPerYear = int.Parse(Console.ReadLine()); 

//кецове – цената им е 40% по-малка от таксата за една година
double shoes = taxPerYear - taxPerYear * 0.4; //taxPerYear * 0.6;
//екип – цената му е 20% по-малка от тази на кецовете
double outfit = shoes - shoes * 0.2; // shoes * 0.8
//топка – цената ѝ е 1 / 4 от цената на баскетболния екип
double ball = outfit / 4;
//аксесоари – цената им е 1 / 5 от цената на баскетболната топка
double acc = ball / 5;

double sum = taxPerYear + shoes + outfit + ball + acc;
Console.WriteLine(sum);
