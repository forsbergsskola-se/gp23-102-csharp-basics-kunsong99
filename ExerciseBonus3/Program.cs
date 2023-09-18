//Write a Program that swaps the values of two variables. Do not use a third variable.

Console.WriteLine("Please input two numbers!");
string userInput1 = Console.ReadLine();
string userInput2 = Console.ReadLine();

double numberA = double.Parse(userInput1);
double numberB = double.Parse(userInput2);

numberA = (numberA + numberB) / 2;
numberB = numberB - numberA;

numberA += numberB;
numberB = numberA -numberB * 2;

Console.WriteLine(@$"You input:{userInput1} and {userInput2}
After swap: {numberA} and {numberB}");



