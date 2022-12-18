using static System.Console;
Clear();
WriteLine("Enter the first number");
int numberA = int.Parse(ReadLine()!);
WriteLine("Enter the second number");
int numberB = int.Parse(ReadLine()!);
int max = numberA;

if (max>numberB)
{
    WriteLine(max);
}
else
{
    max = numberB;
    WriteLine (max);
}
