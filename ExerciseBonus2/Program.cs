// Write a Program that returns the maximum of two numbers.
// You may use Mathf.Abs, but no conditional code.

Console.WriteLine("Please input two numbers!");
string userInput1 = Console.ReadLine();
string userInput2 = Console.ReadLine();

double number1 = double.Parse(userInput1);
double number2 = double.Parse(userInput2); 

double maxNumber = (number1 + number2)/2 + Math.Abs(number1 - number2)/2;
Console.WriteLine($"the max of the two numbers is {maxNumber}");