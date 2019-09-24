using System;

class SimpleDictionary
{
    static void Main()
    {
        string[] dictionary = { ".NET - platform for applications from Microsoft",
                                "CLR - managed execution environment for .NET",
                                "namespace - hierarchical - organization of classes" };
        Console.WriteLine("Enter \".NET\" or \"CLR\" or \"namespace\" to see its translation : ");
        string input = Console.ReadLine();
        foreach (string word in dictionary)
        {
            if (word.IndexOf(input) == 0)
            {
                Console.WriteLine(word);
            }
        }
    }
}

