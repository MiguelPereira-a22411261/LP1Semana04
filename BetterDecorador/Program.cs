using System;

namespace BetterDecorador
{
    /// <summary>
    /// Using the console, the program gets 3 arguments from the user, a string, a character and an integer.
    /// Displays the text with the character the user inputted the amount of times the user sets.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Gets user input.
        /// If user doesn't specify any arguments, returns the second Decor method.
        /// If user does specify the arguments:
        ///     Turns 1st argument into a string.
        ///     Turns 2nd argument into a character.
        ///     Turns 3rd argument into an integer and converts it to string.
        ///     Displays the end result using the method Decor.
        /// </summary>
        /// <param name="args">Arguments inputted into the console.</param>
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(Decor());
                return;
            }
            else
            {
                string str = args[0];
                char chr = args[1][0];
                int count = Int32.Parse(args[2]);
                Console.WriteLine(Decor(str, chr, count));
            }

        }
        /// <summary>
        /// Defines how the user input is going to be structured.
        /// </summary>
        /// <param name="str">Text to be decorated.</param>
        /// <param name="chr">Character to decorate the text.</param>
        /// <param name="count">Amount of times the character is going to appear.</param>
        /// <returns>Returns the character the amount of times set by "count", behind and after the text.</returns>
        private static string Decor(string str, char chr, int count)
        {
            string decoration = new string(chr, count);
            return $"{decoration} {str} {decoration}";
        }

        /// <summary>
        /// Method used in case the user doesn't specify arguments.
        /// </summary>
        /// <returns>Returns the specified string and repeats the specified character 3 times with the same structure as the first "Decor" method.</returns>
        private static string Decor()
        {
            return Decor("User did not specify args!",'=', 3);
        }
    }
}
