// 14. Write a program that given two numbers finds their greatest common divisor (GCD).

Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine());

while (a != 0 && b != 0)
{
    if (a > b)
        a %= b;
    else
        b %= a;
}

//return a|b;

if (a == 0) Console.WriteLine("GCD is:{0}", b);
else Console.WriteLine("GCD is:{0}", a);