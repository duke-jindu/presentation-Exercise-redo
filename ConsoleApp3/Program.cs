// 12.Given 5 integer numbers write a program that find those subsets whose sum is 0,
// E.g given {3, -2, 1, 1, 8} sum = -2 ,1 and 1 = 0


Console.Write("Enter first integer number: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter second integer number: ");
int second = int.Parse(Console.ReadLine());
Console.Write("Enter third integer number: ");
int third = int.Parse(Console.ReadLine());
Console.Write("Enter fourth integer number: ");
int fourth = int.Parse(Console.ReadLine());
Console.Write("Enter fifth interger number: ");
int fifth = int.Parse(Console.ReadLine());

//first section
if (first + second == 0)
    Console.WriteLine("{0} + {1} = 0", first, second);

if (first + third == 0)
    Console.WriteLine("{0} + {1} = 0", first, third);

if (first + fourth == 0)
    Console.WriteLine("{0} + {1} = 0", first, fourth);

if (first + fifth == 0)
    Console.WriteLine("{0} + {1} = 0", first, fifth);

// second section
if (second + third == 0)
    Console.WriteLine("{0} + {1} = 0", second, third);

if (second + fourth == 0)
    Console.WriteLine("{0} + {1} = 0", second, fourth);

if (second + fifth == 0)
    Console.WriteLine("{0} + {1} = 0", second, fifth);

//third section
if (third + fourth == 0)
    Console.WriteLine("{0} + {1} = 0", third, fourth);

if (third + fifth == 0)
    Console.WriteLine("{0} + {1} = 0", third, fifth);

// fourth section
if (fourth + fifth == 0)
    Console.WriteLine("{0} + {1} = 0", fourth, fifth);

// 3 compair
if (first + second + third == 0)
    Console.WriteLine("{0} + {1} + {2} = 0", first, second, third);

if (first + second + fourth == 0)
    Console.WriteLine("{0} + {1} + {2} = 0", first, second, fourth);

if (first + second + fifth == 0)
    Console.WriteLine("{0} + {1} + {2} = 0", first, second, fifth);

if (first + third + fourth == 0)
    Console.WriteLine("{0} + {1} + {2} = 0", first, third, fourth);

if (first + third + fifth == 0)
    Console.WriteLine("{0} + {1} + {2} = 0", first, third, fifth);

if (second + third + fourth == 0)
    Console.WriteLine("{0} + {1} + {2} = 0", second, third, fourth);

if (second + third + fifth == 0)
    Console.WriteLine("{0} + {1} + {2} = 0", second, third, fifth);

if (third + fourth + fifth == 0)
    Console.WriteLine("{0} + {1} + {2} = 0", third, fourth, fifth);

if (first + second + third + fourth + fifth != 0)
    Console.WriteLine("no sum gives zero (0)");
