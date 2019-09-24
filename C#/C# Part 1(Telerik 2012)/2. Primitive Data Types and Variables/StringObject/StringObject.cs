using System;

class StringObject
{
    static void Main()
    {
        string firstword = "Hello";
        string secondword = "World";

        object container1 = firstword + " " + secondword;
        string concatenation = (string)container1;
        Console.WriteLine(concatenation);
            
    }
}

