// 9. Write an if- statement that takes two integer variables and exchanges their values
// if the first one is greater than the second one.


Console.Write("Enter first number (x): ");
int x = Int32.Parse(Console.ReadLine());
Console.Write("Enter second number (y): ");
int y = Int32.Parse(Console.ReadLine());

if (x > y)
{
    //replacing the variable
    x = x + y;
    y = x - y;
    x = x - y;
}

Console.WriteLine("First number is {0}, Second number is {1}. After the variable has been exchanged", x, y);