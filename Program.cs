// See https://aka.ms/new-console-template for more information
string kolade = "Jafar";
decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;

Console.WriteLine($"{kolade}, this is the range of decimal in CSharp {min} and {max}");

decimal a = 1.5M;
decimal b = 3.5M;

Console.WriteLine(a/b);

double d = 1.5;
double c = 3.5;

Console.WriteLine(c/d);

// Area of a circle


double radius = 2.0;
double area = Math.PI * radius * radius;

Console.WriteLine($"The area of a circle with the radius of {radius} equals to {area}");


// Working with strings

// Replace(1,2) just line in python
// Contains(1)
//StartsWith()
// EndsWith()

string name = "    Jafar    ";
string newName = name.Trim().Replace("Jafar", "Anas");
name = name.Trim();
Console.WriteLine(newName);
Console.WriteLine(name.Length);
Console.WriteLine(name.ToUpper());
Console.WriteLine(name.ToLower());

