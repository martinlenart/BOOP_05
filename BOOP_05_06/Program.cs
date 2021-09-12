using System;

namespace BOOP_05_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type some numbers separated by space e.g., 2,3 5,8 9,5");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            decimal sum = 0;
            bool allOK = true;
            foreach (string item in numbers)
            {
                if (decimal.TryParse(item, out decimal result))
                {
                    sum += result;
                }
                else
                {
                    Console.WriteLine("Numberformat incorrect!");
                    allOK = false;
                    break;
                }
            }

            if (allOK)
                Console.WriteLine($"The sum is {sum}");
        }
    }
}
//Exercises:
//1.    Rewrite the code from BOOP_05_04 using TryXXX pattern instead of try-catch-finally pattern.
