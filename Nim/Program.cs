﻿//24 mathes and 2 players take turns to draw matches
//each player may draw 1,2 or 3 matches (not more or less)
//the Player who has to take last match loses

Console.WriteLine("Welcome to Nim!");
string match = "|";
int drawLeft = 24;
int i;
int aiDrawNumber;
string userInput;

for (i = 0; i < drawLeft; i++)
{
    Console.Write(match);
}
Console.Write($"( {drawLeft})\n");


Console.WriteLine("AI goes first.");
while (drawLeft >1)
{
    //AI's turn
    // Random rnd = new Random();
    if (drawLeft > 4)
    {
        if (drawLeft % 4 > 1  )
        {
            aiDrawNumber = drawLeft % 4 - 1; 
        }
        // else if (drawLeft % 4 == 1)
        // {
        //     aiDrawNumber =  rnd.Next(1, 3) ; 
        // }
        else
        {
            aiDrawNumber = 3 ; 
        }
    }
    else
    {
        aiDrawNumber = drawLeft - 1;
    }
    
    drawLeft -= aiDrawNumber;
    Console.WriteLine($"The AI draws {aiDrawNumber} matches.");
    for (i = 0; i < drawLeft; i++)
    {
        Console.Write(match);
    }
    Console.Write($" ({drawLeft})\n");
    if (drawLeft == 1)
    {
        Console.WriteLine("You lose!");
        break;
    }
    
    USER_TURN:
    Console.WriteLine("How many matches do you want to draw?");
    userInput = Console.ReadLine();
    if (userInput != "1" && userInput != "2" && userInput != "3")
    {
        Console.WriteLine("Invalid input. Please input a number between 1 and 3.");
        goto USER_TURN;
    }

    int userDrawNumber = int.Parse(userInput);
    drawLeft -= userDrawNumber;
    for (i = 0; i < drawLeft; i++)
    {
        Console.Write(match);
    }
    Console.Write($" ({drawLeft})\n");
    if (drawLeft == 1)
    {
        Console.WriteLine("You win!");
        break;
    }
}
