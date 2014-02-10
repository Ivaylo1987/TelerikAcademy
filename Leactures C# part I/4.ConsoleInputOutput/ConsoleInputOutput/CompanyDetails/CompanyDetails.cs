using System;

class CompanyDetails
{
    /* A company has name, address, phone number, fax number, web site and manager.
     * The manager has first name, last name, age and a phone number.
     * Write a program that reads the information about a company and its manager and prints them on the console
     */
    static void Main()
    {
        Console.Write("Please, enter company name: ");
        string CompanyName = Console.ReadLine();

        Console.Write("Please, enter company address: ");
        string CompanyAddress = Console.ReadLine();

        Console.Write("Please, enter company Phone number: ");
        string CompanyPhone = Console.ReadLine();

        Console.Write("Please, enter company Fax number: ");
        string CompanyFax = Console.ReadLine();

        Console.Write("Please, enter company Web site: ");
        string CompanySite = Console.ReadLine();

        Console.Write("Please, enter company Manger's first name: ");
        string ManagerFirstName = Console.ReadLine();

        Console.Write("Please, enter company Manger's Second name: ");
        string ManagerSecondName = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Company Name: {0}", CompanyName);
        Console.WriteLine("Company address: {0}", CompanyAddress);
        Console.WriteLine("Company Phone: {0}", CompanyPhone);
        Console.WriteLine("Company Fax: {0}", CompanyFax);
        Console.WriteLine("Company Web site: {0}", CompanySite);
        Console.WriteLine("Company Manger's name: {0} {1}", ManagerFirstName, ManagerSecondName);

    }
}
