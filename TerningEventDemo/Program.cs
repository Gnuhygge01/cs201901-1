using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningEventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Sekser += (s,e) => Console.Write("YES!!! " + e.Tid); 
            t.Skriv();
            for (int i = 0; i < 9; i++)
            {
                t.Ryst();
                t.Skriv();
            }

            var a = new { };

            // datastruktur
            var b = new { navn = "a", id = 2.0 };
            

            

        }

        //static void Test(dynamic a) {
        //    a.navn
        //}

        //static void Sekser() {
        //    Console.Write("YES!!!");
        //}
    }

    public class Terning
    {
        private static System.Random rnd;
        public int Værdi;
        public event EventHandler<TerningEventArgs> Sekser;

        public Terning()
        {
            Ryst();
        }

        static Terning()
        {
            rnd = new Random();
        }

        public void Ryst()
        {
            Værdi = rnd.Next(1, 7);
            if (Værdi == 6)
                //if(Sekser!=null)
                Sekser?.Invoke(this, new TerningEventArgs() { Tid = DateTime.Now });
        }

        public void Skriv()
        {
            Console.WriteLine($"[{this.Værdi}]");
        }
    }

    public class TerningEventArgs : EventArgs {
        public DateTime Tid { get; set; }
    }

}
