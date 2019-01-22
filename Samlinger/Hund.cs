using System.Collections;

namespace Samlinger
{
    internal class Hund
    {
        public Hund()
        {
        }
    }

    // Collection klasse
    class Kennel {
        private ArrayList a = new ArrayList();

        public void IndsætHund(Hund h) {
            a.Add(h);
        }
    }
}