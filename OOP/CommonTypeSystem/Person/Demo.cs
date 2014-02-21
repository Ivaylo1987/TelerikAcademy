namespace Person
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
            PersonTC gosho = new PersonTC("Gosho");

            PersonTC pesho = new PersonTC("Gosho", 21);

            Console.WriteLine(gosho);
            Console.WriteLine(pesho);
        }
    }
}
