namespace LinkedList
{
    using System;
    using System.Collections.Generic;

    class Demo
    {
        static void Main()
        {
            var list = new MyLinkedList<int>(new ListItem<int>(1));
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            var current = list.FirstelEment;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.NextItem;
            }
        }
    }
}
