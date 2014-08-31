namespace HashTable
{
    using System;

    class Demo
    {
        static void Main()
        {
            var hashTable = new IHashTable<string, int>();
            
            // adding
            hashTable.Add("first", 1);
            hashTable.Add("second", 2);
            hashTable.Add("third", 3);

            Console.WriteLine(hashTable["first"]);
            Console.WriteLine(hashTable["second"]);
            Console.WriteLine(hashTable["third"]);

            // changing
            hashTable["first"] = 11;
            hashTable["second"] = 12;
            hashTable["third"] = 13;

            Console.WriteLine(hashTable["first"]);
            Console.WriteLine(hashTable["second"]);
            Console.WriteLine(hashTable["third"]);

            // adding by indxer
            hashTable["fourth"] = 4;

            Console.WriteLine(hashTable["fourth"]);
        }
    }
}
