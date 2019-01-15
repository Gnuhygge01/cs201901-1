using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a = 10;

                {
                    a = 20;
                    int c = 20;
                        
                        
                        
                }

                {
                    a = 30;
                    
                }

                
            }
            {
                int w = 200;
                for (int i = 0; i < 10; i++)
                {
                    i = 400;
                    w++;

                }
                Console.WriteLine(w);


                {
                    int g = 3;

                }

                int antalMånederPrÅr = 12;
                if (antalMånederPrÅr < 10)
                {

                }
                else
                {

                }

                //int a;
                //a = 0;

                int b = new int();
                //int b;


                //int u = new int();
                int u = 0;
                u = 100;
                Console.WriteLine(u.ToString());

                Console.WriteLine(int.MinValue);

                DateTime d = new DateTime(2018, 1, 1);
                // instans medlem

                Console.WriteLine(d.ToLongDateString());

                // statisk medlemmer
                Console.WriteLine(DateTime.Now);
                Console.WriteLine(DateTime.IsLeapYear(2018));


                int s = 338585858;


                double d1 = 23890430.345;
                decimal d2 = 9489348753945.345M;
                float d3 = 3434.3F;


                // int, double
                int i1 = 3490505;
                double i2 = 34095345.34;


                int yy = 1;
                yy = yy + 1;
                yy++;

                yy += 10;
                yy = yy + 10;

            }

            {
                //checked
                //{
                //    byte l = 255;
                //    l += 20;
                //    Console.WriteLine(l);
                //}
            }

            {

                byte a = 10;
                int b = 30;

                //b = a;

                a = System.Convert.ToByte(b);
                a = (byte)b;
                Console.WriteLine(a);

                


            }

            {

                Console.WriteLine("Indtast 1. tal");
                string tal1 = Console.ReadLine();
                Console.WriteLine(tal1);
            }

        }
    }
}
