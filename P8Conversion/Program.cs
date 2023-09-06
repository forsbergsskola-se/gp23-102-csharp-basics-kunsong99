// use .Parse() in case one type is string 

Console.WriteLine("Give me a number.");
string inputNumber = Console.ReadLine();
Console.WriteLine(inputNumber);

double dNumber = double.Parse(inputNumber); //Convert.ToDouble(inputNumber);
Console.WriteLine(dNumber);

int iNumber = (int)(dNumber);
Console.WriteLine(iNumber);

iNumber = int.Parse(inputNumber);  
Console.WriteLine(iNumber);  // this line will not be executed





// int i = 5;
// double d = i; // assigning - implicit convert


// double d = 5.6;
// int i = (int)d; //cast - explicit convert


// string s = “9.8”;
// double d = double.Parse(s); // Parse


// string s = "hello";
// double d = Convert.ToDouble(s); // Convert