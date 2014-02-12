namespace DelegateTimer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TestTimer
    {
        static void Main()
        {
            Timer executeAt1 = new Timer();
            int period = 1;   // change period to whatever whanted!
            executeAt1.ExecuteAtCertainInterval(Console.WriteLine, string.Format("I exacute every {0} seconds :)!", period), period);
        }
    }
}
