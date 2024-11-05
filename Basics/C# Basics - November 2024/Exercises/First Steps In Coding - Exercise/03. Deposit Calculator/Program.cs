
double deposit = double.Parse(Console.ReadLine());
int term = int.Parse(Console.ReadLine());
double rate = double.Parse(Console.ReadLine()) / 100;

//сума = депозит  + срок * ((депозит * лихвен процент ) / 12)
double sum = deposit + term * (deposit * rate / 12);

Console.WriteLine(sum);