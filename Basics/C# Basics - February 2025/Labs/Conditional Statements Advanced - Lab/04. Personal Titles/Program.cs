double age = double.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());

string title = "";
if (age < 16)
{
    if (gender == 'm')
    {
        title = "Master";
    }
    else if (gender == 'f')
    {
        title = "Miss";
    }
}
else if (age >= 16)
{
    if (gender == 'm')
    {
        title = "Mr.";
    }
    else if (gender == 'f')
    {
        title = "Ms.";
    }
}

Console.WriteLine(title);