using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{



    class Program
    {



        static void Main(string[] args)
        {

            Test1();
            //DelegateType1 d1 = new DelegateType1(Test1);
            Action d1 = Test1;
            d1.Invoke();
            KørTest(1, 3, d1);




            //DelegateType4 c = new DelegateType4(GemiFil);
            Action<string> c = GemiFil;
            c += Console.WriteLine;
            Kør(c);
            c -= GemiFil;
            Kør(c);
            c -= Console.WriteLine;
            //Kør(c);

            Action<int, bool, string> a;


            DelegateType4 c2 = Console.WriteLine;
            c2("gdgdg");


            Func<int, int, int> f1 = LægSammen;


            DelegateType3 beregner = FindBeregner();            
            Console.WriteLine(beregner (1, 1));



        }

        static DelegateType3 FindBeregner() {
            if (DateTime.Now.Millisecond % 2 == 0)
                return TrækFra;
            else
                return LægSammen;
        }

        static void Kør(Action<string> f) {
            f("Start");
            // logik
            f.Invoke("arbejder...");
            f.Invoke("Slut");
        }

        static int LægSammen(int a, int b) {
            return a + b;
        }

        static int TrækFra(int a, int b)
        {
            return a - b;
        }


        static void GemiFil(string txt) {
            System.IO.File.AppendAllText(@"c:\temp\test.txt", txt + "\r\n");
        }

        static void KørTest(int a, int b, Action funk) {
            // a + b
            funk.Invoke();
        }

        static void Test1() {
            Console.WriteLine("I Test1");
        }
        static void Test2(int a)
        {
            Console.WriteLine("I Test1");
        }
    }

    // Func metoder med returværdi
    // Action metoder uden returværdi

    delegate void DelegateType1();
    delegate void DelegateType2(int a);
    delegate int DelegateType3(int a, int b);
    delegate void DelegateType4(string t);

    class A { }
    struct B { }
    enum C { }



}
