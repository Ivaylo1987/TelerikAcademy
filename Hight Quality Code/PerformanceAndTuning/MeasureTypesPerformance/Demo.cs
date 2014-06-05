namespace MeasureTypesPerformance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Demo
    {
        // keep in mind that some of the tests take up to 16 seconds to complete with loopTo = 100000000 :)
        static void Main()
        {
            int loopTo = 100000000;
            MeasureFunctions.LogElapsedTime("Add int", () =>
            {
                int count = 0;

                for (int i = 1; i < loopTo; i++)
                    count += i;
            });

            MeasureFunctions.LogElapsedTime("Add long", () =>
            {
                long count = 0;

                for (int i = 1; i < loopTo; i++)
                    count += i;
            });

            MeasureFunctions.LogElapsedTime("Add float", () =>
            {
                float count = 0;

                for (int i = 1; i < loopTo; i++)
                    count += i;
            });

            MeasureFunctions.LogElapsedTime("Add double", () =>
            {
                double count = 0;

                for (int i = 1; i < loopTo; i++)
                    count += i;
            });

            MeasureFunctions.LogElapsedTime("Add decimal", () =>
            {
                decimal count = 0;

                for (int i = 1; i < loopTo; i++)
                    count += i;
            });


            Console.WriteLine();

            {
                MeasureFunctions.LogElapsedTime("Subract int", () =>
                {
                    int count = 0;

                    for (int i = 1; i < loopTo; i++)
                        count--;
                });

                MeasureFunctions.LogElapsedTime("Subract long", () =>
                {
                    long count = 0;

                    for (int i = 1; i < loopTo; i++)
                        count--;
                });

                MeasureFunctions.LogElapsedTime("Subract float", () =>
                {
                    float count = 0;

                    for (int i = 1; i < loopTo; i++)
                        count--;
                });

                MeasureFunctions.LogElapsedTime("Subract double", () =>
                {
                    double count = 0;

                    for (int i = 1; i < loopTo; i++)
                        count--;
                });

                MeasureFunctions.LogElapsedTime("Subract decimal", () =>
                {
                    decimal count = 0;

                    for (int i = 1; i < loopTo; i++)
                        count--;
                });
            }

            Console.WriteLine();

            {
                MeasureFunctions.LogElapsedTime("Increment int", () =>
                {
                    int count = 0;

                    for (int i = 1; i < loopTo; i++)
                        count++;
                });

                MeasureFunctions.LogElapsedTime("Increment long", () =>
                {
                    long count = 0;

                    for (int i = 1; i < loopTo; i++)
                        count++;
                });

                MeasureFunctions.LogElapsedTime("Increment float", () =>
                {
                    float count = 0;

                    for (int i = 1; i < loopTo; i++)
                        count++;
                });

                MeasureFunctions.LogElapsedTime("Increment double", () =>
                {
                    double count = 0;

                    for (int i = 1; i < loopTo; i++)
                        count++;
                });

                MeasureFunctions.LogElapsedTime("Increment decimal", () =>
                {
                    decimal count = 0;

                    for (int i = 1; i < loopTo; i++)
                        count++;
                });
            }

            Console.WriteLine();

            {
                MeasureFunctions.LogElapsedTime("Multiply int", () =>
                {
                    int count = 1;

                    for (int i = 1; i < loopTo; i++)
                        count *= i;
                });

                MeasureFunctions.LogElapsedTime("Multiply long", () =>
                {
                    long count = 1;

                    for (int i = 1; i < loopTo; i++)
                        count *= i;
                });

                MeasureFunctions.LogElapsedTime("Multiply float", () =>
                {
                    float count = 1;

                    for (int i = 1; i < loopTo; i++)
                        count *= i;
                });

                MeasureFunctions.LogElapsedTime("Multiply double", () =>
                {
                    double count = 1;

                    for (int i = 1; i < loopTo; i++)
                        count *= i;
                });

                MeasureFunctions.LogElapsedTime("Multiply decimal", () =>
                {
                    decimal count = 1;

                    for (int i = 1; i < loopTo; i++)
                        count *= 1.000000000001m;
                });
            }

            Console.WriteLine();

            {
                MeasureFunctions.LogElapsedTime("Divide int", () =>
                {
                    int count = int.MaxValue;

                    for (int i = 1; i < loopTo; i++)
                        count /= i;
                });

                MeasureFunctions.LogElapsedTime("Divide long", () =>
                {
                    long count = long.MaxValue;

                    for (int i = 1; i < loopTo; i++)
                        count /= i;
                });

                MeasureFunctions.LogElapsedTime("Divide float", () =>
                {
                    float count = float.MaxValue;

                    for (int i = 1; i < loopTo; i++)
                        count /= i;
                });

                MeasureFunctions.LogElapsedTime("Divide double", () =>
                {
                    double count = double.MaxValue;

                    for (int i = 1; i < loopTo; i++)
                        count /= i;
                });

                MeasureFunctions.LogElapsedTime("Divide decimal", () =>
                {
                    decimal count = decimal.MaxValue;

                    for (int i = 1; i < loopTo; i++)
                        count /= i;
                });
            }
        }
    }
}
