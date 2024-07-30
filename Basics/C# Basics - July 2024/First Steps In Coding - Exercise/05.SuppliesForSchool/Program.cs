double pricePerPenPacket = 5.80;
double pricePerMarkerPacket = 7.20;
double pricePerDistillerLiter = 1.20;

int penPackets = int.Parse(Console.ReadLine());
int markerPackets = int.Parse(Console.ReadLine());
int distillerLiters = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double penPacketsPrice = penPackets * pricePerPenPacket;
double markerPacketsPrice = markerPackets * pricePerMarkerPacket;
double distillerPrice = distillerLiters * pricePerDistillerLiter;
double totalPrice = penPacketsPrice + markerPacketsPrice + distillerPrice;
double totalPriceWithDiscount = totalPrice - (totalPrice * (discount * 0.01));

Console.WriteLine(totalPriceWithDiscount);