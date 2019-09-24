using System;

class UsersChoice
{
    static void Main()
    {
        Console.WriteLine("Choose input variables:\n 1. int \n 2. double \n 3. string");
        int variable = int.Parse(Console.ReadLine());
        switch (variable)
        {
            case 1:
                Console.WriteLine("Enter a digit:");
                int digit = int.Parse(Console.ReadLine());
                Console.WriteLine("The new digit is: {0}", digit + 1);
                break;
            case 2:
                Console.WriteLine("Enter a double number:");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("The new double number is: {0}", d + 1);
                break;
            case 3:
                Console.WriteLine("Enter a string:");
                string s = Console.ReadLine();
                Console.WriteLine("The new string is: {0}", s + "*");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
}

