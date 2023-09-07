// Develop a program that calculates the area of a circle using a float input for the radius and displays the result. 

Console.WriteLine("Please input a number as the radius for a circle");
string userInput =  Console.ReadLine();
double radius = double.Parse(userInput);

double area = 3.1415926 * radius * radius;

Console.WriteLine($"the area of the circle is {area}");