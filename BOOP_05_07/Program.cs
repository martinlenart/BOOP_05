using System;

namespace BOOP_05_07
{
    #region Exercise
    public enum PlayingCardColor
    {
        Clubs, Diamonds, Hearts, Spades         // Poker suit order, Spades highest
    }
    public enum PlayingCardValue
    {
        Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
        Knight, Queen, King, Ace                // Poker Value order
    }
    public struct PlayingCard
    {
        public PlayingCardColor Color;
        public PlayingCardValue Value;
    }
    #endregion   
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
}
//Exercises:
//1.   Use the debugger to step through the SelectionSort algorithm and follow the sorting process.
//      Print out the array at ViewPoint A and see how the algorithm works
//      Draw the changes on a piece of paper so you understand the algorithm.
//2.	Modify SelectionSort so it sorts in descending order instead of ascending order
//3.	Modify SelectionSort to sort an array of doubles, i.e., double[]
//4.    Implement SelectionSort with a boolean parameter specifying ascening or descending sort order
//5.    Implement SelectionSort for string[]
//6.    Implement SelectionSort for PlayingCard[] on Value decending and ascending order
