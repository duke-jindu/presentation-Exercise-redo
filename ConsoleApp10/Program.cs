// 6. Write a program that reads two numbers from the console and prints the greater of them.
// Solve the problem without using conditional statements.



Console.Write("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int secondNumber = Int32.Parse(Console.ReadLine());

//using the math. keyword
Console.WriteLine("{0} > {1}", Math.Max(firstNumber, secondNumber), Math.Min(firstNumber, secondNumber));
