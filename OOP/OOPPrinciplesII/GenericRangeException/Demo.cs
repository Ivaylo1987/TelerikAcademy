namespace GenericRangeException
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
            // check int exception
            Console.Write("Please, enter a number OUT of the range 1 to 100 to simulate an error: ");

            int number = int.Parse(Console.ReadLine());

            try
            {
                if (number >= 100 || number <= 1)
                {
                    throw new RangeException<int>("Just simulated an INT error!", 1, 100);

                    
                }
            }
            catch (RangeException<int> exp)
            {

                Console.WriteLine(exp.Message);
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 20));

            // check dateTime exception
            Console.WriteLine("We will use today {0} which is out of the range 1.1.1980 to 31.12.2013 to simulate and error.", DateTime.Now);

            DateTime dateToExplode = DateTime.Now;

            try
            {
                if (dateToExplode > new DateTime(2013, 12, 31) || dateToExplode < new DateTime(1980, 1, 1))
                {
                    throw new RangeException<DateTime>("Just simulated an DateTime error!", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
                }
            }
            catch (RangeException<DateTime> exp)
            {

                Console.WriteLine(exp.Message);
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 20));
        }
    }
}
