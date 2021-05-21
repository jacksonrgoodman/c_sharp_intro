using System;

Console.Write("First Name > ");
string firstName = Console.ReadLine();

Console.Write("Last Name > ");
string lastName = Console.ReadLine();

string initials = firstName[0] + " " + lastName[0];
string fullName = firstName + " " + lastName;
Console.WriteLine($"Hello {fullName}");

string reverse = string.Empty;

for (int i = fullName.Length - 1; i >= 0; i--)
{
    reverse += fullName[i];
}

Console.WriteLine($"Your Name Backwards is {reverse}");
/*
for (int num = 10; num > 0; num--)
{
    Console.WriteLine(num);
};

Console.Write("Who would you like to say hello to? ");

string name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Fine, don't say 'hello'!");
}
else
{
    Console.WriteLine($"Hello, {name}!");
}
*/