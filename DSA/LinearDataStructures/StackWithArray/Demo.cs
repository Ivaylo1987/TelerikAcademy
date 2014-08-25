namespace StackWithArray
{
    using System;

    class Demo
    {
        static void Main()
        {
            var myStack = new MyStack<string>();

            myStack.Push("Pesho");
            myStack.Push("Gosho");
            myStack.Push("Mariyka");

            while (myStack.Size != 0)
            {
                Console.WriteLine(myStack.Pop());
            }
        }
    }
}
