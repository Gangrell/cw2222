using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2zad3
{
    public abstract class Piłkarz : Osoba
    {
        string pozycja;
        string klub;
        int liczbaGoli = 0;
        public Piłkarz(string I, string N, string DU, string P, string K) : base(I, N, DU)
        {
            pozycja = P;
            klub = K;
        }

        public void StrzelGola() { liczbaGoli += 1; }
        public override void WypiszInfo() { Console.WriteLine(Imie+" "+Nazwisko+" urodzyny "+ DataUrodzenia +" gra na pozycji " + pozycja+ " w klubie "+klub+" strzelił "+liczbaGoli + " goli."); }
    }
}
