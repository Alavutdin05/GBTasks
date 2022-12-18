using static System.Console;
Clear();

WriteLine("Enter a number:");
int number = int.Parse(ReadLine()!);

if (number % 2 == 0)
{
    WriteLine("Yes");
}
else
{
    WriteLine("No");
}

