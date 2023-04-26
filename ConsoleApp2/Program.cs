// 13.  Write a program that reads from the console number N and print the sum of the first N members of the
// Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377

using System.Numerics;

//using  biginterger to eleminate the (-) sign
BigInteger ffN = 0;
BigInteger sfN = 1;
BigInteger tfN = 0;


Console.Write("enter fibonacci length (N): ");
int length = int.Parse(Console.ReadLine());

Console.Write("{0}, {1},", ffN, sfN);


for (int i = 2; i < length; i++)
{
    tfN = ffN + sfN;
    Console.Write(" {0}'", tfN);
    ffN = sfN;
    sfN = tfN;
}