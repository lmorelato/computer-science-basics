using Code.Arrays.Exercises;
using System;

namespace Playground
{
    class Program
    {
        private static void Main()
        {
            var a = new[] { 1, -2, 1, 0, 5 };

            for (var i = 0; i < a.Length - 2; i++)
            {
                for (var j = i + 1; j < a.Length - 1; j++)
                {
                    for (var k = j + 1; k < a.Length; k++)
                    {
                        if (a[i] + a[j] + a[k] == 6)
                            Console.WriteLine($"{a[i]} {a[j]} {a[k]}");
                    }
                }
            }


            //int[,] x = {{ 101, 102, 103, 104, 105 },
            //            { 106, 107, 108, 109, 110 },
            //            { 111, 112, 113, 114, 115 },
            //            { 116, 117, 118, 119, 120 },
            //            { 121, 122, 123, 124, 125 }};

            //int [,] y = {
            //    { 101, 102, 103, 104},
            //    { 105, 106, 107, 108},
            //    { 109, 110, 111, 112},
            //    { 113, 114, 115, 116}};

            //Console.WriteLine(Matrix.Log(y));
            //Console.WriteLine(Matrix.Log(Matrix.RotateNxN_v0(x)));
            //Console.WriteLine(Matrix.Log(Matrix.RotateNxN_v1(x)));

            //var a = 10;
            var b = 5;

            //Console.WriteLine("a = " + a);
            //Console.WriteLine("b = " + b);
            //Console.WriteLine();

            //// possibly arithmetic overflow
            //a = a + b; // a = 20
            //b = a - b; // b = 1
            //a = a - b; // a = 5

            //Console.WriteLine("a = " + a);
            //Console.WriteLine("b = " + b);
            //Console.WriteLine();

            //a = 10;
            //b = 5;

            //// b cannot be 0
            //a = a * b; // a = 50
            //b = a / b; // b = 10
            //a = a / b; // a = 5

            //Console.WriteLine("a = " + a);
            //Console.WriteLine("b = " + b);
            //Console.WriteLine();

            //a = 10;
            //b = 5;

            //// a = 1010 and b = 0101
            //a = a ^ b; // a = 15 (1111)
            //b = a ^ b; // b = 10 (1010)
            //a = a ^ b; // a = 5 (0101)

            //Console.WriteLine("a = " + a);
            //Console.WriteLine("b = " + b);
            //Console.WriteLine();

            //// << * 2^n
            //// >> / 2^n
            //var x = 28;
            //x = x >> 2;
            //Console.WriteLine("x =" + x);
        }
    }

    class ProgramImpl : Program
    {
    }
}
