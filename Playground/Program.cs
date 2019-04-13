using System;
using Code.Algorithms.Sorting;
using Code.DataStructures.Exercises;
using Code.Algorithms.String;
using Code.Utils;


namespace Playground
{

    class Program
    {
        private static void Main()
        {

            var qs = new[] { 4, 5, 0, 3, 1, 2 };
            Logger.Debug(Logger.ToString(qs));
            QuickSort.Perform(qs);
            Logger.Debug(Logger.ToString(qs));


            //var buble = new []{1, 0, 2, 4};
            //BubleSort.PerformV2(buble);



            //var word = "ABB";
            //Strings.Permute(word, 0, word.Length - 1);



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

            //Console.WriteLine(Matrices.Log(y));
            //Console.WriteLine(Matrices.Log(Matrices.RotateNxN_v0(x)));
            //Console.WriteLine(Matrices.Log(Matrices.RotateNxN_v1(x)));



            //var a = 10;
            //var b = 5;

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

            Console.ReadLine();
        }
    }
}
