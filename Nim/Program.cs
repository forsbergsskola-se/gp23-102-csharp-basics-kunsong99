//24 mathes and 2 players take turns to draw matches
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

DRAW_MATCH:
if (drawLeft >1)
{
    //AI's turn
    // Random rnd = new Random();
    if (drawLeft > 4)
    {
        aiDrawNumber = drawLeft % 4 > 1 ? drawLeft % 4 - 1 : 3;
        // if (drawLeft % 4 > 1  )
        // {
        //     aiDrawNumber = drawLeft % 4 - 1; 
        // }
        // else
        // {
        //     aiDrawNumber = 3 ; 
        // }
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
        goto GAME_END;
    }
    
    /*USER_TURN:
    Console.WriteLine("How many matches do you want to draw?");
    userInput = Console.ReadLine();
    if (userInput != "1" && userInput != "2" && userInput != "3")
    {
        Console.WriteLine("Invalid input. Please input a number between 1 and 3.");
        goto USER_TURN;
    }*/
    
    //Use int.TryParse() for input validation
    Console.WriteLine("How many matches do you want to draw?");
    TryAgain:
    if(!int.TryParse(Console.ReadLine(), out int userDrawNumber)){
        Console.Write("Invalid input. Please input a number between 1 and 3.\n");
        goto TryAgain;
    }
    if( userDrawNumber < 1 || userDrawNumber > 3){
        Console.Write("Invalid input. Please input a number between 1 and 3.\n");
        goto TryAgain;
    }
    
    //int userDrawNumber = int.Parse(userInput);
    drawLeft -= userDrawNumber;
    for (i = 0; i < drawLeft; i++)
    {
        Console.Write(match);
    }
    Console.Write($" ({drawLeft})\n");
    if (drawLeft == 1)
    {
        Console.WriteLine("You win!");
        goto GAME_END;
    }
    goto DRAW_MATCH;
}

GAME_END: ;
