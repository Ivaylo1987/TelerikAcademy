namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GSMTest
    {
        static void Main()
        {
            //I use one and the same class for testing phone and Calls.

            // Add some GSMs to List
            List<GSM> gsmList = new List<GSM>();

            gsmList.Add(new GSM("6310", "Nokia", 49.99m));
            gsmList.Add(new GSM("Galaxy S2", "Samsung", 730.00m, new Battery("CHR12pw", BatteryType.LiIon), new Display()));
            gsmList.Add(new GSM("Sensation", "HTC", 380m, new Battery("CHR11pw", BatteryType.LiPolymer), new Display(5, 24), "Ivcho"));

            for (int i = 0; i < gsmList.Count; i++)
            {
                gsmList[i].PrintAllInfo();
                Console.WriteLine(new string('-', 20));
            }

            // Print static memeber
            Console.WriteLine(GSM.IPhone4S);
            Console.WriteLine(new string('-', 20));


            // Add some calls
            gsmList[1].AddCallToHistory(new Call(new DateTime(2014, 1, 7), new TimeSpan(0, 7, 32), "0883434341"));
            gsmList[1].AddCallToHistory(new Call(new DateTime(2014, 1, 8), new TimeSpan(0, 3, 2), "0883434341"));
            gsmList[1].AddCallToHistory(new Call(new DateTime(2014, 1, 9), new TimeSpan(0, 14, 54), "0883434341"));
            gsmList[1].AddCallToHistory(new Call(new DateTime(2014, 1, 10), new TimeSpan(0, 11, 41), "0883434341"));

            foreach (var item in gsmList[1].CallHistory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 20));
            
            // Print total price of calls 
            decimal totalPrice = gsmList[1].CalculateTotalCallPrice(0.37m);
            Console.WriteLine("Total price: {0:0.0000}", totalPrice);
            Console.WriteLine(new string('-', 20));

            // Delete longest call
            int longestCallIndex = 0;

            TimeSpan longestCall = TimeSpan.Zero;
            for (int i = 0; i < gsmList[1].CallHistory.Count; i++)
            {
                if (gsmList[1].CallHistory[i].DurationOfCall.CompareTo(longestCall) > 0)
                {
                    longestCall = gsmList[1].CallHistory[i].DurationOfCall;
                    longestCallIndex = i;
                }
            }

            gsmList[1].DeleteCallFromHistory(longestCallIndex);

            foreach (var item in gsmList[1].CallHistory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 20));


            // Print total price of calls again 
            totalPrice = gsmList[1].CalculateTotalCallPrice(0.37m);
            Console.WriteLine("Total price: {0:0.0000}", totalPrice);
            Console.WriteLine(new string('-', 20));

            // Clear history
            gsmList[1].ClearCallHistory();
            Console.WriteLine("Call history cleared!");

            foreach (var item in gsmList[1].CallHistory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 20));
        }
    }
}
