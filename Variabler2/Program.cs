using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler2
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                int i = 10, x = 20;

                if ((i == x && i < 10) || x == 20)
                {
                }
                else
                {

                }

                System.Boolean a = true;
                bool b = false;

                DateTime c = new DateTime(2019, 1, 15, 10, 13, 00);
                Console.WriteLine(c);

                DateTime d = DateTime.Now;
                Console.WriteLine(d);


                DateTime e = d.AddHours(-100);
                Console.WriteLine(d.ToString("dd-MM yy"));

                var wc = new System.Globalization.CultureInfo("da-DK");
                var nr = wc.Calendar.GetWeekOfYear(DateTime.Now,
                    System.Globalization.CalendarWeekRule.FirstDay,
                    DayOfWeek.Monday);
                Console.WriteLine($"Ugenummer {nr}");

                //System.TimeSpan ts = d.Subtract(c);
                System.TimeSpan ts = d - c;

                Console.WriteLine(ts.TotalSeconds);

                TimeSpan ts1 = new TimeSpan(2, 30, 0);

                DateTime d2 = (DateTime.Now).Add(ts1);
                Console.WriteLine(d2.ToLongTimeString());

            }


            {

                char a = 'A';
                Console.WriteLine(a);

                Console.WriteLine(Convert.ToInt32(a));

                char b = Convert.ToChar(65);
                Console.WriteLine(b);


                string navn = "Mikkel";
                Console.WriteLine(navn);

                string efternavn = "Cronberg";

                string fuldtNavn = navn + " " + efternavn;
                Console.WriteLine(fuldtNavn);

                string nytNavn = fuldtNavn.ToUpper();
                Console.WriteLine(nytNavn);

                //string sti = "c:\\temp\\test.data";
                string sti = @"c:\temp\test.data";
                Console.WriteLine(sti);

                string aa = "lsdlskdfj \" dflæjkdflgj";

                string bb = "dlfkdlfkgj\r\ndkljgdl\r\nflkjdf";
                Console.WriteLine(bb);

                int y = 100;
                string test = @"c:\test";
                string cc = $"ldkfl dkg {test} ldkgj {y:N5} dl {y}";
                Console.WriteLine(cc);

                int pris = 100;
                DateTime dato = new DateTime(2018, 1, 1);
                string res2 = $"Prisen er {pris} pr {dato}";
                Console.WriteLine(res2);
                Console.WriteLine("Prisen er " + pris.ToString() + " pr " + dato.ToString());

                string res3 = $"Prisen er {pris:n2} pr {dato:dd-MM-yyyy}";
                Console.WriteLine(res3);

                string dd = "sdsdf";
                Console.WriteLine(dd.ToUpper());
                //dd = dd + "*";
                dd = null;
                //if (dd != null)
                //{
                //    Console.WriteLine(dd.ToUpper());
                //}

                Console.WriteLine(dd?.ToUpper());


              

            }

            {
                //// Stopur
                //System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
                //s.Start();
                //string a = "";
                //for (int i = 0; i < 50000; i++)
                //{
                //    a += "*";
                //}
                //s.Stop();
                //Console.WriteLine($"ms = {s.ElapsedMilliseconds}");

                System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                s.Start();
                for (int i = 0; i < 10_000_0000; i++)
                {
                    sb.Append("*");
                }
                s.Stop();
                Console.WriteLine($"ms = {s.ElapsedMilliseconds}");
            }
            {

                const int y = 1;
                // double moms = 0.25;

                var i = 5;

                bool? u = null;
                if (u.HasValue) { } else { }

                




            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
