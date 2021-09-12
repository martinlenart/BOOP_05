using System;

namespace BOOP_05_05
{
    class Program
    {
        static double SafeDivision(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }

        static double?[] ArrayDivision((double number, double divisior)[] divisionArray)
        {
            var result = new double?[divisionArray.Length];

            // i <= divisionArray.Length will cause index out of bounds exception, which is caught and bubbles up in the nested try-catch
            for (int i = 0; i < divisionArray.Length; i++)
            {
                try
                {
                    result[i] = SafeDivision(divisionArray[i].number, divisionArray[i].divisior);
                }
                catch (DivideByZeroException)
                {
                    result[i] = null;
                }
                catch (Exception ex)
                {
                    result[i] = null;
                    Console.WriteLine($"Inner catch-block: {ex.Message}");
                    throw;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            (double number, double divisor)[] divisionArray = { (10.4D, 2.0D), (15.3D, 8.6D), (15.3D, 0), (12.7D, 13.4D), (0,0)};

            try
            {
                var result = ArrayDivision(divisionArray);

                for (int i = 0; i < divisionArray.Length; i++)
                {
                    // notice how I use null-condition and null-coalescing operators when printing the result
                    string strResult = result[i]?.ToString() ?? "<not possible>";
                    Console.WriteLine($"{divisionArray[i].number:F2} divided by {divisionArray[i].divisor:F2} equals {strResult}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Outer catch-block: {ex.Message}");
            }
        }
    }
}
