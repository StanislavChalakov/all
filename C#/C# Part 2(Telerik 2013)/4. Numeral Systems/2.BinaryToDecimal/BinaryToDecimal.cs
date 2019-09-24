using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a decimal number : ");
        string input = Console.ReadLine();
        int decNum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            decNum = decNum << 1;
            if (input[i] == '1')
            {
                decNum = decNum ^ 1;
            }
        }
        Console.Write("Its decimal representation is : ");
        Console.WriteLine(decNum);
    }
}

