using System;
using System.Globalization;

class DateAndTimeAfterSixHours
{
    static void Main()
    {
        Console.WriteLine("Please enter date in format dd.MM.yyyy HH:mm:ss to see date and time after six 6 hours and 30 minutes : ");
        Console.Write("The date and time are : ");
        string date = Console.ReadLine();
        DateTime dateAndTime = DateTime.ParseExact(date, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        dateAndTime = dateAndTime.AddHours(6.5);
        Console.WriteLine("Date and Time after 6.5 hours bg-BG : {0}" , dateAndTime.ToString( new CultureInfo("bg-BG")));
        Console.WriteLine("Date and time after 6.5 hours : {0}",dateAndTime);
    }
}

