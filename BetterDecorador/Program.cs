using System;

namespace BetterDecorador
{
    public class Program
    {

        private static void Main(string[] args)
        {
            string str = args[0];
            char chr = args[1][0];
            int count = Int32.Parse(args[2]);

            Console.WriteLine(Decor(str, chr, count));
        }
        private static string Decor(string str, char chr, int count)
        {
            string decoration = new string(chr, count);
            return $"{decoration} {str} {decoration}";
        }
    }
}
