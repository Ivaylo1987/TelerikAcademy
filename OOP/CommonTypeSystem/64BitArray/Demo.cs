namespace _64BitArray
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
            UlongBitArray firstArr = new UlongBitArray(111);
            UlongBitArray secondArr = new UlongBitArray(1);

            Console.WriteLine(firstArr[0]);
            Console.WriteLine(firstArr[3]);

            // change bit 0 form 1 to 0
            firstArr[0] = 0;
            Console.WriteLine(firstArr[0]);

            Console.WriteLine(firstArr.Equals(secondArr));

            //Console.WriteLine(firstArr.Equals(111));   //this will generate an error because 111 in this case is not an UlongBitArray object
        }
    }
}
