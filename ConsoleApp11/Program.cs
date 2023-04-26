//5. Write a program that reads from the console two integer numbers (int) and prints how many numbers between
//them exist, such that the remainder of their division by 5 is 0. Example:
//in the range (14, 25) there are 3 such numbers: 15, 20 and 25.


int rangeOfNumber = 0;

Console.Write("Enter first integer: ");
int firstInteger = Int32.Parse(Console.ReadLine());

Console.Write("Enter second integer: ");
int secondInteger = Int32.Parse(Console.ReadLine());

for (int i = firstInteger; i <= secondInteger; i++)
{
    if (i % 5 == 0) rangeOfNumber++;
}

Console.WriteLine("there are {0} numbers between {1} and {2}.", rangeOfNumber, firstInteger, secondInteger);