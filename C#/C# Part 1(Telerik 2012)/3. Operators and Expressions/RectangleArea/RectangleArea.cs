using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter Height of the rectangle:");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Width of the rectangle:");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Rectangle with height->{0}, and width->{1} has area ->{2}", height, width, height * width);
    }
}
