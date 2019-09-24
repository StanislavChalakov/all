using System;

class IndexesOfLettersOfGivenWord
{
    static void Main()
    {
        int[] alphabet = new int[26];
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = 'a' + i;
        }
        Console.WriteLine("Enter Word to see letter's indexes in numerical alphabet (1-27) for (a-z)");
        string givenWord = Console.ReadLine();
        for (int j = 0; j < givenWord.Length; j++)
        {
            for (int k = 0; k < alphabet.Length; k++)
            {
                if (givenWord[j] == alphabet[k])
                {
                    Console.WriteLine("The index of the letter {0} is {1}",givenWord[j],k );
                }
            }
        }
    }
}

