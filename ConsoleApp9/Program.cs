//Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program
//should prompt the user to enter another number.

int a, b, c, d, e;
bool parseSucceed = false;
int sum = 0;

do
{
    Console.Write("Enter first number: ");
    parseSucceed = Int32.TryParse(Console.ReadLine(), out a);
    Console.WriteLine(parseSucceed);
} while (!parseSucceed);

do
{
    Console.Write("Enter second number: ");
    parseSucceed = Int32.TryParse(Console.ReadLine(), out b);
    Console.WriteLine(parseSucceed);
} while (!parseSucceed);

do
{
    Console.Write("Enter third number: ");
    parseSucceed = Int32.TryParse(Console.ReadLine(), out c);
    Console.WriteLine(parseSucceed);
} while (!parseSucceed);

do
{
    Console.Write("Enter fourth number: ");
    parseSucceed = Int32.TryParse(Console.ReadLine(), out d);
    Console.WriteLine(parseSucceed);
} while (!parseSucceed);

do
{
    Console.Write("Enter fifth number: ");
    parseSucceed = Int32.TryParse(Console.ReadLine(), out e);
    Console.WriteLine(parseSucceed);
} while (!parseSucceed);

for (int i = 0; i < 10; i++)
{

}