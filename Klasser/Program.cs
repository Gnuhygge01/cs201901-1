using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = null;
            p1 = new Person();

            Person p2 = new Person();
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p1);

            //Person p3 = new Person("a", Person.Køn.Mand, 150);

            Person p4 = new Person();
            p4.navn = "a";


            // p1 = p2;

            Person p5 = new Person(Person.Køn.Kvinde);

            Person p6 = new Person();
            p6.navn = "lkk";
            p6.køn = Person.Køn.Kvinde;

            Person p7 = new Person
            {
                køn = Person.Køn.Kvinde,
                navn = ""
            };

            Vare v = new Vare();

            


        }
    }

    static class MineBeregning {
        public static void Test() { }
    }


    internal class Person
    {

        // Felter... Fields... Data...
        public string navn;
        private int alder;
        public Køn køn;

        // Default...
        public Person() : this("", Køn.Mand, 1)
        {
            // log
        }

        // Custom
        public Person(Køn køn) : this("", køn, 1) {

        }


        // Custom
        public Person(string navn, Køn køn, int alder)
        {
            // log
            // sikkerhed
            // validering
            // initialisering
            if (alder < 1 || alder > 100)
                throw new ApplicationException("Forkert alder");
            this.navn = navn;
            this.køn = køn;
            this.alder = alder;
        }

        public enum Køn
        {
            Mand,
            Kvinde
        }

        public static bool ValiderCpr(string cpr) {
            return true;
        }
    }

    public partial class Vare
    {

        private static double momsPct;
        public readonly int AppId;


        public Vare()
        {
            momsPct = 0.25;
            AppId = 2 * 55;
        }

        public void Test1() {

        }

    }

 
}
