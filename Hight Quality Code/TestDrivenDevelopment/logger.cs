namespace Poker
{
    using log4net;
    using log4net.Config;

    public static class Logger
    {
        public static readonly ILog Log;    
   
        static Logger()
        {
            Log = LogManager.GetLogger("Poker Logger");
            BasicConfigurator.Configure();
        }
    }
}
