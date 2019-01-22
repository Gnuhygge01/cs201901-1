using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1;
            p1 = new Person();

            p1.Alder = 1;
            p1.Navn = "a";

            Person p2 = new Person();
            p2.Alder = 2;
            p2.Navn = "b";

            Console.WriteLine(p1.Alder + " " + p1.Navn);
            Console.WriteLine(p2.Alder + " " + p2.Navn);

            p2 = p1;

            Console.WriteLine(p1.Alder + " " + p1.Navn);
            Console.WriteLine(p2.Alder + " " + p2.Navn);

            p1.Alder = 3;
            Console.WriteLine(p1.Alder + " " + p1.Navn);
            Console.WriteLine(p2.Alder + " " + p2.Navn);

            int x = 10;
            Console.WriteLine(x);
            Test(x);
            Console.WriteLine(x);

            Person p = new Person();
            p.Alder = 1;
            p.Navn = "a";
            Console.WriteLine(p.Alder);
            Test2(p);
            Console.WriteLine(p.Alder);


            int xx = 10;
            Console.WriteLine(xx);
            Testa(ref xx);
            Console.WriteLine(xx);

        }

        // ByValue
        static void Test(int a) {
            a = 10000;
        }

        
        static void Testa(ref int a)
        {
            a = 10000;
        }

        // ByReference
        static void Test2(Person p)
        {
            // Måske.... Clone....
            Person x = new Person();
            x.Alder = p.Alder;
            x.Navn = p.Navn;


            x.Alder = 100000;
        }


    }

    class Person {
        public int Alder;
        public string Navn;
    }

    class Hund { }
}
