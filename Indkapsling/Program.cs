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

            //Console.WriteLine(p.Navn);

            //Console.WriteLine(p.ToStringEx());

            Hund h = new Hund();
            Console.WriteLine(h.Navn); 
            Console.WriteLine(h.ToStringEx());

            Bil b = new Bil();
            b.Model = "a";
            Console.WriteLine(b.Model);
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

        public bool ErILive2
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

    class Hund {

        // prop
        public string Navn { get; private set; }
        //public int AntalBen { get; set; }
        public bool ErILive { get; set; }

        private int _antalBen;

        public int AntalBen
        {
            get {

                return _antalBen; }
            set {

                if (value > 4)
                    throw new ApplicationException("Fejl");

                    _antalBen = value; }
        }

        public void Skriv()
        {
            this.Navn = "";
            throw new System.NotImplementedException();
        }
    }

    class Bil {

        private string _model;

        public string Model
        {
            get {
                // log
                Console.WriteLine("Logger... " + _model);
                return _model;

            }
            set {

                _model = value;

            }
        }

        public Bil()
        {
            // _model = "";
            Model = "";
        }

    }
}
