using System;
using System.Collections.Generic;
using System.Text;

namespace Code.Algorithms.String
{
    public static class Strings
    {

        public static void Permute(string str, int left, int right)
        {
            if (left == right)
            {
                Console.WriteLine(str);
                return;
            }

            for (var i = left; i <= right; i++)
            {
                str = Swap(str, left, i);
                Permute(str, left + 1, right);
                //str = Swap(str, left, i);
            }
        }


        public static string Swap(string str, int a, int b)
        {
            var charArray = str.ToCharArray();
            var temp = charArray[a];
            charArray[a] = charArray[b];
            charArray[b] = temp;
            return new string(charArray);
        }
    }
}
