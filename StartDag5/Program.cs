using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartDag5
{
    class Program
    {
        static void Main(string[] args)
        {

            A[] array1;
            array1 = new A[10];

            List<B> lst;
            lst = new List<B>();
            lst.Add(new B());

            B bb = lst[0];


        }
    }

    struct A {

    }


    class B {

        // offentligt felt
        public int A;   // nej tak

        // privat felt
        private int c;

        // Komplet egenskab
        public int C {
            get {
                // validering
                // sikkerhed
                // log
                return this.c;
            }
            set {
                // validering
                // sikkerhed
                // log
                this.c = value;
            }
        }

        // Automatisk egenskab
        public int D { get; private set; } = 1;

        public void Test() { }

        // Default
        public B() : this(0)
        {

        }

        // Custom
        public B(int a)
        {
            // ini
            // sikkerhed
            // log
        }

        // Destructor
        ~B() {
            // jeg dør....
        }


    }


}
