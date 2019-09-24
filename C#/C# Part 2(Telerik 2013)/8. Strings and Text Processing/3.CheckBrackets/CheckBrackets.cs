using System;

class CheckBrackets
{
    public static bool BracketCounter (string str)
    {
        int bracketNumber = 0;
        for (int i = 0; i < str.Length && bracketNumber >= 0; i++)
        {
            if (str[i] == '(')
            {
                bracketNumber++;
            }
            else if (str[i] == ')')
            {
                bracketNumber--;
            }
        }
        return bracketNumber == 0;
    }
    static void Main()
    {
        Console.Write("Enter equation you want to inspect : ");
        string str = Console.ReadLine();
        Console.WriteLine(BracketCounter(str));
    }
}
