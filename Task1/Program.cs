using System;

namespace Task1
{
    class Program
    {
        static void FindIndexes(int k, int[] arr)
        {
            int firstIndex, secondIndex, firstValue, secondValue;    
            for (int i = 0; i < arr.Length; i++)
            {
                firstValue = arr[i];
                firstIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    secondValue = arr[j];
                    secondIndex = j;
                    if (firstValue + secondValue == k)
                    {
                        Console.WriteLine(firstIndex + " " + secondIndex);
                        return;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int k; 
            Int32.TryParse(Console.ReadLine(), out k);
            int[] arr = new int[] { 1, 4, 7, 10, 5, 25, 32, 18, 2 };
            FindIndexes(k, arr);
        }
    }
}
