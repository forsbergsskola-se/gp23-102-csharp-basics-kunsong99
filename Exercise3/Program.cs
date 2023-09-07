//Write a program that calculates the remainder of dividing two integers and displays the result.
Console.WriteLine("Please input two integers as Dividend and Divisor!");
string userInput1 = Console.ReadLine();
string userInput2 = Console.ReadLine();

int dividend = int.Parse(userInput1);
int divisor = int.Parse(userInput2); 

int reminder = dividend % divisor;
Console.WriteLine($"the reminder of {userInput1} / {userInput2} is {reminder}");
