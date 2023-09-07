//Implement a program that takes two integers as input
//and displays their division result as a float.

Console.WriteLine("Please input two integers as Dividend and Divisor!");
string userInput1 = Console.ReadLine();
string userInput2 = Console.ReadLine();

double dividend = double.Parse(userInput1);
double divisor = double.Parse(userInput2); 

double quotient;

if (divisor != 0 )
{
    quotient = dividend / divisor;
    Console.WriteLine($"{userInput1} / {userInput2} = {quotient}");

}
else
{
    Console.WriteLine("0 can't be used as divisor");
}
