using System.Globalization;

var outputString = "Hello world";
Console.WriteLine(outputString);

float decimalValue = 0.3f; //(0.3f)
Console.WriteLine(decimalValue); 
Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

bool isAwesome = true;
Console.WriteLine(isAwesome);

byte hexByte = 0xa7;
Console.WriteLine(hexByte);

Console.WriteLine("***solution 2:");
Console.WriteLine($"{outputString}\n{decimalValue}\n{isAwesome}\n{hexByte}");

Console.WriteLine("***solution 3:");
Console.WriteLine(
    @$"{outputString}
{decimalValue}
{isAwesome}
{hexByte}");


// //use of $
// string firstName = "Astrid";
// string lastName = "Lingren";
// Console.WriteLine($"Welcome to {firstName} {lastName}'s world!");
