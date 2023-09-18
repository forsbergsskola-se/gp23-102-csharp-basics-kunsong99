//https://github.com/marczaku/102-csharp-basics/tree/main/12-random

using System.Threading.Channels;

Console.WriteLine("Please pass me a seed (integer).");
int seed = int.Parse(Console.ReadLine());

Random rnd = new Random(seed);

Console.WriteLine("Three integers between 0 and 5:");
Console.WriteLine(rnd.Next(0,5));
Console.WriteLine(rnd.Next(0,5));
Console.WriteLine(rnd.Next(0,5));

Console.WriteLine("Three numbers between 0.0 and 0.5:");
Console.WriteLine(rnd.NextDouble()/2);
Console.WriteLine(rnd.NextDouble()/2);
Console.WriteLine(rnd.NextDouble()/2);

Console.WriteLine("Three numbers between 0.2 and 0.7:");
Console.WriteLine(rnd.NextDouble()/2 + 0.2);
Console.WriteLine(rnd.NextDouble()/2 + 0.2);
Console.WriteLine(rnd.NextDouble()/2 + 0.2);


Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)");
double chance = double.Parse(Console.ReadLine());

for (int i = 0; i < 5; i++)
{
    if (rnd.NextDouble() < chance)
    {
        Console.WriteLine("Crit");
    }
    else
    {
        Console.WriteLine("No Crit");
    }
}

