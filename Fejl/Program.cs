using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejl
{
    class Program
    {
        static void Main(string[] args)
        {

            //try
            //{

            //    string a = null;
            //    //a.ToUpper();
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("Fejl " + e.Message);
            //    return;
            //}
            ////finally
            ////{
            ////    Console.WriteLine("Altid kørt");
            ////}
            ///

            //try
            //{

            //    M1();
            //}
            //catch (Exception)
            //{


            //}

            //// Global fejlh.
            //try
            //{
            //    App();
            //}

            //catch (Exception ex)
            //{
            //    if (ex.InnerException != null) {
            //        Console.WriteLine(ex.InnerException.Message);
            //    }

            //    Console.WriteLine(ex.Message);
            //    // ... ex
            //}

            try
            {
                bool res = CheckCpr("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


          


        }

        public static bool CheckCpr(string cpr) {
            if (cpr == null)                
                throw new ApplicationException("Cpr må ikke være null");  // implicit return
            if (cpr == "")
                throw new ApplicationException("Cpr må ikke være blank");  // implicit return
            if (cpr.Length!=10)
                throw new ApplicationException("Cpr skal være 10 kar.");  // implicit return

            try
            {
                // logik
            }
            catch (Exception ex)
            {
                // log...
                throw;
            }

            return true;
        }

        static void App()
        {
            // kode....
        }


        static void M1()
        {
            M2();
        }
        static void M2()
        {
            M3();
        }
        static void M3()
        {
            string a = null;
            a.ToUpper();
        }
    }
}
