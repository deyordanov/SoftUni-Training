string bookToFind = Console.ReadLine();

int countOfBooks = 0;
bool isBookFound = false;
string book = Console.ReadLine();
while (book != "No More Books")
{
    if (book == bookToFind)
    {
        isBookFound = true;
        break;
    }
    countOfBooks++;

    book = Console.ReadLine();
}

if (isBookFound)
{
    Console.WriteLine($"You checked {countOfBooks} books and found it.");
}
else
{
    Console.WriteLine($"The book you search is not here!");
    Console.WriteLine($"You checked {countOfBooks} books.");
}

//string bookToFind = Console.ReadLine();

//int countOfBooks = 0;
//string book = "";
//while (book != "No More Books")
//{
//    book = Console.ReadLine(); // No More Books

//    if (book == bookToFind) break;

//    if (book != "No More Books")
//    {
//        countOfBooks++;
//    }
//}

//if (isBookFound)
//{
//    Console.WriteLine($"You checked {countOfBooks} books and found it.");
//}
//else
//{
//    Console.WriteLine($"The book you search is not here!");
//    Console.WriteLine($"You checked {countOfBooks} books.");
//}