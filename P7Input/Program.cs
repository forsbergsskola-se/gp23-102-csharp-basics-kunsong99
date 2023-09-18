// See https://aka.ms/new-console-template for more information

Console.WriteLine("What's your name?");
string name = Console.ReadLine() ?? "Anonymous"; //what is "??"
Console.WriteLine($"Hello, {name}!");