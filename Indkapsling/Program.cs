using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCronberg;

namespace Indkapsling
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Navn = "a";
            
            //p.SetNavn("a");

            Console.WriteLine(p.Navn);

            Console.WriteLine(p.ToStringEx());
        }
    }


    //public class Person {

    //    private string _navn;

    //    public void SetNavn(string navn) {
    //        // log
    //        // sikkerhed
    //        // validering
    //        if (navn == null)
    //            throw new ApplicationException("Forkert navn");

    //        this._navn = navn;
    //    }

    //    public string GetNavn() {
    //        // log
    //        // sikkerhed
    //        // validering

    //        return this._navn.Trim();
    //    }

    //}

    public class Person {

        private string _navn;

        public string Navn {
            get {
                // log
                // sikkerhed
                // validering
                return this._navn.Trim();
            }
            set {
                // log
                // sikkerhed
                // validering
                if (value == null)
                    throw new ApplicationException("Forkert navn");
                this._navn = value;
            }
        }

        private DateTime _fødselsdag;

        public DateTime Fødselsdag
        {
            get {

                return _fødselsdag;


            }
            set {

                _fødselsdag = value;

            }
        }

        private bool _erILive;

        public bool ErILive
        {
            get { return _erILive; }
            set { _erILive = value; }
        }

        private double _løn;

        public double Løn
        {
            get { return _løn; }
            set { _løn = value; }
        }

        // propfull
    }
}
