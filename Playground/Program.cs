using Code.Arrays.Exercises;
using System;

namespace Playground
{
    class Program
    {
        private static void Main()
        {
            int[,] m = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };

            Console.WriteLine(Matrix.Log(m));
            Console.WriteLine(Matrix.Log(Matrix.RotateNxN_v0(m)));
            Console.WriteLine(Matrix.Log(Matrix.RotateNxN_v1(m)));

            var a = 10;
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
