namespace BiDictionary
{
    using System;
    using System.Collections.Generic;

    public class Demo
    {
        public static void Main()
        {
            var doubleKeyDict = new BiDictionary<int, string, string>();

            // Add Some Elements
            doubleKeyDict.Add(5, "Pesho");
            doubleKeyDict.Add(5, "Gosho");
            doubleKeyDict.Add(5, "Ivan");

            // Get Elements for Key1.
            var valuesFound = doubleKeyDict[5];
            Console.WriteLine(string.Join(", ", valuesFound));

            // Associate Key2 with Key1.
            doubleKeyDict.Associate(5, "Pet");

            // Get same items but with Key2.
            valuesFound = doubleKeyDict["Pet"];
            Console.WriteLine(string.Join(", ", valuesFound));

            // Clear the dictionary.
            doubleKeyDict.Clear();

            // Add item with both keys.
            doubleKeyDict.Add(5, "pet", "Petur");

            // Get items with both keys.
            Console.WriteLine("Geting the values with 5 (KEY1): {0}", string.Join(",", doubleKeyDict[5]));
            Console.WriteLine("Geting the values with \"pet\" (KEY2): {0}", string.Join(",", doubleKeyDict["pet"]));
        }
    }
}
