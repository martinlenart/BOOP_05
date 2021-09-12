using System;

namespace BOOP_05_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, -5, 5, 16, 12, 3, 2, 8, 7, 3 };
            BubbleSort(intArray);

            foreach (int i in intArray)
            {
                Console.Write($"{i,4}");
            }
            Console.WriteLine();
        }
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool isAnyChange = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    // ViewPoint A
                    if (array[j] < array[j + 1])
                    {
                        isAnyChange = true;
                        (array[j], array[j+1]) = (array[j+1], array[j]);
                    }
                }

                if (!isAnyChange)
                {
                    break;
                }
            }
        }
    }
    // Exercise
    // 1. Print out the array at ViewPoint A together with i and j and see how the algorithm works
    // 2. Implement SelectionSort in descending sort order
    // 3. Implement BubbleSort with a boolean parameter specifying ascening or descending sort order
    // 4. Implement BubbleSort for an array of type "class Rectangle" sorted by Area in descending and ascending order 
}
