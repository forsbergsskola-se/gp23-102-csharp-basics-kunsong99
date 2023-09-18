// https://github.com/marczaku/102-csharp-basics/tree/main/G-game-on

Char[,] allPieces = new char[3,3];
string line = "------------";

char userChar = '\0'; // X: user1; O: user2

int indexRow;  //0-2
int indexColumn;  //0-2

int stepNumber = 0; //maximum 9
bool winFlag = false;

Console.WriteLine("Welcome to  Tic, Tac, Toe!");

//Print Board
Console.WriteLine($" {allPieces[0,0]} | {allPieces[0,1]} | {allPieces[0,2]}");
Console.WriteLine(line);
Console.WriteLine($" {allPieces[1,0]} | {allPieces[1,1]} | {allPieces[1,2]}");
Console.WriteLine(line);
Console.WriteLine($" {allPieces[2,0]} | {allPieces[2,1]} | {allPieces[2,2]}");


TAKE_TURN:
if (stepNumber >= 9)
{
    goto GAME_OVER;
}

userChar = stepNumber % 2 == 0 ? 'X' : 'O';

USER_SELECT:
Console.WriteLine($"In what row do you want to place your {userChar} (1-3)?");
int rowSelect = int.Parse(Console.ReadLine());
Console.WriteLine($"In what column do you want to place your {userChar} (1-3)?");
int columnSelect = int.Parse(Console.ReadLine());

if (allPieces[rowSelect-1,columnSelect-1] != '\0')
{
    Console.WriteLine("The place is taken. Please select another place.");
    goto USER_SELECT;
}

allPieces[rowSelect - 1, columnSelect - 1] = userChar;
stepNumber++;

Console.WriteLine($" {allPieces[0,0]} | {allPieces[0,1]} | {allPieces[0,2]}");
Console.WriteLine(line);
Console.WriteLine($" {allPieces[1,0]} | {allPieces[1,1]} | {allPieces[1,2]}");
Console.WriteLine(line);
Console.WriteLine($" {allPieces[2,0]} | {allPieces[2,1]} | {allPieces[2,2]}");

//Check Win
if (stepNumber < 3)
{
    goto TAKE_TURN;
}
for (indexRow = 0; indexRow < 3; indexRow++)
{
    if (allPieces[indexRow, 0] != '\0' && allPieces[indexRow, 0] == allPieces[indexRow, 1] && allPieces[indexRow, 0] == allPieces[indexRow, 2])
    {
        winFlag = true;
        goto GAME_OVER;
    }
}
for (indexColumn = 0; indexColumn < 3; indexColumn++)
{
    if (allPieces[0, indexColumn] != '\0' && allPieces[0, indexColumn] == allPieces[1, indexColumn] && allPieces[0, indexColumn] == allPieces[2, indexColumn])
    {
        winFlag = true;
        goto GAME_OVER;
    }
}
if (allPieces[0,0] != '\0' && allPieces[0,0] == allPieces[1,1] && allPieces[0,0] == allPieces[2,2])
{
    winFlag = true;
    goto GAME_OVER;
}
if (allPieces[0,2] != '\0' && allPieces[0,2] == allPieces[1,1] && allPieces[0,2] == allPieces[2,0])
{
    winFlag = true;
    goto GAME_OVER;
}
goto TAKE_TURN;


GAME_OVER:
if (winFlag)
{
    if (userChar == 'X')
    {
        Console.WriteLine("Congratulations, User1 win!");
    }
    else
    {
        Console.WriteLine("Congratulations, User2 win!");
    }
}
else
{
    Console.WriteLine("Oops! Try again!");
}

