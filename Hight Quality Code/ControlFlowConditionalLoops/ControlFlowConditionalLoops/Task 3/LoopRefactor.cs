namespace ControlFlowConditionalLoops.Task_3
{
    using System;

    public class LoopRefactor
    {
        public void FindValue(int[] source, int expectedValue)
        {
            bool isFound = false;
            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    if (source[i] == expectedValue)
                    {
                        isFound = true;
                    }
                }

                Console.WriteLine(source[i]);
            }

            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
