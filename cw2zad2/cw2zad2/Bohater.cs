using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2zad2
{
    public abstract class Bohater : IBohater
    {
        public string imie;
        public int hp;
        protected int atak;
        public enum ERasa { Człowiek, Elf, Krasnal, Hobbit };


        public abstract void BijWroga(Wrog W);
        public abstract int SprawdzHp();
    }
}
