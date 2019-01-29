using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01
{

    public class TestTerning
    {
        public static void Test()
        {
            Terning t = new Terning();
            t.Skriv();
            for (int i = 0; i < 10; i++)
            {
                t.Ryst();
                t.Skriv();
            }

        }
    }

    public class Terning
    {
        private static System.Random rnd;
        public int Værdi;

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
        }

        public void Skriv()
        {
            Console.WriteLine($"[{this.Værdi}]");
        }
    }
}
