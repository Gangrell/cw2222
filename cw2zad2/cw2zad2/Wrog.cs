using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cw2zad2
{
    public class Wrog
    {
        public string imie;
        public int hp = 500;
        public int atak = 30;
        
        public Wrog(string i)
        {
            imie = i;
        }
        public void Ciach(Bohater B)
        {
            if (hp > 150)
                B.hp -= atak;
            else
                B.hp -= atak + atak / 2;
        }

    }
}
