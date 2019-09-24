using System;

class ExtractSentencesWithGivenWord
{
    static void Main()
    {
        string text = 
            "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";
        string[] sentences = text.Split('.');
        for (int i = 0; i < sentences.Length; i++)
        {
            string[] words = sentences[i].Split(' ');
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j] == word)
                {
                    Console.Write("{0}.", sentences[i]);
                }
            }
        }
        Console.WriteLine();
    }
}

