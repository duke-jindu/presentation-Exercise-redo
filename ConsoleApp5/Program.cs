// 11. Write a program that finds the greatest of given 5 numbers.

Console.Write("Enter first number: ");
int a = Int32.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int b = Int32.Parse(Console.ReadLine());

Console.Write("Enter third number: ");
int c = Int32.Parse(Console.ReadLine());

Console.Write("Enter fourth number: ");
int d = Int32.Parse(Console.ReadLine());

Console.Write("Enter fifth number: ");
int e = Int32.Parse(Console.ReadLine());

if (a < b) a = b;
//means b is greater than a
if (a < c) a = c;
// c > a
if (a < d) a = d;
// d > a
if (a < e) a = e;
// e > a

Console.WriteLine("{0} is the biggest number.", a);