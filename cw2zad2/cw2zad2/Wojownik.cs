using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2zad2
{
    public class Wojownik:Bohater
    {
        ERasa Rasa;
        public Wojownik(ERasa R,string I)
        {
            imie = I;
            atak = 10;
            hp = 150;
            Rasa = R;
        }
        public void RzucTopor(Wrog W)
        {
                W.hp -= 20;
        }
        public override void BijWroga(Wrog W) {
            if (hp > 0 && W.hp > 0)
                if (W.hp < W.hp * 0.4)
                    RzucTopor(W);
                else
                    W.hp -= this.atak;
        }
        public override int SprawdzHp() { return hp; }
    }
}
