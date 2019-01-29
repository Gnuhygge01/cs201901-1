using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            //Action a1 = Test1;
            //a1();

            Action a1 = () =>
            {
                // lkdjgfælksjg æslkfdjg 

                Console.WriteLine("I anonym funktion");
            };
            a1();

            Action<string> a2 = (string t) =>
            {
                Console.WriteLine("***" + t + "****");
            };

            Test2(a2);

            //Func<int, int, int> a3 = (int a, int b) => { return a + b; };
            Func<int, int, int> a3 = (a, b) => a + b;

            Console.WriteLine(a3(5, 5));

            int[] tal = { 4, 17, 1, 81, 561, 7, 56 };
            // var res = tal.Where(MindreEnd10);
            //var res = tal.Where((int i) => { return i < 10; });
            var res = tal.Where(i => i < 10).OrderBy(x => x);



        }

        //static bool MindreEnd10(int i) {
        //    return i < 10;
        //}

        //static void Skriv(string t) {
        //    Console.WriteLine("***" + t + "****");
        //}
        static void Test1()
        {
            Console.WriteLine("I test1");
        }

        static void Test2(Action<string> f)
        {
            f("Start");
            Console.WriteLine("I test2 ");
            f("Slut");
        }

    }
}
