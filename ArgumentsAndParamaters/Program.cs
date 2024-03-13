
using System.Threading.Channels;

Console.WriteLine("Enter a word:");
string UserInput = Console.ReadLine();

PrintAnyWord(UserInput);

static void PrintAnyWord(string anyString)
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}
