using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //System.Timers.Timer t = new System.Timers.Timer();
            //t.Enabled = true;
            //t.Interval = 1000;
            ////t.Elapsed += Tick;
            //t.Elapsed += (o, e) => Console.WriteLine("Tick..." + e.SignalTime); 

            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp");
            w.EnableRaisingEvents = true;
            w.Created += (o, e) => Console.WriteLine("oprettet" + e.Name);
            w.Deleted += (o, e) => Console.WriteLine("slettet" + e.Name);


            do
            {

            } while (true);

        }

        private static void Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Tick..." + e.SignalTime);
        }
    }
}
