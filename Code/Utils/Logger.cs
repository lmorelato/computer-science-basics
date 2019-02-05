
using System;
using System.Collections.Generic;
using System.Text;

namespace Code.Utils
{
    public static class Logger
    {
        public static bool IsConsole = true;

        public static void Debug(string message, bool breakLine = false)
        {
            if (IsConsole) Console.WriteLine($"{(breakLine ? "\n" : string.Empty)} {message}");
            else System.Diagnostics.Debug.WriteLine($"{(breakLine ? "\n" : string.Empty)}// 'debug' {message}");
        }

        public static string ToString(List<int[]> array)
        {
            var sb = new StringBuilder();

            foreach (var item in array)
                sb.AppendLine(ToString(item));

            return sb.ToString();
        }

        public static string ToString(int[] array)
        {
            var sb = new StringBuilder();

            foreach (var t in array)
                sb.Append(t + " ");

            return sb.ToString();
        }
    }
}
