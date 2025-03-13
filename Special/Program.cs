using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine(GetSpecial(n));
            return;
        }

        private static int GetSpecial(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return GetSpecial(n - 1) + 2 * GetSpecial(n - 2);
        }
    }
}