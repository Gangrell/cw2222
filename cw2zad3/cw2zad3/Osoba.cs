using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2zad3
{
    public abstract class Osoba
    {
        protected string Imie;
        protected string Nazwisko;
        protected string DataUrodzenia;

        public Osoba(string I, string N, string DU)
        { Imie = I;Nazwisko = N;DataUrodzenia = DU; }

        public abstract void WypiszInfo();
    }
}
