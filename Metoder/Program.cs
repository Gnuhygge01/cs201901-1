using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.Alder = 10;
            //p.SkrivAlder();

            //bool res = Person.CheckAlder(43);


            int dda = LægSammen(10, 20);

            Test1();


            Test2(2000);

            int a = 10;
            Test2(a);

            int rrr = 1000;
            Test2(rrr);

            a = Metode4();

            // Statisk
            //System.IO.File.Delete("");


            //// Instans
            //System.IO.FileInfo f = new System.IO.FileInfo(@"c:\temp\test.txt");

            //f.Delete();

            Test6(5, false);
            Test6(5);

            double res2 = Test7(100);

            Metode1("", 2, true, "");
            Metode1(navn: "", alder: 2, land: "", erSmart: true);


            MinReturType res5 = Test10(5);

            FindFiler(@"c:\drivers");

            Person2 p2 = new Person2();
            p2.Navn = "a";
            p2.Alder = 1;


        }

        public static void FindFiler(string sti) {            
            foreach (var fil in System.IO.Directory.GetFiles(sti))
                Console.WriteLine(fil);            
            foreach (var mappe in System.IO.Directory.GetDirectories(sti))
                FindFiler(mappe);

            
        }

        public static void Test9() {

            //bool res = ValiderCpr(54);

            bool ValiderCpr(int t)
            {
                return true;
            }

            //Func<int, bool> ValiderCpr = (int a) => { return true; };

            var res4 = Test10a(1);
            
            
        }

        public static MinReturType Test10(int a) {
            MinReturType t = new MinReturType();
            t.a = 10;
            t.b = true;
            t.c = 223;
            return t;
        }

        public static (int, bool, double ) Test10a(int a)
        {
            return (5, true, 4.5);
        }


        public static void Ov1() {

        }
        public static void Ov1(int a) { }
        public static void Ov1(int a, int b) { }
        public static void Ov1(int a, bool b) { }
        public static int Ov1(int a, int b, int c) {
            return 1;
        }

        public static void Test6(int a, bool b = true)
        {

        }

        static void Metode1(string navn, int alder, bool erSmart, string land)
        {
        }

        public static double Test7(int a, double momsPct = 0.25)
        {
            return 0;
        }

        private static int LægSammen(int a, int b)
        {
            int res = a + b;
            return a;
        }

        public static int Metode4()
        {
            // Skal indeholde en return
            return 1;
        }

        static void Test1()
        {
            if (true)
                return;

            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                //
                return;

            }
            else
            {

            }


            return;
        }

        static void Test2(int a)
        {
            a = 1000;
            return;
        }

    }

    struct MinReturType {
        public int a;
        public bool b;
        public double c;
    }

    struct Person
    {

        public int Alder;

        public void SkrivAlder()
        {
            Console.WriteLine($"Alder {Alder}");
        }

        public static bool CheckAlder(int alder)
        {

            // logik
            return true;

        }

    }

    struct Person2
    {

        public string Navn;
        public int Alder;

        public void Udskriv()
        {
            Console.WriteLine($"Jeg hedder {this.Navn} og er {Alder} gammel");
        }

        public static bool ValiderCpr(string cpr)
        {
            return true;
        }

    }


}
