Console.WriteLine("What is your age?");
string userInput = Console.ReadLine();

double age = double.Parse(userInput);

bool isChild = age >= 0 && age <13;
bool isTeenager = age >=13 && age <=19;
bool isGrownup = age > 19;

Console.WriteLine(@$"You are a child:{isChild}
You are a teenager:{isTeenager}
You are a grown-up:{isGrownup} ");
