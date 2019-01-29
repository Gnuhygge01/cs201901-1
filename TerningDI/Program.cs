using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningDI
{
    class Program
    {
        static void Main(string[] args)
        {

            //TilfældigshedGeneratorTest r = new TilfældigshedGeneratorTest();

            Terning t = new Terning(FindGenerator());
            t.Skriv();
        }

        public static ITilfældigshedGenerator FindGenerator() {

            string value = System.Configuration.ConfigurationManager.AppSettings["generator"];
            if(value== "TilfældigshedGeneratorSystemRandom")
                return new TilfældigshedGeneratorSystemRandom();

            if (value == "TilfældigshedGeneratorTest")
                return new TilfældigshedGeneratorTest();

            throw new ApplicationException("Generator findes ikke!!!");
        }
    }

    class Terning
    {
        public int Værdi { get; set; }

        private ITilfældigshedGenerator rnd;

        public Terning()
        {
            this.rnd = new TilfældigshedGeneratorSystemRandom();
            Ryst();
        }

        public Terning(ITilfældigshedGenerator generator)
        {
            this.rnd = generator;
            Ryst();
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine($"[{Værdi}]");
        }
    }

    interface ITilfældigshedGenerator {
        int Next(int min, int max);
    }

    class TilfældigshedGeneratorSystemRandom : ITilfældigshedGenerator
    {
        private static System.Random rnd = new Random();
        public int Next(int min, int max) {
            return rnd.Next(min, max);
        }
    }

    class TilfældigshedGeneratorTest : ITilfældigshedGenerator
    {
        
        public int Next(int min, int max)
        {
            return 6;
        }
    }
}
