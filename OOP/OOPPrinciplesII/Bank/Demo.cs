namespace Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Demo
    {
        static void Main()
        {
            Account[] accounts = 
            {
                new Loan(1500, new Individual("Ivo", "7802034322"), 5),
                new Mortgage(1500, new Company("My Company", 3210405), 5),
                new Deposit(900, new Individual("Joro", "9008113256"), 5)
            };

            Console.WriteLine("Interest for 3 months for Individial loan: {0}", accounts[0].CalculateInterest(3));
            Console.WriteLine("Interest for 5 months for Individial loan: {0}", accounts[0].CalculateInterest(5));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Interest for 12 months for Company mortgage: {0}", accounts[1].CalculateInterest(12));
            Console.WriteLine("Interest for 18 months for Company mortgage: {0}", accounts[1].CalculateInterest(18));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Interest for 12 months for Individial deposit: {0}", accounts[2].CalculateInterest(18));
        }
    }
}
