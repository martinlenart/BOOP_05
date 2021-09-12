using System;

namespace BOOP_05_04
{
    class Program
    {
        static double SafeDivision(double x, double y)
        {
            if ((x, y) == (0, 0))
                throw new DivideByZeroException("Divide zero by zero");
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }
        static void Main(string[] args)
        {
            // Input for test purposes. Change the values to see
            // exception handling behavior.
            double a = 0, b = 0;
            double result;

            try
            {
                Console.WriteLine("try-block: Executes");
                result = SafeDivision(a, b);
                Console.WriteLine($"{a} divided by {b} = {result}");
            }
            catch (DivideByZeroException ex) when (ex.Message == "Divide zero by zero")
            {
                Console.WriteLine("catch-block: You cannot divide zero by zero.");
                //throw; // test rethrow same exception
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("catch-block: Attempted divide by zero.");
            }
            finally
            {
                Console.WriteLine("finally-block: Always be executed");
            }
        }
    }
}
