using System;

namespace BOOP_05_01
{
    class Program
    {
        public struct Point
        {
            public long X, Y;
        }
        static void Main(string[] args)
        {
            Point[] ar1 = { new Point { X = 3, Y = 3 }, new Point { X = 4, Y = 4 }};
            //A
            
            for (int i=0; i<ar1.Length; i++)
            {
                var title1 = $"{nameof(ar1)}[{i}]";
                Print(title1, ar1[i].X, ar1[i].Y);

                Point[] ar2 = { new Point { X = 1, Y = 1 }, new Point { X = 2, Y = 2 } };
                //B
                for (int j = 0; j < ar2.Length; j++)
                {
                    var title2 = $"{nameof(ar2)}[{j}]";
                    //C
                    Print(title2, ar2[j].X, ar2[j].Y);
                }
                title1 = $"{nameof(ar1)}[{i}]";
                var vector = Math.Sqrt(ar1[i].X * ar1[i].X + ar1[i].Y + ar1[i].Y);
                Print(title1, vector);
                //D
            }
            //E
        }
        static void Print(string title, long X, long Y)
        {
            Console.WriteLine($"\n{title}");
            Console.WriteLine($"\t(X, Y) = ({X}, {Y})");
        }
        static void Print(string title, double vector)
        {
            Console.WriteLine($"\n{title}");
            Console.WriteLine($"\tVector = {vector:F2}");
        }
    }
}
