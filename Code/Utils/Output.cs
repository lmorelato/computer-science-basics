
namespace Code.Utils
{
    public static class Output
    {
    
        public static void Debug(string message, bool breakLine = false)
        {
            System.Diagnostics.Debug.WriteLine($"{(breakLine ? "\n" : string.Empty)}// 'debug' {message}");
        }

    }
}
