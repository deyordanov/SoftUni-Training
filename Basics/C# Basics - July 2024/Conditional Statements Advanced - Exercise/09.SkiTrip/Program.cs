// Price per room
double pricePerRoomForOnePersonStay = 18;
double pricePerApartmentStay = 25;
double pricePerPresidentApartmentStay = 35;

// Rooms
string roomForOnePerson = "room for one person";
string apartment = "apartment";
string presidentApartment = "president apartment";

// Reviews
string positive = "positive";
string negative = "negative";

int daysToStay = int.Parse(Console.ReadLine());
string room = Console.ReadLine();
string review = Console.ReadLine();

int overnightStays = daysToStay - 1;

double discount = 1;
double roomPricePerStay = 0;
if (room == roomForOnePerson)
{
    roomPricePerStay = pricePerRoomForOnePersonStay;
}
else if (room == apartment)
{
    roomPricePerStay = pricePerApartmentStay;
    if (overnightStays < 10)
    {
        discount = 0.7;
    }
    else if (overnightStays <= 15)
    {
        discount = 0.65;
    }
    else
    {
        discount = 0.5;
    }
}
else if (room == presidentApartment)
{
    roomPricePerStay = pricePerPresidentApartmentStay;
    if (overnightStays < 10)
    {
        discount = 0.9;
    }
    else if (overnightStays <= 15)
    {
        discount = 0.85;
    }
    else
    {
        discount = 0.8;
    }
}

double totalPrice = overnightStays * roomPricePerStay * discount;

if (review == positive)
{
    totalPrice = totalPrice * 1.25;
}
else if (review == negative)
{
    totalPrice = totalPrice * 0.9;
}

Console.WriteLine($"{totalPrice:f2}");