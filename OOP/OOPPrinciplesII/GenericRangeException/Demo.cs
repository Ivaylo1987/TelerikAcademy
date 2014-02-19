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
            Console.Write("Please, enter number OUT if the range 1 to 100: ");

            int number = int.Parse(Console.ReadLine());

            try
            {
                if (number > 100 || number < 1)
                {
                    throw new RangeException<int>("Just simulated an error!", 1, 100);
                }
            }
            catch (RangeException<int> exp)
            {

                Console.WriteLine(exp.Message);
            }
            
        }
    }
}
