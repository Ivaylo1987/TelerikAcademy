using System;

class MaxKSumOfN
{
    /*Write a program that reads two integer numbers N and K and an array of N elements from the console.
     * Find in the array those K elements that have maximal sum.
     */
    static void Main()
    {
        Console.Write("Please, enter N: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Please, enter K: ");
        int K = int.Parse(Console.ReadLine());

        int[] arr = new int[N];
        int currentSum = 0;
        int bestSum = 0;
        int bestIndex = 0;

        //initialize array
        for (int i = 0; i < N; i++)
        {
            Console.Write("Please enter arr[{0}]= ",i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Find every sum of K elements.
        for (int i = 0; i <= arr.Length - K; i++)
        {
            currentSum = 0;

            for (int j = i; j < i + K; j++)  
            {
                currentSum += arr[j];
            }

            if (currentSum > bestSum) //Finding the best sum 
            {
                bestSum = currentSum;
                bestIndex = i; // keep the index for printing purposes.
            }
            
        }

        //Print
        Console.Write("{ ");
        for (int i = bestIndex; i < bestIndex + K; i++)
        {
            if (i != bestIndex)
            {
                Console.Write(", ");
            }
            Console.Write("{0}", arr[i]);
        }
        Console.WriteLine(" }");
        
    }
}
