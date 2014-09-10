namespace BinaryPasswords
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numberOfStarts = input.Count(ch => ch == '*');

            long numberOfPasswords = (long)Math.Pow(2, numberOfStarts);

            Console.WriteLine(numberOfPasswords);
        }
    }
}
