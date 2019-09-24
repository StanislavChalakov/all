using System;

class GivenPointInCircle
{
    static void Main()
    {
        int x = 3;
        int y = 2;
        if (x * x + y * y <= 5 * 5)
        {
            Console.WriteLine("Point with coordinates x,y({0},{1}) is within the circle K(0,{2})", x, y, 5);
        }
    }
}

