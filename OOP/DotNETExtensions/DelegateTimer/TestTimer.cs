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
            Timer timer = new Timer();
            int seconds = 2;   // change period to whatever whanted!

            timer.ExecuteAt(Console.WriteLine, string.Format("I exacute every {0} seconds :)!", seconds), seconds);
        }
    }
}
