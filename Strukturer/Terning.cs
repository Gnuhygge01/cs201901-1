using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukturer
{
    public class Terning
    {
        // Felter
        private static Random rnd;
        private int _værdi;

        // Egenskab
        public int Værdi
        {
            get
            {
                return _værdi;
            }
            set
            {
                if (value < 1 || value > 6)
                    value = 1;
                if (value == 6)
                    ErSekser?.Invoke(this, new EventArgs());
                _værdi = value;
            }
        }

        // Metode
        public void Ryst()
        {
            Værdi = rnd.Next(1, 7);
        }

        // Hændelse
        public event EventHandler ErSekser;

        // Konstruktør
        public Terning()
        {
            rnd = new Random();
            Ryst();
        }

        // Konstruktør
        public Terning(int værdi) : base()
        {
            rnd = new Random();
            this.Værdi = værdi;
        }
    }
}
