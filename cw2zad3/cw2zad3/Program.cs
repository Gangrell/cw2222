using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            PiłkarzRęczny PR = new PiłkarzRęczny("Jan", "Zagubiony", "260190", "Atak", "RKS Siekiera Piła");
            PR.WypiszInfo();
            PR.StrzelGola();
            PR.WypiszInfo();



            Student S = new Student("Waldek", "Znalazły", "151087", 2, 1, 115478);
            S.WypiszInfo();

            S.DodajOcene("polski", "150217", 2.5);
            S.DodajOcene("polski", "150217", 3.5);
            S.DodajOcene("polski", "150217", 4.5);
            S.WypiszOceny();
            S.UsunOcene("polski", "150217", 2.5);
            S.WypiszOceny();
            S.UsunOceny("polski");
            S.WypiszOceny();
        }
    }
}
