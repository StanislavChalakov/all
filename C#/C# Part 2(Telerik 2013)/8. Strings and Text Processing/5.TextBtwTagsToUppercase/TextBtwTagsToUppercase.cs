using System;
using System.Text;

class TextBtwTagsToUppercase
{
    public static string TaggedTextToUppercase(string text)
    {
        string startTag = "<upcase>";
        string endTag = "</upcase>";
        StringBuilder tempText = new StringBuilder(text);
        while (tempText.ToString().IndexOf(startTag) >= 0)
        {
            int start = tempText.ToString().IndexOf(startTag);
            int end = tempText.ToString().IndexOf(endTag);
            for (int j = start; j < end; j++)
            {
                tempText[j] = char.ToUpper(tempText[j]);
            }
            tempText.Remove(start, startTag.Length);
            tempText.Remove(end - endTag.Length + 1, endTag.Length);
        }
        return tempText.ToString();
    }
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(TaggedTextToUppercase(text));
    }
}

