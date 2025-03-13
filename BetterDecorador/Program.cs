using System;

namespace BetterDecorador
{
    
    public class Program
    {
        /// <summary>
        /// Gets user input.
        /// Turns 1st argument into a string.
        /// Turns 2nd argument into a character.
        /// Turns 3rd argument into an integer and converts it to string.
        /// Displays the end result using the method Decor.
        /// </summary>
        /// <param name="args">Arguments inputted into the console.</param>
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
