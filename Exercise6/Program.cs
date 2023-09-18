// Develop a program that takes two integers as input and calculates their product using the multiplication operator.

Console.WriteLine("Please input two integers as Multiplicand and Multiplier!");
string userInput1 = Console.ReadLine();
string userInput2 = Console.ReadLine();

double Multiplicand = double.Parse(userInput1);
double Multiplier = double.Parse(userInput2); 

double multiplication = Multiplicand * Multiplier;

Console.WriteLine( $"{Multiplicand} * {Multiplier} = {multiplication}");