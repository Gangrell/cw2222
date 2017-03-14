using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2zad2
{
    public class Mag:Bohater
    {
        int mana = 200;
        ERasa Rasa;
        public Mag(ERasa R,string I)
        {
            imie = I;
            atak = 3;
            hp = 50;
            Rasa = R;
        }

        public void RzucCzar (Wrog W)
        {
            W.hp -= 35;
            mana -= 30;
        }
        public override void BijWroga(Wrog W) {
            if (hp > 0 && W.hp > 0)
                if (mana > 30)
                    RzucCzar(W);
                else
                    W.hp -= this.atak;
        }
        public override int SprawdzHp() { return this.hp; }
    }
}
