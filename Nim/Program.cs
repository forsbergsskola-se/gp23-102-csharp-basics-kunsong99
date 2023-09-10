//the Player who has to take last match loses
Console.WriteLine("Welcome to Nim!");

// TODO: This is hard-coded for now. How to do better?
string draw = "|";
int drawLeft = 24;
int i = 0;

for (i = 0; i < drawLeft; i++)
{
    Console.Write(draw);
}
Console.Write($"({drawLeft})\n");
//Console.WriteLine("|||||||||||||||||||||||| (24)");

object random;
while (drawLeft >1)
{
    USER_TURN:
    Console.WriteLine("How many matches do you want to draw?");
    string userInput = Console.ReadLine();
    //TODO: user input should also less than drawLeft
    if (userInput != "1" && userInput != "2" && userInput != "3")
    {
        Console.WriteLine("Invalid input. Please input a number between 1 and 3.");
        goto USER_TURN;
    }

    int userDrawNumber = int.Parse(userInput);
    drawLeft = drawLeft - userDrawNumber;
    for (i = 0; i < drawLeft; i++)
    {
        Console.Write(draw);
    }
    Console.Write($"({drawLeft})\n");
    if (drawLeft == 1)
    {
        Console.WriteLine("You win!");
        break;
    }

    //TODO: user input should also less than drawLeft
    Random rnd = new Random();
    int aiDrawNumber = rnd.Next(1, 4); 
    drawLeft = drawLeft - aiDrawNumber;
    Console.WriteLine($"AI draws {aiDrawNumber} matches.");
    for (i = 0; i < drawLeft; i++)
    {
        Console.Write(draw);
    }
    Console.Write($"({drawLeft})\n");
    if (drawLeft == 1)
    {
        Console.WriteLine("You lose!");
        break;
    }
}
