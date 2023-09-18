//Develop a program that calculates the length of the hypotenuse of a right triangle using the lengths of the other two sides as inputs.
//Display the result.* (requires Google)
using System;

Console.WriteLine("Please enter the length of the two sides of the right triangle!");

float a = float.Parse(Console.ReadLine());
float b = float.Parse(Console.ReadLine());

float c = MathF.Sqrt((float)(a*a+b*b));

Console.WriteLine($"The length of the hypotenuse is {c}");


