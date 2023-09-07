// Write a Program that toggles a 0/1 Input.
// Do not use conditional code, only mathematical operations.
// (Input: 0: Output 1 and Input 1: Output 0

Console.WriteLine("Please input 0 or 1!");
string userInput = Console.ReadLine();

int inputNumer  = int.Parse(userInput);

int outputNumber = 1-inputNumer;

Console.WriteLine($"{userInput} --> {outputNumber}");