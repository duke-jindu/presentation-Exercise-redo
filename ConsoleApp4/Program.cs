// 6. Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c,
// calculates and prints its real roots (if they exist). Quadratic equations may have 0, 1 or 2 real roots.


Console.Write("where A is: ");
int a = int.Parse(Console.ReadLine());

Console.Write("where B is: ");
int b = int.Parse(Console.ReadLine());

Console.Write("where C is: ");
int c = int.Parse(Console.ReadLine());

//using D = ( b * b - 4 * a * c )

int D = (b * b - 4 * a * c);

if (D < 0)
{
    Console.WriteLine("D = {0}  'no real roots' ", D);
}
else if (D == 0)
{
    // solving for X1
    int x1 = (-b / 2 * a);
    Console.WriteLine("X1 = {0}", x1);
}
else
{
    //solving for the positive(+) root
    int x1 = (int)(-b + Math.Sqrt(D)) / (2 * a);

    //solving for the negative(-) root
    int x2 = (int)(-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine("X1 = {0} \nX2 = {1}", x1, x2);
}