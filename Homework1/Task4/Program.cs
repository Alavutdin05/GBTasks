﻿using static System.Console;
Clear();
WriteLine("Enter the first number");
int numberA = int.Parse(ReadLine()!);
WriteLine("Enter the second number");
int numberB = int.Parse(ReadLine()!);
WriteLine("Enter the thirt number");
int numberC = int.Parse(ReadLine()!);
int max = numberA;

if (max>numberB)
{
    if (max>numberC)
    WriteLine(max);
}
else if (numberB>numberC)
{
    max = numberB;
    WriteLine(max);
}
else
{
    max = numberC;
    WriteLine (max);
}
