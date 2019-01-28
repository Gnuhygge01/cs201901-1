using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Person o1 = new Person();
            Medarbejder o2 = new Medarbejder();

            Person o3 = new Person("a");
             Medarbejder o4 = new Medarbejder("b", 76);

            //Kursist o3 = new Kursist();
            //Instruktør o4 = new Instruktør();

            o1.Navn = "a";
            o2.Navn = "b";
            //o3.Navn = "c";
            //o4.Navn = "d";
            o1.Skriv();
            o2.Skriv();
            //o3.Skriv();
            //o4.Skriv();

            Terning t1 = new Terning();
            t1.Skriv();
            for (int i = 0; i < 10; i++)
            {
            t1.Ryst();
                t1.Skriv(); 
            }

            Console.WriteLine();
            Terning t2 = new Terning(7);
            t2.Skriv();
        }
    }

    class Person {

        public string Navn { get; set; }

        public void Skriv() {
            Console.WriteLine("Jeg er en person og hedder " + this.Navn);
        }

        protected void Valider() { }

        public Person()
        {
            Console.WriteLine("Person bliver født");
        }

        public Person(string navn) {
            // validering
            this.Navn = navn;
        }
    }

    class Medarbejder : Person {
        public int MedarbejderId { get; set; }
        public void SkrivLønseddel() {
            this.Valider();
        }

        public Medarbejder()
        {
            Console.WriteLine("Medarbejder bliver født");
        }

        public Medarbejder(string navn, int medarbejderId) : base(navn)
        {
            this.MedarbejderId = medarbejderId;
        }
    }

    class Kursist : Person {

        public string Brugernavn { get; set; }

        public void TestLogin() { }
    }

    sealed class Instruktør : Medarbejder {
        public int NøgleId { get; set; }
        public void TestNøgle() {

            this.Valider();
        }
    }

    //class HjælpeInstruktør : Instruktør { }


    public class Terning {

        private int _værdi;
        private static System.Random rnd;

        static Terning()
        {
            rnd = new Random();
        }

        public void Ryst()
        {
            Værdi = rnd.Next(1, 7);
        }

        public Terning()
        {
            Ryst();
        }

        public void Skriv() {
            Console.WriteLine($"[{Værdi}]");
        }

        public Terning(int værdi)
        {
            Værdi = værdi;
        }

        public int Værdi {
            get {
                // .....
                // .....
                return _værdi;
            }
            set {
                // log
                // 
                if (value <= 0 || value > 6)
                    throw new ApplicationException("Forkert terning");
                this._værdi = value;
            }
        }



    }


}
