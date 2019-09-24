using System;

class CompanyManagerInfo
{
    static void Main()
    {
        Console.WriteLine("Please enter name for the company:");
        string companyName = Console.ReadLine();

        Console.WriteLine("Please enter address for the company:");
        string companyAddress = Console.ReadLine();

        Console.WriteLine("Please enter phone number for the company:");
        string companyPhone = Console.ReadLine();

        Console.WriteLine("Please enter fax number for the company:");
        string companyFax = Console.ReadLine();

        Console.WriteLine("Please enter web site for the company:");
        string companySite = Console.ReadLine();

        Console.WriteLine("Please enter first name for the company's manager:");
        string managerFirstName = Console.ReadLine();

        Console.WriteLine("Please enter last name for the company's manager:");
        string managerLastName = Console.ReadLine();

        Console.WriteLine("Please enter age for the company's manager:");
        string managerAge = Console.ReadLine();

        Console.WriteLine("Please enter phone number for the company's manager:");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("You chose to name your company: {0}",companyName);
        Console.WriteLine("with address:{0}",companyAddress);
        Console.WriteLine("Company's phone number:{0}",companyPhone);
        Console.WriteLine("Company's fax number:{0}",companyFax);
        Console.WriteLine("Company's wes site:{0}",companySite);
        Console.WriteLine("{0}'s manager is called: {1} {2}",companyName,managerFirstName,managerLastName);
        Console.WriteLine("He is {0} years old",managerAge);
        Console.WriteLine("To contact him call this number:{0}",managerPhone);
    }
}

