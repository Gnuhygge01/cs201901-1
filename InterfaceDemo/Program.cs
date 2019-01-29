using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            TandBøste t = new TandBøste();
            t.Start();
            t.TestMaskine(2);
            t.Stop();

            SkibsMotor s = new SkibsMotor();
            s.Start();
            s.TestMaskine(2);
            s.Stop();

            IMaskine i;
            i = new TandBøste();

            List<IMaskine> lst = new List<IMaskine>();
            lst.Add(new TandBøste());
            lst.Add(new TandBøste());
            lst.Add(new SkibsMotor());
            lst.Add(new SkibsMotor());
            lst.Add(new TandBøste());
            lst.Add(new TandBøste());


            foreach (var item in lst)
            {
                //if (item is TandBøste) {
                //    TandBøste tt = item as TandBøste;                    
                //}
                //if (item is SkibsMotor) {

                //}
                item.Start();
                item.Stop();
            }

            Console.WriteLine();

            IMaskine f = Find();
            f.Start();


            List<Person> lst2 = new List<Person>()
            {
                new Person(){ Alder = 10, Navn = "z" },
                new Person(){ Alder = 8, Navn = "b" },
                new Person(){ Alder = 9, Navn = "c" },
            };
            foreach (Person item in lst2)
                Console.WriteLine($"{item.Navn} er {item.Alder} år");

            lst2.Sort();
            Console.WriteLine();
            foreach (Person item in lst2)
                Console.WriteLine($"{item.Navn} er {item.Alder} år");


            //Bil b = new Bil();
            //b.Dispose();
            //b = null;

            using (Bil b = new Bil())
            {

                // bil bruges

            }   // kalder dispose


        }

        public static IMaskine Find()
        {
            if (DateTime.Now.Millisecond % 2 == 0)
            {
                return new TandBøste();
            }
            else
            {
                return new SkibsMotor();
            }
        }
    }


    class Bil : IDisposable {

        public Bil()
        {
            Console.WriteLine("Jeg fødes");
        }

        ~Bil() {
            // log
            Console.WriteLine("Jeg dør");
        }

        public void Dispose() {
            Console.WriteLine("Jeg rydder op");
        }

    }

    interface IDbFunktioner
    {
        void Gem(string sti);
    }

    interface IMaskine
    {
        void Start();
        void Stop();
        bool TestMaskine(int i);
    }

    class Dyr  { }

    class Hund : Dyr, IDbFunktioner
    {
        public void Gem(string sti)
        {
            // ...
        }
    }
    class TandBøste : IMaskine, IDbFunktioner
    {

        public string Model { get; set; }

        public void Gem(string sti)
        {
            //
        }

        public void Start()
        {
            Console.WriteLine("Starter tandbøste");
        }

        public void Stop()
        {
            Console.WriteLine("Stopper tandbøste");
        }

        public bool TestMaskine(int i)
        {
            Console.WriteLine("Tester tandbøste");
            return true;
        }
    }

    class SkibsMotor : IMaskine
    {

        public int AntalTurbiner { get; set; }
        public void Start()
        {
            Console.WriteLine("Starter skibsmotor");
        }

        public void Stop()
        {
            Console.WriteLine("Stopper skibsmotor");
        }

        public bool TestMaskine(int i)
        {
            Console.WriteLine("Tester skibsmotor");
            return true;
        }
    }

    class Person : IComparable<Person>
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(Person other)
        {
            return this.Navn.CompareTo(other.Navn);
            //if (this.Alder > other.Alder)
            //    return 1;
            //if (this.Alder < other.Alder)
            //    return -1;
            //return 0;
        }

        //public int CompareTo(object obj)
        //{
        //    Person p = obj as Person;
        //    if (this.Alder > p.Alder)
        //        return 1;
        //    if (this.Alder < p.Alder)
        //        return -1;
        //    return 0;
        //}
    }

    class Terning
    {
        private static System.Random generator = new Random();

        public int Værdi { get; set; }

        public Terning()
        {            
            Ryst();
        }

        public void Ryst()
        {
            this.Værdi = generator.Next(1,7);
        }


    }
}
