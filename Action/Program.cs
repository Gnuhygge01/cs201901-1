using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_heltsimpel
{
    // test
    //public delegate void MinDelegate1(string t);

        // lkdf gældsfjg ælkjgsælkd jgsfg
        // dsælkgf ædslkjfgsældkjg sældkfjg 

    class Program
    {
        static void Main(string[] args)
        {
            Action<string> f1 = MinSkrivTilConsole;
            f1.Invoke("test");

            Action<string> f2 = MinSkrivTilConsole;
            f2("test");

            Action<string> f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("test");

            f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            f3 -= Console.WriteLine;

        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }
}
