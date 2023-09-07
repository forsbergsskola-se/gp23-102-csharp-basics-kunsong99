// Take an integer input representing seconds and converts it to minutes and remaining seconds,
// then displays the result.

Console.WriteLine("Please input an integer number as seconds");
string userInput = Console.ReadLine();

int seconds = int.Parse(userInput);

int minutes = seconds/60;

int reminder = seconds%60;

Console.WriteLine($"{userInput}seconds is {minutes} minutes and {reminder} seconds");