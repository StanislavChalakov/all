using System;
using System.Text;

class StringReversing
{
    public static string ReverseIt(string str)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            sb.Append(str[i]);
        }
        return sb.ToString();
    }
    static void Main()
    {
        Console.Write("Enter a string you want to reverse : ");
        string str = Console.ReadLine();
        string reversed = ReverseIt(str);
        Console.Write("The reversed string looks like this : ");
        Console.WriteLine(reversed);
    }
}

