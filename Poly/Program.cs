using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly
{
    class Program
    {
        static void Main(string[] args)
        {

            Hund h = new Hund() { Navn = "fido" };
            //Console.WriteLine(h.ToString());

            Elev e = new Elev();
            e.Navn = "a";
            e.Skriv();

            OnlineElev o = new OnlineElev() { Navn = "b" };
            o.Skriv();

            Console.WriteLine(o);
        }
    }

    class Hund {
        public string Navn { get; set; }

        public override string ToString()
        {
            return "Jeg er en Hund og hedder " + this.Navn;
        }
    }

    class Person {
        public string Navn { get; set; }

        public virtual void Skriv() {
            Console.WriteLine("Jeg er en person og hedder " + this.Navn);
        }
    }

    class Elev : Person {
        public override void Skriv()
        {
            Console.WriteLine("Jeg er en ELEV og hedder " + this.Navn);
        }
    }

    class OnlineElev : Elev
    {
        public override void Skriv()
        {
            Console.WriteLine("Jeg er en ONLINE ELEV og hedder " + this.Navn);
        }
    }

    class Terning {

        public virtual void Skriv() { }
    }

    class LudoTerning : Terning
    {

        public override void Skriv()
        {
            
        }
    }


}
