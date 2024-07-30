// Ship rent price
double shipSpringRentPrice = 3000;
double shipSummerRentPrice =  4200;
double shipAutumnRentPrice = 4200;
double shipWinterRentPrice = 2600;

// Seasons
string spring = "Spring";
string summer = "Summer";
string autumn = "Autumn";
string winter = "Winter";

int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermenCount = int.Parse(Console.ReadLine());

double shipRentPrice = 0;
if (season == spring)
{
    shipRentPrice = shipSpringRentPrice;
}
else if (season == summer)
{
    shipRentPrice = shipSummerRentPrice;
}
else if (season == autumn)
{
    shipRentPrice = shipAutumnRentPrice;
}
else if (season == winter)
{
    shipRentPrice = shipWinterRentPrice;
}

// Keep in mind that we can pass a negative value for 'fishermenCount'.
// That will not happen based on the problem's description, but like I have said:
// imagine you are solving a real-world problem when solving a given problem.
// That is why we want to specify all conditions for the value of 'fishermenCount'
// in this if-else construction ->
double discount = 1;
if (fishermenCount <= 6)
{
    discount = 0.9;
}
else if (fishermenCount > 6 && fishermenCount <= 11)
{
    discount = discount = 0.85;
}
else if(fishermenCount >= 12)
{
    discount = 0.75;
}

double totalPrice = shipRentPrice * discount;

// if (fishermenCount % 2 == 0 && (season == spring || season == summer || season == winter))
if (fishermenCount % 2 == 0 && season != autumn)
{
    totalPrice = totalPrice * 0.95;
}

double diff = Math.Abs(totalPrice - budget);
// Instead of using $"{diff:f2}":
// This way we can reuse it in both output messages!
string formattedDiff = diff.ToString("f2");
if (budget >= totalPrice)
{
    Console.WriteLine($"Yes! You have {formattedDiff} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {formattedDiff} leva.");
}