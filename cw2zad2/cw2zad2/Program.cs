using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2zad2
{
    class Program
    {
        static void Main(string[] args)
        {

            Mag Gandalf = new Mag(Bohater.ERasa.Człowiek,"Gandalf");

            Wojownik Boromir = new Wojownik(Bohater.ERasa.Człowiek, "Boromir");
            Wojownik Aragorn = new Wojownik(Bohater.ERasa.Człowiek,"Aragorn");
            Wojownik Gimli = new Wojownik(Bohater.ERasa.Krasnal, "Gimli");

            Rzezimieszek Frodo = new Rzezimieszek(Bohater.ERasa.Hobbit, "Frodo");
            Rzezimieszek Sam = new Rzezimieszek(Bohater.ERasa.Hobbit, "Sam");
            Rzezimieszek Merry = new Rzezimieszek(Bohater.ERasa.Hobbit, "Merry");
            Rzezimieszek Pippin = new Rzezimieszek(Bohater.ERasa.Hobbit, "Pippin");

            Rzezimieszek Legolas = new Rzezimieszek(Bohater.ERasa.Elf, "Legolas");

            List<Bohater> FotR = new List<Bohater>();

            FotR.Add(Boromir);
            FotR.Add(Aragorn);
            FotR.Add(Gimli);
            FotR.Add(Gandalf);
            FotR.Add(Frodo);
            FotR.Add(Sam);
            FotR.Add(Merry);
            FotR.Add(Pippin);
            FotR.Add(Legolas);


            Wrog Uruk = new Wrog("Ziomal");

            Random rnd = new Random();

            while(Uruk.hp>0 && FotR.Count>0)
            {
                int i = rnd.Next(0, FotR.Count),j,g;
                j = FotR[i].hp;
                Uruk.Ciach(FotR[i]);
                g = j - FotR[i].hp;
                Console.WriteLine(Uruk.imie + " zadaje " + g + " obrażeń postaci: "+FotR[i].imie+" zostało mu " + FotR[i].hp+" zycia.");

                if (FotR[i].SprawdzHp() <= 0)
                {
                    Console.WriteLine(FotR[i].imie + " odpada z gry");
                    FotR.Remove(FotR[i]);
                }
                if (FotR.Count == 0)
                    break;
                i = rnd.Next(0, FotR.Count);
                j = Uruk.hp; ;
                FotR[i].BijWroga(Uruk);
                g = j - Uruk.hp;
                Console.WriteLine(FotR[i].imie+" zadaje "+ g +" obrażeń postaci "+Uruk.imie+ " zostało mu " +Uruk.hp+" zycia");
                Console.WriteLine("");


            }
            if (FotR.Count > 0)
                Console.WriteLine("Wygrywa drużyna pierścienia");
            else
                Console.WriteLine("Wygrywa Uruk");
        }
    }
}
