using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] array1;
            array1 = new int[5];

            int[] array2 = new int[5];

            int[] array3 = { 1, 5, 1, 7, 1, 14 };
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);
            }


            System.Array.Sort(array3);
            Console.WriteLine();
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);
            }

            Hund[] hunde = new Hund[5];
            hunde[0] = new Hund();
            hunde[1] = new Hund();
            //hunde[2] = 5;

            string csv = "1;5;7;65";
            string[] data = csv.Split(';');

            LægSammen(1, 2, 3, 4, 25, 56, 4, 4, 5);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

        public static int LægSammen(params object[] tal)
        {
            
            return 0;
        }


    }

    class Hund {
        public string Navn { get; set; }
    }
}
