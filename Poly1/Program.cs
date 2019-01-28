using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly1
{
    class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            B b = new B();
            C c = new C();
            
            //

            A aa = new B();
            B bb = aa as B;

            Hund h = new Hund();
            h.SigerNoget();

            Kat k = new Kat();
            k.SigerNoget();

            Dyr d = new Kat();
            d.SigerNoget();

            Console.WriteLine();
            List<Dyr> zoo = new List<Dyr>();
            zoo.Add(new Kat() { Navn = "a" });
            zoo.Add(new Hund());
            zoo.Add(new Hund());
            zoo.Add(new Kat());
            //zoo.Add(new Dyr());

            foreach (Dyr dyr    in zoo)
            {
                dyr.SigerNoget();
            }


            Bil bil = new Bil();
            bil.Test();

            Lastbil l = new Lastbil();

            Bil b2 = new Lastbil();
            b2.Test();
        }
    }

    abstract class Dyr {
        public string Navn { get; set; }
        public abstract void SigerNoget();
    }

    class Hund : Dyr {
        public override void SigerNoget()
        {
            Console.WriteLine("Vov");
        }
    }

    class Kat : Dyr {
        public override void SigerNoget()
        {
            Console.WriteLine("Miaw");
        }
    }


    class A {
        public void Ta() { }
    }
    class B : A {
        public void Tb() { }
    }
    class C : B {
        public void Tc() { }
    }

    class Bil {
        public void Test() { }
    }

    class Lastbil : Bil {
        public void Test()
        {
            
        }
    }
}
