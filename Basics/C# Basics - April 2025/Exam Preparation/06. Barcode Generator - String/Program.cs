string num1 = Console.ReadLine();
string num2 = Console.ReadLine();

// Extract the first number's digits
int num1FirstDigit = int.Parse(num1[0].ToString());
int num1SecondDigit = int.Parse(num1[1].ToString());
int num1ThirdDigit = int.Parse(num1[2].ToString());
int num1FourthDigit = int.Parse(num1[3].ToString());

// Extract the second number's digits
int num2FirstDigit = int.Parse(num2[0].ToString());
int num2SecondDigit = int.Parse(num2[1].ToString());
int num2ThirdDigit = int.Parse(num2[2].ToString());
int num2FourthDigit = int.Parse(num2[3].ToString());

for (int i = num1FirstDigit; i <= num2FirstDigit; i++)
{
    for (int j = num1SecondDigit; j <= num2SecondDigit; j++)
    {
        for (int k = num1ThirdDigit; k <= num2ThirdDigit; k++)
        {
            for (int l = num1FourthDigit; l <= num2FourthDigit; l++)
            {
                if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                {
                    Console.Write($"{i}{j}{k}{l} ");
                }
            }
        }
    }
}