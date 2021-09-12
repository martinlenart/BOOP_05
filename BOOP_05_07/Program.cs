using System;

namespace BOOP_05_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, -5, 5, 16, 12, 3, 2, 8, 7, 3 };
            SelectionSort(intArray);

            foreach (int i in intArray)
            {
                Console.Write($"{i,4}");
            }
            Console.WriteLine();
        }
        public static void SelectionSort(int[] array)
        {
            for (int unsortedStart = 0; unsortedStart < array.Length - 1; unsortedStart++)
            {
                // ViewPoint A
                int minIndex = unsortedStart;
                int minValue = array[unsortedStart];

                //Iterate over the unsorted part
                for (int i = unsortedStart + 1; i < array.Length; i++)
                {
                    //Find the smalest element in the unsorted part
                    if (array[i] < minValue)
                    {
                        minIndex = i;
                        minValue = array[i];
                    }
                }

                // Swap the smalest element with the 
                // Two ways to swap:
                
                // Traditional
                int tmp = array[unsortedStart];
                array[unsortedStart] = array[minIndex];
                array[minIndex] = tmp;

                // Using tuples 
                //(array[unsortedStart], array[minIndex]) = (array[minIndex], array[unsortedStart]);
            }
        }
    }
    // Exercise
    // 1. Print out the array at ViewPoint A and see how the algorithm works
    // 2. Implement SelectionSort in descending sort order
    // 3. Implement SelectionSort with a boolean parameter specifying ascening or descending sort order
    // 4. Implement SelectionSort for string[]
}
