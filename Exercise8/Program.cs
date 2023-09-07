//Develop a program that calculates the length of the hypotenuse of a right triangle using the lengths of the other two sides as inputs.
//Display the result.* (requires Google)
using System;

Console.WriteLine("Please enter the length of the two sides of the right triangle!");
string userInput1 = Console.ReadLine();
string userInput2 = Console.ReadLine();

double side1 = double.Parse(userInput1);
double side2 = double.Parse(userInput2);

double side3 = MathF.Sqrt((float)(side1*side1+side2*side2));

Console.WriteLine($"The length of the hypotenuse is {side3}");


