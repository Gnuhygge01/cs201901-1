using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukturer
{
    class Program
    {
        static void Main(string[] args)
        {



            string person1Navn = "Mathias";
            int person1Alder = 12;
            Køn person1Køn = Køn.Mand;
            Console.WriteLine((int)person1Køn);

            string person2Navn = "Lene";
            int person2Alder = 53;
            Køn person2Køn = Køn.Kvinde;

            SpillekortKulør k = SpillekortKulør.Ruder;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TEST");

            //Terning t = new Terning(4);
            //Console.WriteLine(t.Værdi);
            //t.Ryst();
            //Console.WriteLine(t.Værdi);

            //Terning t2 = new Terning();
            //t2.ErSekser += (s,e) => {
            //    Console.WriteLine("JUUUUBBBIIIII");
            //};
            //Console.WriteLine(t2.Værdi);
            //t2.Ryst();
            //Console.WriteLine(t2.Værdi);
            //t2.Ryst();
            //Console.WriteLine(t2.Værdi);

            Person p1 = new Person();
            p1.Navn = "Mathias";
            p1.Alder = 13;
            //p1.Skriv();

            Person p2;
            p2 = p1;
            p1.Alder = 14;

            //int u ;
            //u++;


            Point po1 = new Point();
            po1.X = 10;
            po1.Y = 20;


            Point po2 = new Point();
            po2.X++;
            po2.Y = 10;
            
            


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    public struct B { }

    public enum SpillekortKulør
    {
        Spar,
        Hjerter,
        Ruder,
        Klør
    }

    struct Point {
        public int X;
        public int Y;
    }

    internal struct Person
    {
        // felter
        public string Navn;
        public int Alder;
        public Point Point;
        public int test;

        //public void SætAlder(int alder)
        //{
        //    if (alder > 0 && alder < 100)
        //        Alder = alder;
        //    else
        //        Alder = 1;
        //}
        
        //private void Skriv()
        //{
        //    //test = 1;
        //    switch (switch_on)
        //    {
        //        default:
        //    }
        //    Console.WriteLine("Jeg hedder " + Navn + " og er " + Alder + " år");

        //} 

    }
}

