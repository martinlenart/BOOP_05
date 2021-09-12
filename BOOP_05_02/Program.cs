using System;

namespace BOOP_05_02
{
    class Program
    {
        public struct StructPoint
        {
            public long X, Y;
        }
        public class ClassPoint
        {
            public long X, Y;
        }

        static void Main(string[] args)
        {
            // Arrays of Value Type
            StructPoint[] structArr = { new StructPoint { X = 1, Y = 1 }, new StructPoint { X = 2, Y = 2 } };
            int[] intArr = { 1, 2, 3, 4 };

            // Array of Reference Type
            ClassPoint[] classArr = { new ClassPoint { X = 3, Y = 3 }, new ClassPoint { X = 4, Y = 4 } };

            // Array of string (immutable reference type)
            string[] strArr = "the quick brown fox".Split();

            //Now lets copy the arrays, modify an original element and compare and compare
            // Clone Value types
            StructPoint[] structCopy = (StructPoint[]) structArr.Clone();
            structArr[0].X = structArr[0].Y = 5;
            Console.WriteLine($"structCopy[0]: X = {structCopy[0].X}, Y = {structCopy[0].Y}"); // 1,1 
            Console.WriteLine($"structArr[0]: X = {structArr[0].X}, Y = {structArr[0].Y}");    // 5,5 

            int[] intCopy = (int[])intArr.Clone();
            intArr[0] = 5;
            Console.WriteLine($"\nintCopy[0] = {intCopy[0]}"); // 1 
            Console.WriteLine($"intArr[0] = {intArr[0]}");   // 5

            // Clone Reference types
            ClassPoint[] classCopy = (ClassPoint[])classArr.Clone();
            classArr[0].X = classArr[0].Y = 5;
            Console.WriteLine($"\nclassCopy[0]: X = {classCopy[0].X}, Y = {classCopy[0].Y}"); // 5,5 !! 
            Console.WriteLine($"classArr[0]: X = {classArr[0].X}, Y = {classArr[0].Y}");      // 5,5 

            //Clone String Type 
            string[] strCopy = (string[])strArr.Clone();
            strArr[1] = "slow";
            Console.WriteLine($"\nstrCopy[1] = {strCopy[1]}"); // quick !! 
            Console.WriteLine($"strArr[1] = {strArr[1]}");     // slow
        }
    }
}
