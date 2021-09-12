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
//Exercises:
//1.	Create a variable, sVal, of type string and assign it value “345”. Create a variable, intVal, of type int?. 
//2.    Write code using try-catch-finally to assign intVal the integer value of sVal.
//      If the int.Parse succeeds intVal should have the integer value corresponding to sVal(in this case 350).
//      If int.Parse is unsuccessful intVal should contain null.
//3.    Create a VS2019 project and using Console.WriteLine and Console.Readline write a program that gives the
//      user 3 menu choices to select from.
//      Use try-catch-finally to determine that the user has given a correct input.
//      If not correct input notify the user and allow her/him to make a new selection

