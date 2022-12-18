using static System.Console;
Clear();
WriteLine("Enter a number:");
int number = int.Parse(ReadLine()!);
int count = 2;

while (count<=number)
{
    if (count % 2 == 0)
    {
        WriteLine(count);
    }
    count++;
}
