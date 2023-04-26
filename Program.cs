// 8. Write a program that prints on the console the first 100 numbers in the
// Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …


using System.Numerics;

// to eliminate the negative(-) signs
BigInteger firstNumber = 0;
BigInteger secondNumber = 1;
BigInteger sum = 1;
BigInteger count = 0;

Console.Write(firstNumber);

while (count < 100)
{
    sum = firstNumber + secondNumber;
    firstNumber = secondNumber;
    secondNumber = sum;
    Console.Write(secondNumber);
    count++;
}
Console.ReadKey();