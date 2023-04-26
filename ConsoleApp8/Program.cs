//Write a program that reads an integer number 'n'  from the console.
//After that reads 'n' numbers from the console and prints their sum.


int sum = 0;

Console.Write("Enter integer numbers: ");
int length = Int32.Parse(Console.ReadLine());

for (int i = 0; i < length; i++)
{
    Console.Write("Enter {0} number: ", i + 1);
    sum += Int32.Parse(Console.ReadLine());
}

Console.WriteLine("Sum of all numbers is {0}.", sum);
