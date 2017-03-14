using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2zad3
{
    class Student : Osoba
    {
        int rok;
        int grupa;
        int nrIndeksu;
        List<Ocena> LO = new List<Ocena>();

        public Student (string I,string N, string DU, int R, int G,int nI):base(I,N,DU)
        {
            rok = R;grupa = G;nrIndeksu = nI;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine(Imie+" "+Nazwisko+" urodzony "+DataUrodzenia+" jest na "+ rok + " roku w grupie " + grupa + " numer indeksu: " + nrIndeksu+".");
        }
        public void DodajOcene(string nP, string D, double W)
        {
            Ocena O = new Ocena(nP, D, W);
            LO.Add(O);
        }

        public void WypiszOceny()
        {
            foreach (Ocena O in LO)
                O.WypiszInfo();

            
        }

        public void WypiszOceny(string nP)
        {
            foreach (Ocena O in LO)
                if (O.WypiszPrzedmiot() == nP)
                    O.WypiszInfo();
        }

        public void UsunOcene(string nP,string D, double W)
        {
            Ocena OO = new Ocena(nP,D,W);
            foreach(Ocena O in LO)
            {
                if (O.WypiszPrzedmiot() == nP && O.WypiszWartosc() == W && O.WypiszDate() == D)
                {
                    LO.Remove(O);
                    break;
                }
            }
        }

        public void UsunOceny() { LO.Clear(); }

        public void UsunOceny(string nP){ LO.RemoveAll(item => item.WypiszPrzedmiot() == nP); }
    }
    
}
