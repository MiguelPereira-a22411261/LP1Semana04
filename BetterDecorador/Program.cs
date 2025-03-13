using System;

namespace BetterDecorador
{
    public class Program
    {

        private static void Main(string[] args)
        {
            
        }
        private static string Decor(string str, char chr, int count)
        {
            string decoration = new string(chr, count);
            return $"{decoration} {str} {decoration}";
        }
    }
}
