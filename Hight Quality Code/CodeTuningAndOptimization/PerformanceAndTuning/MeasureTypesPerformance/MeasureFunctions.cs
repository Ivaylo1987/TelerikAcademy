namespace MeasureTypesPerformance
{
    using System;
    using System.Diagnostics;

    public static class MeasureFunctions
    {
        private static Stopwatch stopwatch = new Stopwatch();

        public static void LogElapsedTime(string type, Action methodToMeasure)
        {
            stopwatch.Restart();

            methodToMeasure();

            stopwatch.Stop();

            Console.WriteLine("{0} time: {1}", type, stopwatch.Elapsed);
        }

        // ------ StyleCop completed ------
        // ========== Violation Count: 0 ==========
    }
}
