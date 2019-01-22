using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDemo
{
    class Program
    {

        private static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            log.Debug("App start");

            
            log.Debug("Henter fra db ...");
            log.Trace("select * from .....");
            // henter....
            log.Debug("Data hentet");

            try
            {
                string t = null;
                t.ToUpper();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                Console.WriteLine("Der er sket en fejl");
            }


            log.Debug("App slut");
        }

        static void Test(int a) {
            log.Debug("Test er kaldt med " + a);
            log.Debug("Færdig med test");
        }
    }
}
