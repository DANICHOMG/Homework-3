// See https://aka.ms/new-console-template for more information

Console.Write("Hello. Write first number: ");
int one = int.Parse(Console.ReadLine());
Console.Write("Hello. Write second number: ");
int two = int.Parse(Console.ReadLine());

if(one > two)
{
    Console.Write($"{one} is bigger then {two}");
}

if (one < two)
{
    Console.Write($"; {one} is smaller then {two}");
}

if (two > one)
{
    Console.Write($"{two} is bigger then {one}");
}

if (two < one)
{
    Console.Write($"; {two} is smaller then {one}");
}

if (two == one)
{
    Console.Write($"Bro, there are similar numbers! Wow?");
}

// Друга частина, закоментуйте першу або другу частину

bool toto = true;

while (toto)
{
    Console.Write($"Type first number:");
    int d = int.Parse(Console.ReadLine());
    Console.Write($"Type second number:");
    int f = int.Parse(Console.ReadLine());

    int p = d + f;

    if (p % 2 == 0 )
    {
        Console.Write("ODD!");
        return;
    }
    else
    {
        Console.Write("Nice! ");
    }
}