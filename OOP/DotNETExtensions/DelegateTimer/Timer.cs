namespace DelegateTimer
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public delegate void ExecuteMethod(string item);

    public class Timer
    {
        private Stopwatch timer;
        public ExecuteMethod MethodToExecute { get; set; }
    }
}
