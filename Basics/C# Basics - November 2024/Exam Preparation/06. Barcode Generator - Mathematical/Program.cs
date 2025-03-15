int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

// Extract the first number's digits
int num1FourthDigit = num1 % 10;
num1 /= 10;

int num1ThirdDigit = num1 % 10;
num1 /= 10;

int num1SecondDigit = num1 % 10;
num1 /= 10;

int num1FirstDigit = num1 % 10;
num1 /= 10;

// Extract the second number's digits
int num2FourthDigit = num2 % 10;
num2 /= 10;

int num2ThirdDigit = num2 % 10;
num2 /= 10;

int num2SecondDigit = num2 % 10;
num2 /= 10;

int num2FirstDigit = num2 % 10;
num2 /= 10;

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