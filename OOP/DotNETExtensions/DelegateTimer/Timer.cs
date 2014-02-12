namespace DelegateTimer
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    // Generic delegate
    public delegate void ExecuteMethod<T>(T item);

    public class Timer
    {
        // Method that different executes methods with different parameters.
        public void ExecuteAt<T>(ExecuteMethod<T> method, T paramOfMethod, int seconds)
        {
            int sleepTime = seconds * 1000;

            while (true)
            {
                method(paramOfMethod);
                Thread.Sleep(sleepTime);
            }
        }
    }
}
