// Input an amount of seconds
// show it in days, hours, minutes and seconds 

Console.WriteLine("Give me a number of seconds");

string userInput = Console.ReadLine();

int seconds = int.Parse(userInput);

int secondsInADay = 24 * 60 * 60;
int secondsInAHour = 60 * 60;

int days = seconds / secondsInADay;
int hours = (seconds - days * secondsInADay) / secondsInAHour;
int minutes = (seconds - days * secondsInADay - hours*secondsInAHour ) / 60;
int reminderSeconds = seconds % 60;
double totalDays = (double)seconds / secondsInADay;

Console.WriteLine($"{userInput} seconds is {days} days, {hours} hours, {minutes} minutes and {reminderSeconds} seconds");
Console.WriteLine($"Seconds: {reminderSeconds}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Days: {days}");
Console.WriteLine($"{days}.{hours}:{minutes}:{reminderSeconds}");
Console.WriteLine($"In total, that's {totalDays} days");
