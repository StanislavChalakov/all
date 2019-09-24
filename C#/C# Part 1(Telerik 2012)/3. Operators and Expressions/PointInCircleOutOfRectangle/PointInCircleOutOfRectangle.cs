using System;

class PointInCircleOutOfRectangle
{
    static void Main()
    {
        int x = 1;
        int y = 3;
        if (((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 3 * 3) && ((x < -1) || (x > 5) || (y < -1) || (y > 1)))
        {
            Console.WriteLine("The point with coordinates:x=1 and y=3 is in the circle and out of the rectangle");
        }
    }
}
