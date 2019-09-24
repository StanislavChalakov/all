using System;

class SubstringCounter
{
    static void Main()
    {
        string text =
        "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.".ToLower();
        string target = "in".ToLower();
        int counter = 0,index = -1;
        for (int i = 0; i < text.Length; i++)
        {
            index = text.IndexOf(target, index + 1);
            if (index == -1)
            {
                break;
            }
            counter++;
        }
        Console.WriteLine("The substring \"in\" is found {0} times in the text",counter);
    }
}

