using System;

class TenRandomValues
{
    static void Main()
    {
        Random rand = new Random();
        for (int i = 1; i <= 10; i++)
        {
            int RandomNumber = rand.Next(100) + 100;
            Console.Write("{0} ", RandomNumber);
        }
        Console.WriteLine(  );
    }
}

