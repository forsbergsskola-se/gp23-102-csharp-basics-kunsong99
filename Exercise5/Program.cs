/*Write a program that takes an integer input
and displays its negation using the unary minus operator.*/

Console.WriteLine("Please input a number");
string userInput = Console.ReadLine();

double number = double.Parse(userInput);

double negation = 0-number;

Console.WriteLine($"the negation of {userInput} is {negation}");