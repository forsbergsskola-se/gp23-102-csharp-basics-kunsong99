
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

string result = age < 13 ? "You are a child!" : age <= 19 ? "You are a teenager!" : "You are a grown-up!";
    
Console.WriteLine(result);
    
Console.WriteLine("Give me another integer.");
string userInput2 = Console.ReadLine();
int number2 = int.Parse(userInput2);

int max;
if (age > number2)
{
    max = age;
}
else
{
    max = number2;
}
Console.WriteLine($"The maximum is {max} .");

if (max % 2 == 1)
{
    Console.WriteLine($"{max} is an odd number.");
}
else
{
    Console.WriteLine($"{max} is an even number.");
}




/*
//P11_1Grades
Console.WriteLine("Give me a numerical grade");
int points = int.Parse(Console.ReadLine());

if (points >= 90)
{
    Console.WriteLine("A");
}
else if (points >= 80)
{
    Console.WriteLine("B");
}
else if (points >= 70)
{
    Console.WriteLine("C");
}
else if (points >= 60)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("F");
}
*/


/*
//P11_2MinMax
// input three numbers and then displays the minimum and maximum of those numbers
Console.WriteLine("Please input 3 numbers");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max, min;

if (a >= b && a >= c)
{
    max = a;
}
else if (b >= a && b >= c)
{
    max = b;
}
else
{
    max = c;
}


if (a <= b && a <= c)
{
    min = a;
}
else if (b <= a && b <= c)
{
    min = b;
}
else
{
    min = c;
}

Console.WriteLine($"{min}, {max}");
*/





/*
//P11_3Characters
Console.WriteLine("please input a single character");
string userInput = Console.ReadLine();
char ch = userInput[0];


if (char.IsDigit(ch))
{
    Console.WriteLine("it's a digit");
}
if (char.IsLetter(ch))
{
    ch = char.ToLower(ch);
    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
    {
        Console.WriteLine("it's a vowel");
    }
    else
    {
        Console.WriteLine("it's a consonant");
    }
}
*/






/*
//P11_4Calculator
Console.WriteLine("Please input your operation");
float number1 = float.Parse(Console.ReadLine());
string userOperator = Console.ReadLine();
float number2 = float.Parse(Console.ReadLine());

if (userOperator == "+")
{
    Console.WriteLine($"{number1 + number2}");
}
else if (userOperator == "-")
{
    Console.WriteLine($"{number1 + number2}");
}
else if (userOperator == "*")
{
    Console.WriteLine($"{number1 * number2}");
}
else if (userOperator == "/")
{
    Console.WriteLine($"{number1 / number2}");
}
else
{
    Console.WriteLine("Invalid operator!");
}
*/





/*
//P11_5EvenOrOdd
//Check if a given integer is even or odd and displays an appropriate message.
int number = int.Parse(Console.ReadLine());

if (number % 2 == 1)
{
    Console.WriteLine("That's odd");
}
else
{
    Console.WriteLine("That's even");
}*/