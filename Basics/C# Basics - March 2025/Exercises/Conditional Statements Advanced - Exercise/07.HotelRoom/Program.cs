// Months
string may = "May";
string june = "June";
string july = "July";
string august = "August";
string september = "September";
string october = "October";

string month = Console.ReadLine();
int overnightStays = int.Parse(Console.ReadLine());

double priceForStudioPerNight = 0;
double priceForApartmentPerNight = 0;
if (month == may || month == october)
{
    priceForStudioPerNight = 50;
    priceForApartmentPerNight = 65;

    if (overnightStays > 14)
    {
        priceForStudioPerNight = priceForStudioPerNight * 0.7;
    }
    else if (overnightStays > 7)
    {
        priceForStudioPerNight = priceForStudioPerNight * 0.95;
    }
}
else if (month == june || month == september)
{
    priceForStudioPerNight = 75.2;
    priceForApartmentPerNight = 68.7;
    if (overnightStays > 14)
    {
        priceForStudioPerNight = priceForStudioPerNight * 0.8;
    }
}
else if (month == july || month == august)
{
    priceForStudioPerNight = 76;
    priceForApartmentPerNight = 77;
}

if (overnightStays > 14)
{
    priceForApartmentPerNight = priceForApartmentPerNight * 0.9;
}

double totalStudioPrice = priceForStudioPerNight * overnightStays;
double totalApartmentPrice = priceForApartmentPerNight * overnightStays;

Console.WriteLine($"Apartment: {totalApartmentPrice:f2} lv.");
Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");