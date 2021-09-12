using System;

namespace BOOP_05_08
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
}
//Exercises:
//1.    Use the debugger to step through the BubbleSort algorithm and follow the sorting process.
//      Print out the array at ViewPoint A together with i and j and see how the algorithm works
//      Draw the changes on a piece of paper so you understand the algorithm.
//2.    Implement BubbleSort for an array of type "struct PlayingCard" sorted by Value in descending
