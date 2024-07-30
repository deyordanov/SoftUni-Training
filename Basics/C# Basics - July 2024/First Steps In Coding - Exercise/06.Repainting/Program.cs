// Constants
double nylonPrice = 1.50;
double paintPrice = 14.50;
double distillerPrice = 5.00;

// Input
int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int distiller = int.Parse(Console.ReadLine());
int workersHours = int.Parse(Console.ReadLine());

// Calculations
double totalNylonPrice = (nylon + 2) * nylonPrice;
double totalPaintPrice = (paint * 1.1) * paintPrice;
double totalDistillerPrice = distiller * distillerPrice;
double totalItemsSum = totalNylonPrice + totalPaintPrice + totalDistillerPrice + 0.40;
double workersSalaryPerHour = totalItemsSum * 0.3;
double totalWorkersSalary = workersHours * workersSalaryPerHour;
double total = totalItemsSum + totalWorkersSalary;

// Output
Console.WriteLine(total);