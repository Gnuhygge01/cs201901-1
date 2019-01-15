using System;

namespace Flow
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("*");

            goto ud;

            Console.WriteLine("*");

        ud:

            for (int p = 0; p < 10; p++)
            {

            }

            if (true)
            {
                Console.WriteLine("*");
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
