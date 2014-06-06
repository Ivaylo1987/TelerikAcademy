namespace MeasureMathFunctionsPerformance
{
    using System;
    using System.Linq;
    using MeasureTypesPerformance;

    public class MathFunctionsPerformanceDemo
    {
        public static void Main()
        {
            // 100000000 takes too long so use 10000000.
            int loopTo = 10000000;

            MeasureFunctions.LogElapsedTime(
                "Square root float",
                () =>
                {
                    for (float i = 1; i < loopTo; i++)
                    {
                        Math.Sqrt(i);
                    }
                });

            MeasureFunctions.LogElapsedTime(
                "Square root double",
                () =>
                {
                    for (double i = 1; i < loopTo; i++)
                    {
                        Math.Sqrt(i);
                    }
                });

            MeasureFunctions.LogElapsedTime(
                "Square root decimal",
                () =>
                {
                    // Casting is always very slow.
                    for (decimal i = 1; i < loopTo; i++)
                    {
                        Math.Sqrt((double)i);
                    }
                });

            MeasureFunctions.LogElapsedTime(
                "Ln float",
                () =>
                {
                    for (float i = 1; i < loopTo; i++)
                    {
                        Math.Log(i);
                    }
                });

            MeasureFunctions.LogElapsedTime(
                "Ln double",
                () =>
                {
                    for (double i = 1; i < loopTo; i++)
                    {
                        Math.Log(i);
                    }
                });

            MeasureFunctions.LogElapsedTime(
                "Ln decimal",
                () =>
                {
                    for (decimal i = 1; i < loopTo; i++)
                    {
                        Math.Log((double)i);
                    }
                });

            MeasureFunctions.LogElapsedTime(
                "Sin float",
                () =>
                {
                    for (float i = 1; i < loopTo; i++)
                    {
                        Math.Sin(i);
                    }
                });

            MeasureFunctions.LogElapsedTime(
                "Sin double",
                () =>
                {
                    for (double i = 1; i < loopTo; i++)
                    {
                        Math.Sin(i);
                    }
                });

            MeasureFunctions.LogElapsedTime(
                "Sin decimal",
                () =>
                {
                    for (decimal i = 1; i < loopTo; i++)
                    {
                        Math.Sin((double)i);
                    }
                });
        }

        // ------ StyleCop completed ------
        // ========== Violation Count: 0 ==========
    }
}
