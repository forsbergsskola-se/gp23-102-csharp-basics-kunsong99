// Input an amount of seconds
// show it in days, hours, minutes and seconds 

Console.WriteLine("Please input an amount of seconds");
string userInput = Console.ReadLine();

int seconds = int.Parse(userInput);

int secondsInADay = 24 * 60 * 60;
int secondsInAHour = 60 * 60;

int days = seconds/secondsInADay;

int hours = (seconds - days*secondsInADay)/secondsInAHour;

int minutes = (seconds - days*secondsInADay - hours*secondsInAHour )/60;

int reminderSeconds = seconds%60;

Console.WriteLine($"{userInput} seconds is {days} days, {hours} hours, {minutes} minutes and {reminderSeconds} seconds");
