// Develop a program that calculates the BMI of a person using their weight in kilograms and height in meters.
// Display the BMI value: the body mass divided by the square of the body height,

Console.WriteLine("Please input your weight (kg) and height (m)!");
string userInput1 = Console.ReadLine();
string userInput2 = Console.ReadLine();

double weight = double.Parse(userInput1);
double height = double.Parse(userInput2); 

double resultBMI = weight/height/height;

Console.WriteLine($"Your BMI is {resultBMI}");