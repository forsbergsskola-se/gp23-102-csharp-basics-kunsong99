// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me a number.");
var inputString = Console.ReadLine();
Console.WriteLine(inputString);
double toDouble = Convert.ToDouble(inputString);
Console.WriteLine(toDouble);
int toInt = Convert.ToByte(toDouble);
Console.WriteLine(toInt);
toInt = Convert.ToInt16(inputString);  //Unhandled exception. System.FormatException: The input string '9.9' was not in a correct format.
Console.WriteLine(toInt);  // this line will not be executed