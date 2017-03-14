using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2zad3
{
    class Ocena
    {
        string nazwaPrzedmiotu;
        string data;
        double wartosc;

        public Ocena(string nP,string D,double W) { nazwaPrzedmiotu = nP;data = D;wartosc = W; }

        public void WypiszInfo()
        {
            Console.WriteLine("Przedmio: " + nazwaPrzedmiotu + " dnia: " + data + " ocena: " + wartosc);
        }
        public string WypiszPrzedmiot() { return nazwaPrzedmiotu; }
        public string WypiszDate() { return data; }
        public double WypiszWartosc() { return wartosc; }
    }
}
