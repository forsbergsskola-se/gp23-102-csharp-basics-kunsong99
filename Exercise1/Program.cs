/*
//Implement a program that takes an input for km/h and displays the result in m/s.
Console.WriteLine("Please input a number in km/h");
string userInput = Console.ReadLine() ?? string.Empty;
double speedkmph = double.Parse(userInput);
double speedmps = speedkmph * 1000 / 60 / 60;
Console.WriteLine($"{userInput} km/h equals {speedmps} m/s");
*/

//Implement a program that takes an integer input for minutes
//and displays the result in seconds.
Console.WriteLine("Please input a number for minutes");
string userInput = Console.ReadLine() ?? string.Empty;
int minutes = int.Parse(userInput);

int seconds = minutes * 60;
Console.WriteLine($"{userInput} minutes is {seconds} seconds");