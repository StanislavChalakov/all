using System;
using System.Globalization;

class TheDaysBtwTwoDates
{
    static void Main()
    {
        Console.WriteLine("Please enter two dates in format dd.MM.yyyy to calculate the days between them.");
        Console.Write("The first date is : ");
        string firstInput = Console.ReadLine();
        Console.Write("The second date is : ");
        string secondInput = Console.ReadLine();
        if ((firstInput.CompareTo(secondInput) < 0))
        {
            DateTime firstDate = DateTime.ParseExact(firstInput, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(secondInput, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.Write("The number of days between the two dates is : ");
            Console.WriteLine((secondDate - firstDate).TotalDays);
        }
        else if ((firstInput.CompareTo(secondInput) > 0))
        {
            DateTime firstDate = DateTime.ParseExact(secondInput, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(firstInput, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.Write("The number of days between the two dates is : ");
            Console.WriteLine((secondDate - firstDate).TotalDays);
        }
    }
}

