using System;

class LeapYear
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        if (now.Year % 4 == 0)
        {
            Console.WriteLine("The year is leap");
        }
        else
        {
            Console.WriteLine("The year is not leap");
        }
    }
}

