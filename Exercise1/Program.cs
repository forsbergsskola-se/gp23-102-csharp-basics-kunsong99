// See https://aka.ms/new-console-template for more information
//Implement a program that takes an input for km/h and displays the result in m/s.
Console.WriteLine("Please input a number in km/h");
string userInput = Console.ReadLine() ?? string.Empty;
double speedkmph = double.Parse(userInput);
double speedmps = speedkmph * 1000 / 60 / 60;
Console.WriteLine($"{userInput} km/h equals {speedmps} m/s");