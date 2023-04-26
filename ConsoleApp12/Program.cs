// 3.Write an expression that checks for a given integer if its third digit (right to left) is 7.

Console.Write("Please enter a FIVE digit number: ");

int number = int.Parse(Console.ReadLine());
int thirdDigit = (number / 100) % 10;

if (thirdDigit == 7)
{

    Console.WriteLine("The third digits of {0} IS seven(7)!", number);
}
else
{
    Console.WriteLine("The third digit of {0} IS NOT seven(7).", number);
}
