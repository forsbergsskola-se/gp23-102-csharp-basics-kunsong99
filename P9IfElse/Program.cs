// See https://aka.ms/new-console-template for more information

Console.WriteLine("What's your age?");
string userInput = Console.ReadLine();

int age = int.Parse(userInput);

/*
if (age < 13)
{
    Console.WriteLine("You are a child!");
}
else if (age <= 19)
{
    Console.WriteLine("You are a teenager!");
    
}
else
{
    Console.WriteLine("You are a grown-up!");
}
*/

string result = age < 13 ? "You are a child!" : age < 19 ? "You are a teenager!" : "You are a grown-up!";
    
Console.WriteLine(result);
    
Console.WriteLine("Give me another integer.");
string userInput2 = Console.ReadLine();

int number2 = int.Parse(userInput2);

if (age > number2)
{
    Console.WriteLine($"The maximum is {age} .");
    if (age % 2 == 1)
    {
        Console.WriteLine($"{age} is an odd number.");
    }
    else
    {
        Console.WriteLine($"{age} is an even number.");
    }
}
else
{
    Console.WriteLine($"The maximum is {userInput2}");
    if (number2 % 2 == 1)
    {
        Console.WriteLine($"{number2} is an odd number.");
    }
    else
    {
        Console.WriteLine($"{number2} is an even number.");
    }
}

