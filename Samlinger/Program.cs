using System;
using System.Collections.Generic;
using System.Collections;
// using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlinger
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList a;
            a = new ArrayList();
            a.Add(1);
            a.Add(2);
            a.Add(1);
            a.Add(100);
            a.Add("s");
            a.Add(new Hund());
            a.Insert(2, 1000);

            Queue q = new Queue();
            q.Enqueue("a");
            q.Enqueue("b");
            q.Enqueue("c");
            var r = q.Dequeue();

            Stack s = new Stack();
            s.Push(2);
            s.Push(24);
            s.Push(42);
            var r2 = s.Pop();

            Kennel k = new Kennel();
            k.IndsætHund(new Hund());

            // ------------------------------------

            List<int> lst1 = new List<int>();
            lst1.Add(5);
            int r3 = lst1[0];
            lst1.Sort();

            List<Hund> kennel2 = new List<Hund>();
            kennel2.Add(new Hund());
            Hund r4 = kennel2[0];

            Queue<Kunde> kunder = new Queue<Kunde>();
            kunder.Enqueue(new Kunde());
            Kunde r5 = kunder.Dequeue();

            Stack<Spillekort> kort = new Stack<Spillekort>();
            kort.Push(new Spillekort());

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("a", 132163);
            dic.Add("b", 54);
            int r6 = dic["b"];


            Test();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        
        public static void Test() {

        }
    }

    class Kunde { }

    class Spillekort { }
}
