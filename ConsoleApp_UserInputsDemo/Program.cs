// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string name = string.Empty;
int age = 0;
int retirementAge = 60;

Console.WriteLine("Please enter your name: ");
name = Console.ReadLine();

Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int workingYearsRemaining = retirementAge - age;

Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining: {workingYearsRemaining}");