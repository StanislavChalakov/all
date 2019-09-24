using System;

class CircleAreaAndPerimeter
{
    static void Main()
    {
        Console.WriteLine("Please enter circle radius:");
        double radius = Convert.ToDouble(Console.ReadLine());
        
        double area = Math.PI * radius * radius;
        Console.WriteLine("The area of circle with radius={0} is {1:F2}",radius,area);
        
        double perimeter = 2 * Math.PI * radius;
        Console.WriteLine("The perimeter of circle with radius={0} is {1:F2}",radius,perimeter);
    }
}

